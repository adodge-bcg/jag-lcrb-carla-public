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
    /// adoxio_complianceinvestigation
    /// </summary>
    public partial class MicrosoftDynamicsCRMadoxioComplianceinvestigation
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioComplianceinvestigation class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioComplianceinvestigation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioComplianceinvestigation class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioComplianceinvestigation(int? statuscode = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string adoxioInvestigationdescription = default(string), string _createdbyValue = default(string), string _adoxioEstablishmentidValue = default(string), int? timezoneruleversionnumber = default(int?), string _adoxioLicenseeidValue = default(string), string _adoxioAreaidValue = default(string), string adoxioName = default(string), string _adoxioLicenceidValue = default(string), string adoxioRmsummary = default(string), System.DateTimeOffset? adoxioApproveddate = default(System.DateTimeOffset?), string _createdonbehalfbyValue = default(string), int? utcconversiontimezonecode = default(int?), string adoxioComplianceinvestigationid = default(string), int? importsequencenumber = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _owningteamValue = default(string), string _owninguserValue = default(string), long? versionnumber = default(long?), string _modifiedonbehalfbyValue = default(string), string adoxioJobnumber = default(string), string _owningbusinessunitValue = default(string), string _adoxioComplaintidValue = default(string), string _owneridValue = default(string), System.DateTimeOffset? adoxioCompleteddate = default(System.DateTimeOffset?), int? statecode = default(int?), string adoxioInvestigationsummary = default(string), string _modifiedbyValue = default(string), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> adoxioComplianceinvestigationSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioComplianceinvestigationDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioComplianceinvestigationDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioComplianceinvestigationAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioComplianceinvestigationBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMadoxioComplaint adoxioComplaintId = default(MicrosoftDynamicsCRMadoxioComplaint), MicrosoftDynamicsCRMadoxioEstablishment adoxioEstablishmentId = default(MicrosoftDynamicsCRMadoxioEstablishment), MicrosoftDynamicsCRMaccount adoxioLicenseeId = default(MicrosoftDynamicsCRMaccount), IList<MicrosoftDynamicsCRMadoxioInvestigationactivity> adoxioInvestigationInvestigationactivities = default(IList<MicrosoftDynamicsCRMadoxioInvestigationactivity>), IList<MicrosoftDynamicsCRMincident> adoxioInvestigationInspections = default(IList<MicrosoftDynamicsCRMincident>), IList<MicrosoftDynamicsCRMadoxioContravention> adoxioInvestigationContraventions = default(IList<MicrosoftDynamicsCRMadoxioContravention>), MicrosoftDynamicsCRMadoxioLicences adoxioLicenceId = default(MicrosoftDynamicsCRMadoxioLicences), MicrosoftDynamicsCRMadoxioArea adoxioAreaId = default(MicrosoftDynamicsCRMadoxioArea))
        {
            Statuscode = statuscode;
            Overriddencreatedon = overriddencreatedon;
            Modifiedon = modifiedon;
            AdoxioInvestigationdescription = adoxioInvestigationdescription;
            this._createdbyValue = _createdbyValue;
            this._adoxioEstablishmentidValue = _adoxioEstablishmentidValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._adoxioLicenseeidValue = _adoxioLicenseeidValue;
            this._adoxioAreaidValue = _adoxioAreaidValue;
            AdoxioName = adoxioName;
            this._adoxioLicenceidValue = _adoxioLicenceidValue;
            AdoxioRmsummary = adoxioRmsummary;
            AdoxioApproveddate = adoxioApproveddate;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            AdoxioComplianceinvestigationid = adoxioComplianceinvestigationid;
            Importsequencenumber = importsequencenumber;
            Createdon = createdon;
            this._owningteamValue = _owningteamValue;
            this._owninguserValue = _owninguserValue;
            Versionnumber = versionnumber;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            AdoxioJobnumber = adoxioJobnumber;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._adoxioComplaintidValue = _adoxioComplaintidValue;
            this._owneridValue = _owneridValue;
            AdoxioCompleteddate = adoxioCompleteddate;
            Statecode = statecode;
            AdoxioInvestigationsummary = adoxioInvestigationsummary;
            this._modifiedbyValue = _modifiedbyValue;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            AdoxioComplianceinvestigationSyncErrors = adoxioComplianceinvestigationSyncErrors;
            AdoxioComplianceinvestigationDuplicateMatchingRecord = adoxioComplianceinvestigationDuplicateMatchingRecord;
            AdoxioComplianceinvestigationDuplicateBaseRecord = adoxioComplianceinvestigationDuplicateBaseRecord;
            AdoxioComplianceinvestigationAsyncOperations = adoxioComplianceinvestigationAsyncOperations;
            AdoxioComplianceinvestigationBulkDeleteFailures = adoxioComplianceinvestigationBulkDeleteFailures;
            AdoxioComplaintId = adoxioComplaintId;
            AdoxioEstablishmentId = adoxioEstablishmentId;
            AdoxioLicenseeId = adoxioLicenseeId;
            AdoxioInvestigationInvestigationactivities = adoxioInvestigationInvestigationactivities;
            AdoxioInvestigationInspections = adoxioInvestigationInspections;
            AdoxioInvestigationContraventions = adoxioInvestigationContraventions;
            AdoxioLicenceId = adoxioLicenceId;
            AdoxioAreaId = adoxioAreaId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_investigationdescription")]
        public string AdoxioInvestigationdescription { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_establishmentid_value")]
        public string _adoxioEstablishmentidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_licenseeid_value")]
        public string _adoxioLicenseeidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_areaid_value")]
        public string _adoxioAreaidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_name")]
        public string AdoxioName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_licenceid_value")]
        public string _adoxioLicenceidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_rmsummary")]
        public string AdoxioRmsummary { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_approveddate")]
        public System.DateTimeOffset? AdoxioApproveddate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_complianceinvestigationid")]
        public string AdoxioComplianceinvestigationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_jobnumber")]
        public string AdoxioJobnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_complaintid_value")]
        public string _adoxioComplaintidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_completeddate")]
        public System.DateTimeOffset? AdoxioCompleteddate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_investigationsummary")]
        public string AdoxioInvestigationsummary { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

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
        [JsonProperty(PropertyName = "adoxio_complianceinvestigation_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioComplianceinvestigationSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_complianceinvestigation_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioComplianceinvestigationDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_complianceinvestigation_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioComplianceinvestigationDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_complianceinvestigation_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioComplianceinvestigationAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_complianceinvestigation_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioComplianceinvestigationBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_ComplaintId")]
        public MicrosoftDynamicsCRMadoxioComplaint AdoxioComplaintId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_EstablishmentId")]
        public MicrosoftDynamicsCRMadoxioEstablishment AdoxioEstablishmentId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_LicenseeId")]
        public MicrosoftDynamicsCRMaccount AdoxioLicenseeId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_investigation_investigationactivities")]
        public IList<MicrosoftDynamicsCRMadoxioInvestigationactivity> AdoxioInvestigationInvestigationactivities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_investigation_inspections")]
        public IList<MicrosoftDynamicsCRMincident> AdoxioInvestigationInspections { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_investigation_contraventions")]
        public IList<MicrosoftDynamicsCRMadoxioContravention> AdoxioInvestigationContraventions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_LicenceId")]
        public MicrosoftDynamicsCRMadoxioLicences AdoxioLicenceId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_AreaId")]
        public MicrosoftDynamicsCRMadoxioArea AdoxioAreaId { get; set; }

    }
}