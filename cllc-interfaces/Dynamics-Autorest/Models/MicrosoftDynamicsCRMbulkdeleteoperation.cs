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
    /// Microsoft.Dynamics.CRM.bulkdeleteoperation
    /// </summary>
    public partial class MicrosoftDynamicsCRMbulkdeleteoperation
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMbulkdeleteoperation class.
        /// </summary>
        public MicrosoftDynamicsCRMbulkdeleteoperation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMbulkdeleteoperation class.
        /// </summary>
        /// <param name="successcount">Number of records deleted by the bulk
        /// deletion job.</param>
        /// <param name="_createdbyValue">Unique identifier of the user who
        /// created the bulk deletion job.</param>
        /// <param name="_modifiedbyValue">Unique identifier of the user who
        /// last modified the bulk deletion job.</param>
        /// <param name="_owningbusinessunitValue">Business unit that owns the
        /// bulk deletion job.</param>
        /// <param name="statuscode">Reason for the status of the bulk deletion
        /// job.</param>
        /// <param name="isrecurring">Information about if recurrence is
        /// defined for the bulk deletion job.</param>
        /// <param name="createdon">Date and time when the bulk deletion job
        /// was created.</param>
        /// <param name="processingqeindex">Index of the ordered query
        /// expression that defines the deletion set.</param>
        /// <param name="failurecount">Number of records that could not be
        /// deleted by the bulk deletion job.</param>
        /// <param name="nextrun">Next scheduled time for the bulk deletion job
        /// to run.</param>
        /// <param name="_owninguserValue">Business user what owns the bulk
        /// delete operation.</param>
        /// <param name="orderedquerysetxml">Fetch XML of the ordered query
        /// set.</param>
        /// <param name="_owneridValue">Unique identifier of the user or team
        /// who owns the bulk delete operation.</param>
        /// <param name="timezoneruleversionnumber">For internal use
        /// only.</param>
        /// <param name="modifiedon">Date and time when the bulk deletion job
        /// record was last modified.</param>
        /// <param name="utcconversiontimezonecode">Time zone code that was in
        /// use when the record was created.</param>
        /// <param name="name">Name of the bulk deletion job.</param>
        /// <param name="bulkdeleteoperationid">Unique identifier of the bulk
        /// deletion job.</param>
        /// <param name="_asyncoperationidValue">Unique identifier of the
        /// system job that created this record</param>
        /// <param name="_modifiedonbehalfbyValue">Unique identifier of the
        /// delegate user who last modified the bulkdeleteoperation.</param>
        /// <param name="statecode">Status of the bulk deletion job.</param>
        /// <param name="_createdonbehalfbyValue">Unique identifier of the
        /// delegate user who created the bulkdeleteoperation.</param>
        public MicrosoftDynamicsCRMbulkdeleteoperation(int? successcount = default(int?), string _createdbyValue = default(string), string _modifiedbyValue = default(string), string _owningbusinessunitValue = default(string), int? statuscode = default(int?), bool? isrecurring = default(bool?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), int? processingqeindex = default(int?), int? failurecount = default(int?), System.DateTimeOffset? nextrun = default(System.DateTimeOffset?), string _owninguserValue = default(string), string orderedquerysetxml = default(string), string _owneridValue = default(string), int? timezoneruleversionnumber = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? utcconversiontimezonecode = default(int?), string name = default(string), string bulkdeleteoperationid = default(string), string _asyncoperationidValue = default(string), string _modifiedonbehalfbyValue = default(string), int? statecode = default(int?), string _createdonbehalfbyValue = default(string), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMasyncoperation asyncoperationid = default(MicrosoftDynamicsCRMasyncoperation), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMbulkdeletefailure> bulkDeleteOperationBulkDeleteFailure = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser))
        {
            Successcount = successcount;
            this._createdbyValue = _createdbyValue;
            this._modifiedbyValue = _modifiedbyValue;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Statuscode = statuscode;
            Isrecurring = isrecurring;
            Createdon = createdon;
            Processingqeindex = processingqeindex;
            Failurecount = failurecount;
            Nextrun = nextrun;
            this._owninguserValue = _owninguserValue;
            Orderedquerysetxml = orderedquerysetxml;
            this._owneridValue = _owneridValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Modifiedon = modifiedon;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Name = name;
            Bulkdeleteoperationid = bulkdeleteoperationid;
            this._asyncoperationidValue = _asyncoperationidValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Statecode = statecode;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Owningbusinessunit = owningbusinessunit;
            Asyncoperationid = asyncoperationid;
            Modifiedby = modifiedby;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            BulkDeleteOperationBulkDeleteFailure = bulkDeleteOperationBulkDeleteFailure;
            Modifiedonbehalfby = modifiedonbehalfby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets number of records deleted by the bulk deletion job.
        /// </summary>
        [JsonProperty(PropertyName = "successcount")]
        public int? Successcount { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who created the bulk
        /// deletion job.
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who last modified the
        /// bulk deletion job.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// Gets or sets business unit that owns the bulk deletion job.
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// Gets or sets reason for the status of the bulk deletion job.
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// Gets or sets information about if recurrence is defined for the
        /// bulk deletion job.
        /// </summary>
        [JsonProperty(PropertyName = "isrecurring")]
        public bool? Isrecurring { get; set; }

        /// <summary>
        /// Gets or sets date and time when the bulk deletion job was created.
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// Gets or sets index of the ordered query expression that defines the
        /// deletion set.
        /// </summary>
        [JsonProperty(PropertyName = "processingqeindex")]
        public int? Processingqeindex { get; set; }

        /// <summary>
        /// Gets or sets number of records that could not be deleted by the
        /// bulk deletion job.
        /// </summary>
        [JsonProperty(PropertyName = "failurecount")]
        public int? Failurecount { get; set; }

        /// <summary>
        /// Gets or sets next scheduled time for the bulk deletion job to run.
        /// </summary>
        [JsonProperty(PropertyName = "nextrun")]
        public System.DateTimeOffset? Nextrun { get; set; }

        /// <summary>
        /// Gets or sets business user what owns the bulk delete operation.
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// Gets or sets fetch XML of the ordered query set.
        /// </summary>
        [JsonProperty(PropertyName = "orderedquerysetxml")]
        public string Orderedquerysetxml { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user or team who owns the
        /// bulk delete operation.
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// Gets or sets date and time when the bulk deletion job record was
        /// last modified.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// Gets or sets time zone code that was in use when the record was
        /// created.
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// Gets or sets name of the bulk deletion job.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the bulk deletion job.
        /// </summary>
        [JsonProperty(PropertyName = "bulkdeleteoperationid")]
        public string Bulkdeleteoperationid { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the system job that created this
        /// record
        /// </summary>
        [JsonProperty(PropertyName = "_asyncoperationid_value")]
        public string _asyncoperationidValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who last
        /// modified the bulkdeleteoperation.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets status of the bulk deletion job.
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who created the
        /// bulkdeleteoperation.
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "asyncoperationid")]
        public MicrosoftDynamicsCRMasyncoperation Asyncoperationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BulkDeleteOperation_BulkDeleteFailure")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> BulkDeleteOperationBulkDeleteFailure { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

    }
}
