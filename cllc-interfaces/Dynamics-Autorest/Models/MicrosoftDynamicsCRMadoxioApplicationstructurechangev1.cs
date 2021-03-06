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
    /// Microsoft.Dynamics.CRM.adoxio_applicationstructurechangev1
    /// </summary>
    public partial class MicrosoftDynamicsCRMadoxioApplicationstructurechangev1
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioApplicationstructurechangev1 class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioApplicationstructurechangev1()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioApplicationstructurechangev1 class.
        /// </summary>
        /// <param name="timezoneruleversionnumber">For internal use
        /// only.</param>
        /// <param name="_activestageidValue">Unique identifier of the active
        /// stage for the Business Process Flow instance.</param>
        /// <param name="traversedpath">Comma delimited string of process stage
        /// ids that represent visited stages of the Business Process Flow
        /// instance.</param>
        /// <param name="createdon">Date and time when the record was
        /// created.</param>
        /// <param name="utcconversiontimezonecode">Time zone code that was in
        /// use when the record was created.</param>
        /// <param name="_createdonbehalfbyValue">Unique identifier of the
        /// delegate user who created the record.</param>
        /// <param name="bpfDuration">Duration of Business Process Flow</param>
        /// <param name="_createdbyValue">Unique identifier of the user who
        /// created the record.</param>
        /// <param name="_modifiedbyValue">Unique identifier of the user who
        /// modified the record.</param>
        /// <param name="_modifiedonbehalfbyValue">Unique identifier of the
        /// delegate user who modified the record.</param>
        /// <param name="completedon">Date and time when Business Process Flow
        /// instance is completed.</param>
        /// <param name="_processidValue">Unique identifier of the workflow
        /// associated to the Business Process Flow instance.</param>
        /// <param name="modifiedon">Date and time when the record was
        /// modified.</param>
        /// <param name="businessprocessflowinstanceid">Unique identifier for
        /// entity instances</param>
        /// <param name="_organizationidValue">Unique identifier for the
        /// organization</param>
        /// <param name="activestagestartedon">Date and time when current
        /// active stage is started</param>
        /// <param name="overriddencreatedon">Date and time that the record was
        /// migrated.</param>
        /// <param name="bpfName">Description</param>
        /// <param name="statuscode">Reason for the status of the Application:
        /// Structure Change v1</param>
        /// <param name="importsequencenumber">Sequence number of the import
        /// that created this record.</param>
        /// <param name="statecode">Status of the Application: Structure Change
        /// v1</param>
        /// <param name="versionnumber">Version Number</param>
        public MicrosoftDynamicsCRMadoxioApplicationstructurechangev1(int? timezoneruleversionnumber = default(int?), string _activestageidValue = default(string), string traversedpath = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), int? utcconversiontimezonecode = default(int?), string _createdonbehalfbyValue = default(string), int? bpfDuration = default(int?), string _createdbyValue = default(string), string _modifiedbyValue = default(string), string _modifiedonbehalfbyValue = default(string), System.DateTimeOffset? completedon = default(System.DateTimeOffset?), string _processidValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string businessprocessflowinstanceid = default(string), string _organizationidValue = default(string), System.DateTimeOffset? activestagestartedon = default(System.DateTimeOffset?), string _bpfAdoxioApplicationidValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string bpfName = default(string), int? statuscode = default(int?), int? importsequencenumber = default(int?), int? statecode = default(int?), string versionnumber = default(string), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), MicrosoftDynamicsCRMprocessstage activestageidname = default(MicrosoftDynamicsCRMprocessstage), MicrosoftDynamicsCRMworkflow processidname = default(MicrosoftDynamicsCRMworkflow), IList<MicrosoftDynamicsCRMsyncerror> adoxioApplicationstructurechangev1SyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioApplicationstructurechangev1AsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMworkflowlog> adoxioApplicationstructurechangev1WorkflowLogs = default(IList<MicrosoftDynamicsCRMworkflowlog>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioApplicationstructurechangev1BulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMadoxioApplication bpfAdoxioApplicationid = default(MicrosoftDynamicsCRMadoxioApplication))
        {
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._activestageidValue = _activestageidValue;
            Traversedpath = traversedpath;
            Createdon = createdon;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            BpfDuration = bpfDuration;
            this._createdbyValue = _createdbyValue;
            this._modifiedbyValue = _modifiedbyValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Completedon = completedon;
            this._processidValue = _processidValue;
            Modifiedon = modifiedon;
            Businessprocessflowinstanceid = businessprocessflowinstanceid;
            this._organizationidValue = _organizationidValue;
            Activestagestartedon = activestagestartedon;
            this._bpfAdoxioApplicationidValue = _bpfAdoxioApplicationidValue;
            Overriddencreatedon = overriddencreatedon;
            BpfName = bpfName;
            Statuscode = statuscode;
            Importsequencenumber = importsequencenumber;
            Statecode = statecode;
            Versionnumber = versionnumber;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Organizationid = organizationid;
            Activestageidname = activestageidname;
            Processidname = processidname;
            AdoxioApplicationstructurechangev1SyncErrors = adoxioApplicationstructurechangev1SyncErrors;
            AdoxioApplicationstructurechangev1AsyncOperations = adoxioApplicationstructurechangev1AsyncOperations;
            AdoxioApplicationstructurechangev1WorkflowLogs = adoxioApplicationstructurechangev1WorkflowLogs;
            AdoxioApplicationstructurechangev1BulkDeleteFailures = adoxioApplicationstructurechangev1BulkDeleteFailures;
            BpfAdoxioApplicationid = bpfAdoxioApplicationid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the active stage for the Business
        /// Process Flow instance.
        /// </summary>
        [JsonProperty(PropertyName = "_activestageid_value")]
        public string _activestageidValue { get; set; }

        /// <summary>
        /// Gets or sets comma delimited string of process stage ids that
        /// represent visited stages of the Business Process Flow instance.
        /// </summary>
        [JsonProperty(PropertyName = "traversedpath")]
        public string Traversedpath { get; set; }

        /// <summary>
        /// Gets or sets date and time when the record was created.
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// Gets or sets time zone code that was in use when the record was
        /// created.
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who created the
        /// record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets duration of Business Process Flow
        /// </summary>
        [JsonProperty(PropertyName = "bpf_duration")]
        public int? BpfDuration { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who created the record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who modified the record.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who modified
        /// the record.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets date and time when Business Process Flow instance is
        /// completed.
        /// </summary>
        [JsonProperty(PropertyName = "completedon")]
        public System.DateTimeOffset? Completedon { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the workflow associated to the
        /// Business Process Flow instance.
        /// </summary>
        [JsonProperty(PropertyName = "_processid_value")]
        public string _processidValue { get; set; }

        /// <summary>
        /// Gets or sets date and time when the record was modified.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for entity instances
        /// </summary>
        [JsonProperty(PropertyName = "businessprocessflowinstanceid")]
        public string Businessprocessflowinstanceid { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for the organization
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// Gets or sets date and time when current active stage is started
        /// </summary>
        [JsonProperty(PropertyName = "activestagestartedon")]
        public System.DateTimeOffset? Activestagestartedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_bpf_adoxio_applicationid_value")]
        public string _bpfAdoxioApplicationidValue { get; set; }

        /// <summary>
        /// Gets or sets date and time that the record was migrated.
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// Gets or sets description
        /// </summary>
        [JsonProperty(PropertyName = "bpf_name")]
        public string BpfName { get; set; }

        /// <summary>
        /// Gets or sets reason for the status of the Application: Structure
        /// Change v1
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// Gets or sets sequence number of the import that created this
        /// record.
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// Gets or sets status of the Application: Structure Change v1
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// Gets or sets version Number
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

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
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activestageidname")]
        public MicrosoftDynamicsCRMprocessstage Activestageidname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processidname")]
        public MicrosoftDynamicsCRMworkflow Processidname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_applicationstructurechangev1_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioApplicationstructurechangev1SyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_applicationstructurechangev1_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioApplicationstructurechangev1AsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_applicationstructurechangev1_WorkflowLogs")]
        public IList<MicrosoftDynamicsCRMworkflowlog> AdoxioApplicationstructurechangev1WorkflowLogs { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_applicationstructurechangev1_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioApplicationstructurechangev1BulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bpf_adoxio_applicationid")]
        public MicrosoftDynamicsCRMadoxioApplication BpfAdoxioApplicationid { get; set; }

    }
}
