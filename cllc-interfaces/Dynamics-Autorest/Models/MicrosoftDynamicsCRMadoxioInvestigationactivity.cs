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
    /// Microsoft.Dynamics.CRM.adoxio_investigationactivity
    /// </summary>
    public partial class MicrosoftDynamicsCRMadoxioInvestigationactivity
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioInvestigationactivity class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioInvestigationactivity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioInvestigationactivity class.
        /// </summary>
        /// <param name="_modifiedonbehalfbyValue">Unique identifier of the
        /// delegate user who modified the record.</param>
        /// <param name="adoxioName">The name of the custom entity.</param>
        /// <param name="modifiedon">Date and time when the record was
        /// modified.</param>
        /// <param name="_createdbyValue">Unique identifier of the user who
        /// created the record.</param>
        /// <param name="_adoxioInvestigationidValue">Unique identifier for
        /// Investigation (Enforcement) associated with Investigation
        /// Activity.</param>
        /// <param name="statecode">Status of the Investigation
        /// Activity</param>
        /// <param name="adoxioInvestigationactivityid">Unique identifier for
        /// entity instances</param>
        /// <param name="_owninguserValue">Unique identifier for the user that
        /// owns the record.</param>
        /// <param name="utcconversiontimezonecode">Time zone code that was in
        /// use when the record was created.</param>
        /// <param name="_adoxioComplaintidValue">Unique identifier for
        /// Complaint associated with Investigation Activity.</param>
        /// <param name="overriddencreatedon">Date and time that the record was
        /// migrated.</param>
        /// <param name="timezoneruleversionnumber">For internal use
        /// only.</param>
        /// <param name="_owningbusinessunitValue">Unique identifier for the
        /// business unit that owns the record</param>
        /// <param name="_adoxioInspectionidValue">Unique identifier for
        /// Inspection associated with Investigation Activity.</param>
        /// <param name="createdon">Date and time when the record was
        /// created.</param>
        /// <param name="_createdonbehalfbyValue">Unique identifier of the
        /// delegate user who created the record.</param>
        /// <param name="statuscode">Reason for the status of the Investigation
        /// Activity</param>
        /// <param name="_owningteamValue">Unique identifier for the team that
        /// owns the record.</param>
        /// <param name="importsequencenumber">Sequence number of the import
        /// that created this record.</param>
        /// <param name="versionnumber">Version Number</param>
        /// <param name="_adoxioContraventionidValue">Unique identifier for
        /// Contravention associated with Investigation Activity.</param>
        /// <param name="_modifiedbyValue">Unique identifier of the user who
        /// modified the record.</param>
        /// <param name="_owneridValue">Owner Id</param>
        public MicrosoftDynamicsCRMadoxioInvestigationactivity(string _modifiedonbehalfbyValue = default(string), string adoxioName = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string adoxioDescription = default(string), string _createdbyValue = default(string), string _adoxioInvestigationidValue = default(string), int? statecode = default(int?), string adoxioInvestigationactivityid = default(string), string _owninguserValue = default(string), int? utcconversiontimezonecode = default(int?), string _adoxioComplaintidValue = default(string), int? adoxioType = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), int? timezoneruleversionnumber = default(int?), string _owningbusinessunitValue = default(string), string adoxioOtheractivitytype = default(string), string _adoxioInspectionidValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _createdonbehalfbyValue = default(string), System.DateTimeOffset? adoxioInvestigationactivitydate = default(System.DateTimeOffset?), int? statuscode = default(int?), string _owningteamValue = default(string), int? importsequencenumber = default(int?), string versionnumber = default(string), string _adoxioContraventionidValue = default(string), System.DateTimeOffset? adoxioDatefrom = default(System.DateTimeOffset?), string _modifiedbyValue = default(string), string _owneridValue = default(string), System.DateTimeOffset? adoxioDateto = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> adoxioInvestigationactivitySyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioInvestigationactivityDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioInvestigationactivityDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioInvestigationactivityAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioInvestigationactivityBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMadoxioComplianceinvestigation adoxioInvestigationId = default(MicrosoftDynamicsCRMadoxioComplianceinvestigation), MicrosoftDynamicsCRMadoxioComplaint adoxioComplaintId = default(MicrosoftDynamicsCRMadoxioComplaint), MicrosoftDynamicsCRMadoxioContravention adoxioContraventionId = default(MicrosoftDynamicsCRMadoxioContravention), MicrosoftDynamicsCRMincident adoxioInspectionId = default(MicrosoftDynamicsCRMincident))
        {
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            AdoxioName = adoxioName;
            Modifiedon = modifiedon;
            AdoxioDescription = adoxioDescription;
            this._createdbyValue = _createdbyValue;
            this._adoxioInvestigationidValue = _adoxioInvestigationidValue;
            Statecode = statecode;
            AdoxioInvestigationactivityid = adoxioInvestigationactivityid;
            this._owninguserValue = _owninguserValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._adoxioComplaintidValue = _adoxioComplaintidValue;
            AdoxioType = adoxioType;
            Overriddencreatedon = overriddencreatedon;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            AdoxioOtheractivitytype = adoxioOtheractivitytype;
            this._adoxioInspectionidValue = _adoxioInspectionidValue;
            Createdon = createdon;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            AdoxioInvestigationactivitydate = adoxioInvestigationactivitydate;
            Statuscode = statuscode;
            this._owningteamValue = _owningteamValue;
            Importsequencenumber = importsequencenumber;
            Versionnumber = versionnumber;
            this._adoxioContraventionidValue = _adoxioContraventionidValue;
            AdoxioDatefrom = adoxioDatefrom;
            this._modifiedbyValue = _modifiedbyValue;
            this._owneridValue = _owneridValue;
            AdoxioDateto = adoxioDateto;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            AdoxioInvestigationactivitySyncErrors = adoxioInvestigationactivitySyncErrors;
            AdoxioInvestigationactivityDuplicateMatchingRecord = adoxioInvestigationactivityDuplicateMatchingRecord;
            AdoxioInvestigationactivityDuplicateBaseRecord = adoxioInvestigationactivityDuplicateBaseRecord;
            AdoxioInvestigationactivityAsyncOperations = adoxioInvestigationactivityAsyncOperations;
            AdoxioInvestigationactivityBulkDeleteFailures = adoxioInvestigationactivityBulkDeleteFailures;
            AdoxioInvestigationId = adoxioInvestigationId;
            AdoxioComplaintId = adoxioComplaintId;
            AdoxioContraventionId = adoxioContraventionId;
            AdoxioInspectionId = adoxioInspectionId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who modified
        /// the record.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets the name of the custom entity.
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_name")]
        public string AdoxioName { get; set; }

        /// <summary>
        /// Gets or sets date and time when the record was modified.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_description")]
        public string AdoxioDescription { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who created the record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for Investigation (Enforcement)
        /// associated with Investigation Activity.
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_investigationid_value")]
        public string _adoxioInvestigationidValue { get; set; }

        /// <summary>
        /// Gets or sets status of the Investigation Activity
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for entity instances
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_investigationactivityid")]
        public string AdoxioInvestigationactivityid { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for the user that owns the record.
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// Gets or sets time zone code that was in use when the record was
        /// created.
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for Complaint associated with
        /// Investigation Activity.
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_complaintid_value")]
        public string _adoxioComplaintidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_type")]
        public int? AdoxioType { get; set; }

        /// <summary>
        /// Gets or sets date and time that the record was migrated.
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for the business unit that owns the
        /// record
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_otheractivitytype")]
        public string AdoxioOtheractivitytype { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for Inspection associated with
        /// Investigation Activity.
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_inspectionid_value")]
        public string _adoxioInspectionidValue { get; set; }

        /// <summary>
        /// Gets or sets date and time when the record was created.
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who created the
        /// record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_investigationactivitydate")]
        public System.DateTimeOffset? AdoxioInvestigationactivitydate { get; set; }

        /// <summary>
        /// Gets or sets reason for the status of the Investigation Activity
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for the team that owns the record.
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// Gets or sets sequence number of the import that created this
        /// record.
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// Gets or sets version Number
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for Contravention associated with
        /// Investigation Activity.
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_contraventionid_value")]
        public string _adoxioContraventionidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_datefrom")]
        public System.DateTimeOffset? AdoxioDatefrom { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who modified the record.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// Gets or sets owner Id
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_dateto")]
        public System.DateTimeOffset? AdoxioDateto { get; set; }

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
        [JsonProperty(PropertyName = "adoxio_investigationactivity_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioInvestigationactivitySyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_investigationactivity_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioInvestigationactivityDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_investigationactivity_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioInvestigationactivityDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_investigationactivity_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioInvestigationactivityAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_investigationactivity_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioInvestigationactivityBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_InvestigationId")]
        public MicrosoftDynamicsCRMadoxioComplianceinvestigation AdoxioInvestigationId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_ComplaintId")]
        public MicrosoftDynamicsCRMadoxioComplaint AdoxioComplaintId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_ContraventionId")]
        public MicrosoftDynamicsCRMadoxioContravention AdoxioContraventionId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_InspectionId")]
        public MicrosoftDynamicsCRMincident AdoxioInspectionId { get; set; }

    }
}
