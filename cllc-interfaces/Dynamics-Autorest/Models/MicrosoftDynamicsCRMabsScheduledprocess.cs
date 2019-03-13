// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// abs_scheduledprocess
    /// </summary>
    public partial class MicrosoftDynamicsCRMabsScheduledprocess
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMabsScheduledprocess class.
        /// </summary>
        public MicrosoftDynamicsCRMabsScheduledprocess()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMabsScheduledprocess class.
        /// </summary>
        public MicrosoftDynamicsCRMabsScheduledprocess(int? absInterval = default(int?), bool? absJune = default(bool?), long? versionnumber = default(long?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), int? importsequencenumber = default(int?), int? statecode = default(int?), bool? absMarch = default(bool?), string _owningbusinessunitValue = default(string), string absFetchxmlquery = default(string), bool? absOctober = default(bool?), bool? absThursday = default(bool?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), bool? absApril = default(bool?), int? absRecurrencepattern = default(int?), string _owningteamValue = default(string), int? statuscode = default(int?), bool? absWednesday = default(bool?), string absScheduledprocessid = default(string), bool? absMay = default(bool?), bool? absDecember = default(bool?), bool? absSaturday = default(bool?), string _modifiedbyValue = default(string), int? absHour = default(int?), bool? absFriday = default(bool?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), bool? absTuesday = default(bool?), bool? absAmpm = default(bool?), System.DateTimeOffset? absNextactivation = default(System.DateTimeOffset?), string absName = default(string), string _createdbyValue = default(string), bool? absJuly = default(bool?), bool? absJanuary = default(bool?), int? timezoneruleversionnumber = default(int?), bool? absSuspendonfailure = default(bool?), bool? absNovember = default(bool?), bool? absMonday = default(bool?), int? utcconversiontimezonecode = default(int?), int? absMinute = default(int?), bool? absSeptember = default(bool?), string _owneridValue = default(string), bool? absFebruary = default(bool?), int? absDayofmonth = default(int?), string _owninguserValue = default(string), bool? absAugust = default(bool?), bool? absSunday = default(bool?), string _modifiedonbehalfbyValue = default(string), string _absProcessidValue = default(string), string _createdonbehalfbyValue = default(string), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMactivitypointer> absScheduledprocessActivityPointers = default(IList<MicrosoftDynamicsCRMactivitypointer>), IList<MicrosoftDynamicsCRMappointment> absScheduledprocessAppointments = default(IList<MicrosoftDynamicsCRMappointment>), IList<MicrosoftDynamicsCRMemail> absScheduledprocessEmails = default(IList<MicrosoftDynamicsCRMemail>), IList<MicrosoftDynamicsCRMfax> absScheduledprocessFaxes = default(IList<MicrosoftDynamicsCRMfax>), IList<MicrosoftDynamicsCRMletter> absScheduledprocessLetters = default(IList<MicrosoftDynamicsCRMletter>), IList<MicrosoftDynamicsCRMphonecall> absScheduledprocessPhoneCalls = default(IList<MicrosoftDynamicsCRMphonecall>), IList<MicrosoftDynamicsCRMserviceappointment> absScheduledprocessServiceAppointments = default(IList<MicrosoftDynamicsCRMserviceappointment>), IList<MicrosoftDynamicsCRMtask> absScheduledprocessTasks = default(IList<MicrosoftDynamicsCRMtask>), IList<MicrosoftDynamicsCRMrecurringappointmentmaster> absScheduledprocessRecurringAppointmentMasters = default(IList<MicrosoftDynamicsCRMrecurringappointmentmaster>), IList<MicrosoftDynamicsCRMsocialactivity> absScheduledprocessSocialActivities = default(IList<MicrosoftDynamicsCRMsocialactivity>), IList<MicrosoftDynamicsCRMsyncerror> absScheduledprocessSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> absScheduledprocessAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> absScheduledprocessBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMabsScheduledprocessexecution> absScheduledprocessAbsScheduledprocessexecutions = default(IList<MicrosoftDynamicsCRMabsScheduledprocessexecution>), MicrosoftDynamicsCRMworkflow absProcessId = default(MicrosoftDynamicsCRMworkflow))
        {
            AbsInterval = absInterval;
            AbsJune = absJune;
            Versionnumber = versionnumber;
            Overriddencreatedon = overriddencreatedon;
            Importsequencenumber = importsequencenumber;
            Statecode = statecode;
            AbsMarch = absMarch;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            AbsFetchxmlquery = absFetchxmlquery;
            AbsOctober = absOctober;
            AbsThursday = absThursday;
            Modifiedon = modifiedon;
            AbsApril = absApril;
            AbsRecurrencepattern = absRecurrencepattern;
            this._owningteamValue = _owningteamValue;
            Statuscode = statuscode;
            AbsWednesday = absWednesday;
            AbsScheduledprocessid = absScheduledprocessid;
            AbsMay = absMay;
            AbsDecember = absDecember;
            AbsSaturday = absSaturday;
            this._modifiedbyValue = _modifiedbyValue;
            AbsHour = absHour;
            AbsFriday = absFriday;
            Createdon = createdon;
            AbsTuesday = absTuesday;
            AbsAmpm = absAmpm;
            AbsNextactivation = absNextactivation;
            AbsName = absName;
            this._createdbyValue = _createdbyValue;
            AbsJuly = absJuly;
            AbsJanuary = absJanuary;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            AbsSuspendonfailure = absSuspendonfailure;
            AbsNovember = absNovember;
            AbsMonday = absMonday;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            AbsMinute = absMinute;
            AbsSeptember = absSeptember;
            this._owneridValue = _owneridValue;
            AbsFebruary = absFebruary;
            AbsDayofmonth = absDayofmonth;
            this._owninguserValue = _owninguserValue;
            AbsAugust = absAugust;
            AbsSunday = absSunday;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._absProcessidValue = _absProcessidValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            AbsScheduledprocessActivityPointers = absScheduledprocessActivityPointers;
            AbsScheduledprocessAppointments = absScheduledprocessAppointments;
            AbsScheduledprocessEmails = absScheduledprocessEmails;
            AbsScheduledprocessFaxes = absScheduledprocessFaxes;
            AbsScheduledprocessLetters = absScheduledprocessLetters;
            AbsScheduledprocessPhoneCalls = absScheduledprocessPhoneCalls;
            AbsScheduledprocessServiceAppointments = absScheduledprocessServiceAppointments;
            AbsScheduledprocessTasks = absScheduledprocessTasks;
            AbsScheduledprocessRecurringAppointmentMasters = absScheduledprocessRecurringAppointmentMasters;
            AbsScheduledprocessSocialActivities = absScheduledprocessSocialActivities;
            AbsScheduledprocessSyncErrors = absScheduledprocessSyncErrors;
            AbsScheduledprocessAsyncOperations = absScheduledprocessAsyncOperations;
            AbsScheduledprocessBulkDeleteFailures = absScheduledprocessBulkDeleteFailures;
            AbsScheduledprocessAbsScheduledprocessexecutions = absScheduledprocessAbsScheduledprocessexecutions;
            AbsProcessId = absProcessId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_interval")]
        public int? AbsInterval { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_june")]
        public bool? AbsJune { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_march")]
        public bool? AbsMarch { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_fetchxmlquery")]
        public string AbsFetchxmlquery { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_october")]
        public bool? AbsOctober { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_thursday")]
        public bool? AbsThursday { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_april")]
        public bool? AbsApril { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_recurrencepattern")]
        public int? AbsRecurrencepattern { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_wednesday")]
        public bool? AbsWednesday { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_scheduledprocessid")]
        public string AbsScheduledprocessid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_may")]
        public bool? AbsMay { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_december")]
        public bool? AbsDecember { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_saturday")]
        public bool? AbsSaturday { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_hour")]
        public int? AbsHour { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_friday")]
        public bool? AbsFriday { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_tuesday")]
        public bool? AbsTuesday { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_ampm")]
        public bool? AbsAmpm { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_nextactivation")]
        public System.DateTimeOffset? AbsNextactivation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_name")]
        public string AbsName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_july")]
        public bool? AbsJuly { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_january")]
        public bool? AbsJanuary { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_suspendonfailure")]
        public bool? AbsSuspendonfailure { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_november")]
        public bool? AbsNovember { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_monday")]
        public bool? AbsMonday { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_minute")]
        public int? AbsMinute { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_september")]
        public bool? AbsSeptember { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_february")]
        public bool? AbsFebruary { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_dayofmonth")]
        public int? AbsDayofmonth { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_august")]
        public bool? AbsAugust { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_sunday")]
        public bool? AbsSunday { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_abs_processid_value")]
        public string _absProcessidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_scheduledprocess_ActivityPointers")]
        public IList<MicrosoftDynamicsCRMactivitypointer> AbsScheduledprocessActivityPointers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_scheduledprocess_Appointments")]
        public IList<MicrosoftDynamicsCRMappointment> AbsScheduledprocessAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_scheduledprocess_Emails")]
        public IList<MicrosoftDynamicsCRMemail> AbsScheduledprocessEmails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_scheduledprocess_Faxes")]
        public IList<MicrosoftDynamicsCRMfax> AbsScheduledprocessFaxes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_scheduledprocess_Letters")]
        public IList<MicrosoftDynamicsCRMletter> AbsScheduledprocessLetters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_scheduledprocess_PhoneCalls")]
        public IList<MicrosoftDynamicsCRMphonecall> AbsScheduledprocessPhoneCalls { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_scheduledprocess_ServiceAppointments")]
        public IList<MicrosoftDynamicsCRMserviceappointment> AbsScheduledprocessServiceAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_scheduledprocess_Tasks")]
        public IList<MicrosoftDynamicsCRMtask> AbsScheduledprocessTasks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_scheduledprocess_RecurringAppointmentMasters")]
        public IList<MicrosoftDynamicsCRMrecurringappointmentmaster> AbsScheduledprocessRecurringAppointmentMasters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_scheduledprocess_SocialActivities")]
        public IList<MicrosoftDynamicsCRMsocialactivity> AbsScheduledprocessSocialActivities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_scheduledprocess_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AbsScheduledprocessSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_scheduledprocess_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AbsScheduledprocessAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_scheduledprocess_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AbsScheduledprocessBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_scheduledprocess_abs_scheduledprocessexecutions")]
        public IList<MicrosoftDynamicsCRMabsScheduledprocessexecution> AbsScheduledprocessAbsScheduledprocessexecutions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abs_ProcessId")]
        public MicrosoftDynamicsCRMworkflow AbsProcessId { get; set; }

    }
}