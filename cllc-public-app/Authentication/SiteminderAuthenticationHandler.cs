﻿using Gov.Lclb.Cllb.Interfaces;
using Gov.Lclb.Cllb.Public.Models;
using Gov.Lclb.Cllb.Public.Utils;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Security.Claims;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Gov.Lclb.Cllb.Interfaces.Models;
using static Gov.Lclb.Cllb.Services.FileManager.FileManager;
using Gov.Lclb.Cllb.Services.FileManager;
using System.Collections.Generic;
using Microsoft.Extensions.Primitives;

namespace Gov.Lclb.Cllb.Public.Authentication
{
    #region SiteMinder Authentication Options
    /// <summary>
    /// Options required for setting up SiteMinder Authentication
    /// </summary>
    public class SiteMinderAuthOptions : AuthenticationSchemeOptions
    {
        // note that header keys are case insensitive, thus the reason why the keys are all lower case.

        private const string ConstDevAuthenticationTokenKey = "DEV-USER";
        private const string ConstDevBCSCAuthenticationTokenKey = "DEV-BCSC-USER";
        private const string ConstDevDefaultUserId = "TMcTesterson";
        private const string ConstSiteMinderUserGuidKey = "smgov_userguid"; //deprecated -- smgov_useridentifier
        private const string ConstSiteMinderUserIdentifierKey = "smgov_useridentifier";
        private const string ConstSiteMinderUniversalIdKey = "sm_universalid";
        private const string ConstSiteMinderUserNameKey = "sm_user";

        //BCeId Values
        private const string ConstSiteMinderBusinessGuidKey = "smgov_businessguid";
        private const string ConstSiteMinderBusinessLegalNameKey = "smgov_businesslegalname";

        //BC Services Card
        private const string ConstSiteMinderBirthDate = "smgov_birthdate";

        //BCeID or BC Services Card
        private const string ConstSiteMinderUserType = "smgov_usertype"; // get the type values from siteminder header this will be bceid or bcservices

        private const string ConstSiteMinderUserDisplayNameKey = "smgov_userdisplayname";

        private const string ConstMissingSiteMinderUserIdError = "Missing SiteMinder UserId";
        private const string ConstMissingSiteMinderGuidError = "Missing SiteMinder Guid";
        private const string ConstMissingSiteMinderUserTypeError = "Missing SiteMinder User Type";
        private const string ConstMissingDbUserIdError = "Could not find UserId in the database";
        private const string ConstUnderageError = "You must be 19 years of age or older to access this website.";

        private const string ConstInactivegDbUserIdError = "Database UserId is inactive";
        private const string ConstInvalidPermissions = "UserId does not have valid permissions";

        /// <summary>
        /// DEfault Constructor
        /// </summary>
        public SiteMinderAuthOptions()
        {
            SiteMinderBusinessGuidKey = ConstSiteMinderBusinessGuidKey;
            SiteMinderUserGuidKey = ConstSiteMinderUserGuidKey;
            SiteMinderUserIdentifierKey = ConstSiteMinderUserIdentifierKey;
            SiteMinderUniversalIdKey = ConstSiteMinderUniversalIdKey;
            SiteMinderUserNameKey = ConstSiteMinderUserNameKey;
            SiteMinderUserDisplayNameKey = ConstSiteMinderUserDisplayNameKey;
            SiteMinderUserTypeKey = ConstSiteMinderUserType;
            SiteMinderBirthDate = ConstSiteMinderBirthDate;
            MissingSiteMinderUserIdError = ConstMissingSiteMinderUserIdError;
            MissingSiteMinderUserTypeError = ConstMissingSiteMinderUserIdError;
            MissingSiteMinderGuidError = ConstMissingSiteMinderGuidError;
            MissingDbUserIdError = ConstMissingDbUserIdError;
            InactivegDbUserIdError = ConstInactivegDbUserIdError;
            InvalidPermissions = ConstInvalidPermissions;
            DevAuthenticationTokenKey = ConstDevAuthenticationTokenKey;
            DevBCSCAuthenticationTokenKey = ConstDevBCSCAuthenticationTokenKey;
            DevDefaultUserId = ConstDevDefaultUserId;
            UnderageError = ConstUnderageError;
        }

        /// <summary>
        /// Default Scheme Name
        /// </summary>
        public static string AuthenticationSchemeName => "site-minder-auth";

        /// <summary>
        /// SiteMinder Authentication Scheme Name
        /// </summary>
        public string Scheme => AuthenticationSchemeName;

        public string SiteMinderBusinessGuidKey { get; set; }

        /// <summary>
        /// User GUID
        /// </summary>
        public string SiteMinderUserGuidKey { get; set; }

        /// <summary>
        /// User Identifier
        /// </summary>
        public string SiteMinderUserIdentifierKey { get; set; }

        /// <summary>
        /// User Id
        /// </summary>
        public string SiteMinderUniversalIdKey { get; set; }

        /// <summary>
        /// User Name
        /// </summary>
        public string SiteMinderUserNameKey { get; set; }

        /// <summary>
        /// User's Display Name
        /// </summary>
        public string SiteMinderUserDisplayNameKey { get; set; }

        ///<summary>
        ///User's Type (BCeID or BC services card)
        /// </summary>
        public string SiteMinderUserTypeKey { get; set; }

        /// <summary>
        /// BC Service Card - Birth Date field.
        /// </summary>
        public string SiteMinderBirthDate { get; set; }

        /// <summary>
        /// Missing SiteMinder User Type Error
        /// </summary>
        public string MissingSiteMinderUserTypeError { get; set; }

        /// <summary>
        /// Missing SiteMinder UserId Error
        /// </summary>
        public string MissingSiteMinderUserIdError { get; set; }

        /// <summary>
        /// Missing SiteMinder Guid Error
        /// </summary>
        public string MissingSiteMinderGuidError { get; set; }

        /// <summary>
        /// Missing Database UserId Error
        /// </summary>
        public string MissingDbUserIdError { get; set; }

        /// <summary>
        /// Inactive Database UserId Error
        /// </summary>
        public string InactivegDbUserIdError { get; set; }

        /// <summary>
        /// Inactive Database UserId Error
        /// </summary>
        public string UnderageError { get; set; }

        /// <summary>
        /// User does not jave active / valid permissions
        /// </summary>
        public string InvalidPermissions { get; set; }

        /// <summary>
        /// Development Environment Authentication Key
        /// </summary>
        public string DevAuthenticationTokenKey { get; set; }

        /// <summary>
        /// Development Environment Authentication Key
        /// </summary>
        public string DevBCSCAuthenticationTokenKey { get; set; }

        /// <summary>
        /// Development Environment efault UserId
        /// </summary>
        public string DevDefaultUserId { get; set; }
    }
    #endregion    

    /// <summary>
    /// Setup Siteminder Authentication Handler
    /// </summary>
    public static class SiteminderAuthenticationExtensions
    {
        /// <summary>
        /// Add Authentication Handler
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="configureOptions"></param>
        /// <returns></returns>
        public static AuthenticationBuilder AddSiteminderAuth(this AuthenticationBuilder builder, Action<SiteMinderAuthOptions> configureOptions)
        {
            return builder.AddScheme<SiteMinderAuthOptions, SiteminderAuthenticationHandler>(SiteMinderAuthOptions.AuthenticationSchemeName, configureOptions);
        }
    }

    /// <summary>
    /// Siteminder Authentication Handler
    /// </summary>
    public class SiteminderAuthenticationHandler : AuthenticationHandler<SiteMinderAuthOptions>
    {
        private readonly ILogger _logger;

        /// <summary>
        /// Siteminder Authentication Constructir
        /// </summary>
        /// <param name="configureOptions"></param>
        /// <param name="loggerFactory"></param>
        /// <param name="encoder"></param>
        /// <param name="clock"></param>
        public SiteminderAuthenticationHandler(IOptionsMonitor<SiteMinderAuthOptions> configureOptions, ILoggerFactory loggerFactory, UrlEncoder encoder, ISystemClock clock)
            : base(configureOptions, loggerFactory, encoder, clock)
        {
            _logger = loggerFactory.CreateLogger(typeof(SiteminderAuthenticationHandler));
        }

        /// <summary>
        /// Process Authentication Request
        /// </summary>
        /// <returns></returns>
        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            // get siteminder headers
            _logger.LogDebug("Parsing the HTTP headers for SiteMinder authentication credential");

            SiteMinderAuthOptions options = new SiteMinderAuthOptions();
            bool isDeveloperLogin = false;
            bool isBCSCDeveloperLogin = false;
            try
            {
                ClaimsPrincipal principal;
                HttpContext context = Request.HttpContext;
                IDynamicsClient _dynamicsClient = (IDynamicsClient)context.RequestServices.GetService(typeof(IDynamicsClient));

                FileManagerClient _fileManagerClient = (FileManagerClient)context.RequestServices.GetService(typeof(FileManagerClient));

                IWebHostEnvironment hostingEnv = (IWebHostEnvironment)context.RequestServices.GetService(typeof(IWebHostEnvironment));

                UserSettings userSettings = new UserSettings();

                string userId = null;
                string devCompanyId = null;
                string siteMinderGuid = "";
                string siteMinderBusinessGuid = "";
                string siteMinderUserType = "";

                // **************************************************
                // If this is an Error or Authentiation API - Ignore
                // **************************************************
                string url = context.Request.GetDisplayUrl().ToLower();

                if (url.Contains(".js"))
                {
                    return AuthenticateResult.NoResult();
                }

                // **************************************************
                // Check if we have a Dev Environment Cookie
                // **************************************************
                if (!hostingEnv.IsProduction())
                {
                    // check for a fake BCeID login in dev mode
                    string temp = context.Request.Cookies[options.DevAuthenticationTokenKey];

                    if (string.IsNullOrEmpty(temp)) // could be an automated test user.
                    {
                        temp = context.Request.Headers["DEV-USER"];
                    }

                    if (!string.IsNullOrEmpty(temp))
                    {
                        if (temp.Contains("::"))
                        {
                            var temp2 = temp.Split("::");
                            userId = temp2[0];
                            if (temp2.Length >= 2)
                                devCompanyId = temp2[1];
                            else
                                devCompanyId = temp2[0];
                        }
                        else
                        {
                            userId = temp;
                            devCompanyId = temp;
                        }
                        isDeveloperLogin = true;

                        _logger.LogDebug("Got user from dev cookie = " + userId + ", company = " + devCompanyId);
                    }
                    else
                    {
                        // same set of tests for a BC Services Card dev login
                        temp = context.Request.Cookies[options.DevBCSCAuthenticationTokenKey];

                        if (string.IsNullOrEmpty(temp)) // could be an automated test user.
                        {
                            temp = context.Request.Headers["DEV-BCSC-USER"];
                        }

                        if (!string.IsNullOrEmpty(temp))
                        {
                            userId = temp;
                            isBCSCDeveloperLogin = true;

                            _logger.LogDebug("Got user from dev cookie = " + userId);
                        }
                    }
                }

                // **************************************************
                // Check if the user session is already created
                // **************************************************
                try
                {
                    _logger.LogDebug("Checking user session");
                    userSettings = UserSettings.ReadUserSettings(context);
                    _logger.LogDebug("UserSettings found: " + userSettings.GetJson());
                }
                catch
                {
                    //do nothing
                    _logger.LogDebug("No UserSettings found");
                }

                // is user authenticated - if so we're done
                if ((userSettings.UserAuthenticated && string.IsNullOrEmpty(userId)) ||
                    (userSettings.UserAuthenticated && !string.IsNullOrEmpty(userId) &&
                     !string.IsNullOrEmpty(userSettings.UserId) && userSettings.UserId == userId))
                {
                    _logger.LogDebug("User already authenticated with active session: " + userSettings.UserId);
                    principal = userSettings.AuthenticatedUser.ToClaimsPrincipal(options.Scheme, userSettings.UserType);
                    return AuthenticateResult.Success(new AuthenticationTicket(principal, null, Options.Scheme));
                }

                string smgov_userdisplayname = context.Request.Headers["smgov_userdisplayname"];
                if (!string.IsNullOrEmpty(smgov_userdisplayname))
                {
                    userSettings.UserDisplayName = smgov_userdisplayname;
                }

                string smgov_businesslegalname = context.Request.Headers["smgov_businesslegalname"];
                if (!string.IsNullOrEmpty(smgov_businesslegalname))
                {
                    userSettings.BusinessLegalName = smgov_businesslegalname;
                }

                // **************************************************
                // Authenticate based on SiteMinder Headers
                // **************************************************
                _logger.LogDebug("Parsing the HTTP headers for SiteMinder authentication credential");

                // At this point userID would only be set if we are logging in through as a DEV user

                if (string.IsNullOrEmpty(userId))
                {
                    _logger.LogDebug("Getting user data from headers");

                    userId = context.Request.Headers[options.SiteMinderUserNameKey];
                    if (string.IsNullOrEmpty(userId))
                    {
                        userId = context.Request.Headers[options.SiteMinderUniversalIdKey];
                    }

                    siteMinderGuid = context.Request.Headers[options.SiteMinderUserGuidKey];
                    siteMinderBusinessGuid = context.Request.Headers[options.SiteMinderBusinessGuidKey];
                    siteMinderUserType = context.Request.Headers[options.SiteMinderUserTypeKey];


                    // **************************************************
                    // Validate credentials
                    // **************************************************
                    if (string.IsNullOrEmpty(userId))
                    {
                        _logger.LogDebug(options.MissingSiteMinderUserIdError);
                        return AuthenticateResult.Fail(options.MissingSiteMinderGuidError);
                    }

                    if (string.IsNullOrEmpty(siteMinderGuid))
                    {
                        _logger.LogDebug(options.MissingSiteMinderGuidError);
                        return AuthenticateResult.Fail(options.MissingSiteMinderGuidError);
                    }
                    if (string.IsNullOrEmpty(siteMinderUserType))
                    {
                        _logger.LogDebug(options.MissingSiteMinderUserTypeError);
                        return AuthenticateResult.Fail(options.MissingSiteMinderUserTypeError);
                    }
                }
                else // DEV user, setup a fake session and SiteMinder headers.
                {
                    if (isDeveloperLogin)
                    {
                        _logger.LogDebug("Generating a Development user");
                        userSettings.BusinessLegalName = devCompanyId + " TestBusiness";
                        userSettings.UserDisplayName = userId + " TestUser";
                        siteMinderGuid = GuidUtility.CreateIdForDynamics("contact", userSettings.UserDisplayName).ToString();
                        siteMinderBusinessGuid = GuidUtility.CreateIdForDynamics("account", userSettings.BusinessLegalName).ToString();
                        siteMinderUserType = "Business";
                    }
                    else if (isBCSCDeveloperLogin)
                    {
                        _logger.LogDebug("Generating a Development BC Services user");
                        userSettings.BusinessLegalName = null;
                        userSettings.UserDisplayName = userId + " Associate";
                        siteMinderGuid = GuidUtility.CreateIdForDynamics("bcsc", userSettings.UserDisplayName).ToString();
                        siteMinderBusinessGuid = null;
                        siteMinderUserType = "VerifiedIndividual";
                    }
                }

                // Previously the code would do a database lookup here.  However there is no backing database for the users table now,
                // so we just do a Dynamics lookup on the siteMinderGuid.

                _logger.LogDebug("Loading user external id = " + siteMinderGuid);
                userSettings.AuthenticatedUser = await _dynamicsClient.LoadUser(siteMinderGuid, context.Request.Headers, _logger);
                _logger.LogDebug("After getting authenticated user = " + userSettings.GetJson());


                // check that the potential new user is 19.
                if (userSettings.AuthenticatedUser != null && userSettings.AuthenticatedUser.ContactId == null)
                {
                    string rawBirthDate = context.Request.Headers[options.SiteMinderBirthDate];
                    // get the birthdate.
                    if (DateTimeOffset.TryParse(rawBirthDate, out DateTimeOffset birthDate))
                    {
                        DateTimeOffset nineteenYears = DateTimeOffset.Now.AddYears(-19);
                        if (birthDate > nineteenYears)
                        {
                            // younger than 19, cannot login.
                            return AuthenticateResult.Fail(options.UnderageError);
                        }
                    }
                }

                if (userSettings.AuthenticatedUser != null && !userSettings.AuthenticatedUser.Active)
                {

                    _logger.LogDebug(options.InactivegDbUserIdError + " (" + userId + ")");
                    return AuthenticateResult.Fail(options.InactivegDbUserIdError);
                }

                if (userSettings.AuthenticatedUser != null && !String.IsNullOrEmpty(siteMinderUserType))
                {
                    userSettings.AuthenticatedUser.UserType = siteMinderUserType;
                }
                userSettings.UserType = siteMinderUserType;

                // This line gets the various claims for the current user.
                ClaimsPrincipal userPrincipal = userSettings.AuthenticatedUser.ToClaimsPrincipal(options.Scheme, userSettings.UserType);

                // **************************************************
                // Create authenticated user
                // **************************************************
                _logger.LogDebug("Authentication successful: " + userId);
                _logger.LogDebug("Setting identity and creating session for: " + userId);

                // create session info for the current user
                userSettings.UserId = userId;
                userSettings.UserAuthenticated = true;
                userSettings.IsNewUserRegistration = (userSettings.AuthenticatedUser == null);

                // set other session info
                userSettings.SiteMinderGuid = siteMinderGuid;
                userSettings.SiteMinderBusinessGuid = siteMinderBusinessGuid;
                _logger.LogDebug("Before getting contact and account ids = " + userSettings.GetJson());

                if (userSettings.AuthenticatedUser != null)
                {
                    userSettings.ContactId = userSettings.AuthenticatedUser.ContactId.ToString();
                    // ensure that the given account has a documents folder.
                    
                    if (siteMinderBusinessGuid != null) // BCeID user
                    {
                        var contact = _dynamicsClient.GetContactByExternalId(userSettings.ContactId);
                        if (contact != null && contact.Contactid != null)
                        {
                            await CreateContactDocumentLocation(_dynamicsClient, _fileManagerClient, contact);
                        }


                        var account = await _dynamicsClient.GetAccountBySiteminderBusinessGuid(siteMinderBusinessGuid);
                        if (account != null && account.Accountid != null)
                        {
                            userSettings.AccountId = account.Accountid;
                            userSettings.AuthenticatedUser.AccountId = Guid.Parse(account.Accountid);

                            // ensure that the given account has a documents folder.
                            await CreateAccountDocumentLocation(_dynamicsClient, _fileManagerClient, account);
                        }
                    }
                }

                if (!hostingEnv.IsProduction() && (isDeveloperLogin || isBCSCDeveloperLogin))
                {
                    _logger.LogDebug("DEV MODE Setting identity and creating session for: " + userId);

                    if (isDeveloperLogin)
                    {
                        userSettings.BusinessLegalName = devCompanyId + " TestBusiness";
                        userSettings.UserDisplayName = userId + " TestUser";

                        // add generated guids
                        userSettings.SiteMinderBusinessGuid = GuidUtility.CreateIdForDynamics("account", userSettings.BusinessLegalName).ToString();
                        userSettings.SiteMinderGuid = GuidUtility.CreateIdForDynamics("contact", userSettings.UserDisplayName).ToString();
                    }
                    else if (isBCSCDeveloperLogin)
                    {
                        userSettings.BusinessLegalName = null;
                        userSettings.UserDisplayName = userId + " Associate";

                        // add generated guids
                        userSettings.SiteMinderBusinessGuid = null;
                        userSettings.SiteMinderGuid = GuidUtility.CreateIdForDynamics("bcsc", userSettings.UserDisplayName).ToString();
                    }

                    if (userSettings.IsNewUserRegistration)
                    {
                        if (isDeveloperLogin)
                        {
                            // add generated guids
                            userSettings.AccountId = userSettings.SiteMinderBusinessGuid;
                            userSettings.ContactId = userSettings.SiteMinderGuid;
                        }
                        else if (isBCSCDeveloperLogin)
                        {
                            // set to null for now
                            userSettings.AccountId = null;
                            userSettings.ContactId = null;
                        }

                        _logger.LogDebug("New user registration:" + userSettings.UserDisplayName);
                        _logger.LogDebug("userSettings.SiteMinderBusinessGuid:" + userSettings.SiteMinderBusinessGuid);
                        _logger.LogDebug("userSettings.SiteMinderGuid:" + userSettings.SiteMinderGuid);
                        _logger.LogDebug("userSettings.AccountId:" + userSettings.AccountId);
                        _logger.LogDebug("userSettings.ContactId:" + userSettings.ContactId);
                    }
                    // Set account ID from authenticated user
                    else if (userSettings.AuthenticatedUser != null)
                    {
                        // populate the business GUID.
                        if (string.IsNullOrEmpty(userSettings.AccountId))
                        {
                            userSettings.AccountId = userSettings.AuthenticatedUser.AccountId.ToString();
                        }
                        if (string.IsNullOrEmpty(userSettings.ContactId))
                        {
                            userSettings.ContactId = userSettings.AuthenticatedUser.ContactId.ToString();
                        }
                        _logger.LogDebug("Returning user:" + userSettings.UserDisplayName);
                        _logger.LogDebug("userSettings.AccountId:" + userSettings.AccountId);
                        _logger.LogDebug("userSettings.ContactId:" + userSettings.ContactId);
                    }
                }

                // add the worker settings if it is a new user.
                if (userSettings.IsNewUserRegistration)
                {
                    userSettings.NewWorker = new ViewModels.Worker();
                    userSettings.NewWorker.CopyHeaderValues(context.Request.Headers);

                    userSettings.NewContact = new ViewModels.Contact();
                    userSettings.NewContact.CopyHeaderValues(context.Request.Headers);
                }
                else if (siteMinderUserType == "VerifiedIndividual")
                {
                    // Verified individual is from BC Service Card which means it's a worker
                    // Update contact and worker with latest info from BC Service Card
                    ViewModels.Contact contact = new ViewModels.Contact();
                    contact.CopyHeaderValues(context.Request.Headers);

                    MicrosoftDynamicsCRMcontact savedContact = _dynamicsClient.Contacts.GetByKey(userSettings.ContactId);
                    if (savedContact.Address1Line1 != null && savedContact.Address1Line1 != contact.address1_line1) {
                        MicrosoftDynamicsCRMadoxioPreviousaddress prevAddress = new MicrosoftDynamicsCRMadoxioPreviousaddress() {
                            AdoxioStreetaddress = savedContact.Address1Line1,
                            AdoxioProvstate = savedContact.Address1Stateorprovince,
                            AdoxioCity = savedContact.Address1City,
                            AdoxioCountry = savedContact.Address1Country,
                            AdoxioPostalcode = savedContact.Address1Postalcode,
                            ContactIdODataBind = _dynamicsClient.GetEntityURI("contacts", savedContact.Contactid)
                        };
                        _dynamicsClient.Previousaddresses.Create(prevAddress);
                    }

                    
                    _dynamicsClient.Contacts.Update(userSettings.ContactId, contact.ToModel());
                    

                    ViewModels.Worker worker = new ViewModels.Worker();
                    worker.CopyHeaderValues(context.Request.Headers);
                    MicrosoftDynamicsCRMadoxioWorker savedWorker = _dynamicsClient.Workers.Get(filter: $"_adoxio_contactid_value eq {userSettings.ContactId}").Value[0];
                    MicrosoftDynamicsCRMadoxioWorker patchWorker = new MicrosoftDynamicsCRMadoxioWorker() {
                        AdoxioFirstname = worker.firstname,
                        AdoxioLastname = worker.lastname,
                        AdoxioMiddlename = worker.middlename
                    };
                    if (worker.gender != 0) {
                        patchWorker.AdoxioGendercode = (int)worker.gender;
                    }
                    
                    _dynamicsClient.Workers.Update(savedWorker.AdoxioWorkerid, patchWorker);
                    
                }

                // **************************************************
                // Update user settings
                // **************************************************                
                UserSettings.SaveUserSettings(userSettings, context);

                // done!
                principal = userPrincipal;
                return AuthenticateResult.Success(new AuthenticationTicket(principal, null, Options.Scheme));
            }
            catch (Exception exception)
            {
                _logger.LogError(exception.Message);
                throw;
            }
        }

        private async Task CreateContactDocumentLocation(IDynamicsClient _dynamicsClient, FileManagerClient _fileManagerClient, MicrosoftDynamicsCRMcontact contact)
        {
            string folderName = "";
            try
            { 

                folderName = contact.GetDocumentFolderName();

                var createFolderRequest = new CreateFolderRequest()
                {
                    EntityName = "contact",
                    FolderName = folderName
                };

                var createFolderResult = _fileManagerClient.CreateFolder(createFolderRequest);

                if (createFolderResult.ResultStatus == ResultStatus.Fail)
                {
                    _logger.LogError($"Error creating folder for contact {folderName}. Error is {createFolderResult.ErrorDetail}");
                }
            }
            catch (Exception e)
            {
                _logger.LogError(e, $"Error creating folder for contact {folderName}");
            }
        }

        private async Task CreateAccountDocumentLocation(IDynamicsClient _dynamicsClient, FileManagerClient _fileManagerClient, MicrosoftDynamicsCRMaccount account)
        {
            string folderName = "";
            try
            {                

                folderName = account.GetDocumentFolderName();
               
                var createFolderRequest = new CreateFolderRequest()
                {
                    EntityName = "account",
                    FolderName = folderName
                };

                var createFolderResult = _fileManagerClient.CreateFolder(createFolderRequest);

                if (createFolderResult.ResultStatus == ResultStatus.Fail)
                {
                    _logger.LogError($"Error creating folder for account {folderName}. Error is {createFolderResult.ErrorDetail}");
                }
            }
            catch (Exception e)
            {
                _logger.LogError(e, $"Error creating folder for account {folderName}");
            }
            

            /*
            // now create a document location to link them.

            // Create the SharePointDocumentLocation entity
            MicrosoftDynamicsCRMsharepointdocumentlocation mdcsdl = new MicrosoftDynamicsCRMsharepointdocumentlocation()
            {
                Relativeurl = folderName,
                Description = "Account Files",
                Name = name
            };


            try
            {
                mdcsdl = _dynamicsClient.Sharepointdocumentlocations.Create(mdcsdl);
            }
            catch (OdataerrorException odee)
            {
                _logger.LogError("Error creating SharepointDocumentLocation");
                _logger.LogError("Request:");
                _logger.LogError(odee.Request.Content);
                _logger.LogError("Response:");
                _logger.LogError(odee.Response.Content);
                mdcsdl = null;
            }
            if (mdcsdl != null)
            {

                // set the parent document library.
                string parentDocumentLibraryReference = GetDocumentLocationReferenceByRelativeURL("account");

                string accountUri = _dynamicsClient.GetEntityURI("accounts", account.Accountid);
                // add a regardingobjectid.
                var patchSharePointDocumentLocationIncident = new MicrosoftDynamicsCRMsharepointdocumentlocation()
                {
                    RegardingobjectIdAccountODataBind = accountUri,
                    ParentsiteorlocationSharepointdocumentlocationODataBind = _dynamicsClient.GetEntityURI("sharepointdocumentlocations", parentDocumentLibraryReference),
                    Relativeurl = folderName,
                    Description = "Account Files",
                };

                try
                {
                    _dynamicsClient.Sharepointdocumentlocations.Update(mdcsdl.Sharepointdocumentlocationid, patchSharePointDocumentLocationIncident);
                }
                catch (OdataerrorException odee)
                {
                    _logger.LogError("Error adding reference SharepointDocumentLocation to account");
                    _logger.LogError("Request:");
                    _logger.LogError(odee.Request.Content);
                    _logger.LogError("Response:");
                    _logger.LogError(odee.Response.Content);
                }

                string sharePointLocationData = _dynamicsClient.GetEntityURI("sharepointdocumentlocations", mdcsdl.Sharepointdocumentlocationid);

                OdataId oDataId = new OdataId()
                {
                    OdataIdProperty = sharePointLocationData
                };
                try
                {
                    _dynamicsClient.Accounts.AddReference(account.Accountid, "Account_SharepointDocumentLocation", oDataId);
                }
                catch (OdataerrorException odee)
                {
                    _logger.LogError("Error adding reference to SharepointDocumentLocation");
                    _logger.LogError("Request:");
                    _logger.LogError(odee.Request.Content);
                    _logger.LogError("Response:");
                    _logger.LogError(odee.Response.Content);
                }
            }
            */
        }
    }
}
