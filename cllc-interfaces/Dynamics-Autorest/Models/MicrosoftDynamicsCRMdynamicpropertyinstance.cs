// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.dynamicpropertyinstance
    /// </summary>
    public partial class MicrosoftDynamicsCRMdynamicpropertyinstance
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMdynamicpropertyinstance class.
        /// </summary>
        public MicrosoftDynamicsCRMdynamicpropertyinstance()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMdynamicpropertyinstance class.
        /// </summary>
        /// <param name="versionnumber">Shows the version number of the
        /// property instance.</param>
        /// <param name="modifiedon">Shows the date and time when the record
        /// was last updated.</param>
        /// <param name="valuedouble">Shows the double value of the
        /// property.</param>
        /// <param name="valuedecimal">Shows the decimal value of the
        /// property.</param>
        /// <param name="_modifiedonbehalfbyValue">Shows who created the record
        /// on behalf of another user.</param>
        /// <param name="valuestring">Shows the string value of the
        /// property.</param>
        /// <param name="_createdonbehalfbyValue">Shows who created the record
        /// on behalf of another user.</param>
        /// <param name="dmtimportstate">Internal Use Only</param>
        /// <param name="_modifiedbyValue">Shows who last updated the
        /// record.</param>
        /// <param name="_createdbyValue">Shows who created the record.</param>
        /// <param name="validationstatus">Shows whether the property value is
        /// valid.</param>
        /// <param name="_dynamicpropertyidValue">Shows the property that this
        /// record is associated with.</param>
        /// <param name="_transactioncurrencyidValue">Shows the currency
        /// associated with the record.</param>
        /// <param name="createdon">Shows the date and time when the record was
        /// created.</param>
        /// <param name="_regardingobjectidValue">Shows the object that the
        /// property is associated with.</param>
        /// <param name="_owningbusinessunitValue">Shows the business unit that
        /// the record owner belongs to.</param>
        /// <param name="_owneridValue">Enter the user or team who is assigned
        /// to manage the record. This field is updated every time the record
        /// is assigned to a different user.</param>
        /// <param name="_owninguserValue">Shows the user who owns the property
        /// instance.</param>
        /// <param name="exchangerate">Shows the conversion rate of the
        /// record's currency. The exchange rate is used to convert all money
        /// fields in the record from the local currency to the system's
        /// default currency.</param>
        /// <param name="valueinteger">Shows the integer value of the
        /// property.</param>
        /// <param name="dynamicpropertyinstanceid">Shows the unique identifier
        /// of the property instance.</param>
        /// <param name="_owningteamValue">Shows the team who owns the property
        /// instance.</param>
        public MicrosoftDynamicsCRMdynamicpropertyinstance(string versionnumber = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), decimal? valuedouble = default(decimal?), decimal? valuedecimal = default(decimal?), string _modifiedonbehalfbyValue = default(string), string valuestring = default(string), string _createdonbehalfbyValue = default(string), int? dmtimportstate = default(int?), string _modifiedbyValue = default(string), string _createdbyValue = default(string), bool? validationstatus = default(bool?), string _dynamicpropertyidValue = default(string), string _transactioncurrencyidValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _regardingobjectidValue = default(string), string _owningbusinessunitValue = default(string), string _owneridValue = default(string), string _owninguserValue = default(string), decimal? exchangerate = default(decimal?), int? valueinteger = default(int?), string dynamicpropertyinstanceid = default(string), string _owningteamValue = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMdynamicproperty dynamicpropertyid = default(MicrosoftDynamicsCRMdynamicproperty), MicrosoftDynamicsCRMquotedetail regardingobjectidQuotedetail = default(MicrosoftDynamicsCRMquotedetail), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMinvoicedetail regardingobjectidInvoicedetail = default(MicrosoftDynamicsCRMinvoicedetail), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMopportunityproduct regardingobjectidOpportunityproduct = default(MicrosoftDynamicsCRMopportunityproduct), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsalesorderdetail regardingobjectidSalesorderdetail = default(MicrosoftDynamicsCRMsalesorderdetail), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser))
        {
            Versionnumber = versionnumber;
            Modifiedon = modifiedon;
            Valuedouble = valuedouble;
            Valuedecimal = valuedecimal;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Valuestring = valuestring;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Dmtimportstate = dmtimportstate;
            this._modifiedbyValue = _modifiedbyValue;
            this._createdbyValue = _createdbyValue;
            Validationstatus = validationstatus;
            this._dynamicpropertyidValue = _dynamicpropertyidValue;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Createdon = createdon;
            this._regardingobjectidValue = _regardingobjectidValue;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._owneridValue = _owneridValue;
            this._owninguserValue = _owninguserValue;
            Exchangerate = exchangerate;
            Valueinteger = valueinteger;
            Dynamicpropertyinstanceid = dynamicpropertyinstanceid;
            this._owningteamValue = _owningteamValue;
            Createdby = createdby;
            Dynamicpropertyid = dynamicpropertyid;
            RegardingobjectidQuotedetail = regardingobjectidQuotedetail;
            Modifiedby = modifiedby;
            Owningbusinessunit = owningbusinessunit;
            RegardingobjectidInvoicedetail = regardingobjectidInvoicedetail;
            Ownerid = ownerid;
            Owningteam = owningteam;
            RegardingobjectidOpportunityproduct = regardingobjectidOpportunityproduct;
            Createdonbehalfby = createdonbehalfby;
            RegardingobjectidSalesorderdetail = regardingobjectidSalesorderdetail;
            Owninguser = owninguser;
            Transactioncurrencyid = transactioncurrencyid;
            Modifiedonbehalfby = modifiedonbehalfby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets shows the version number of the property instance.
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// Gets or sets shows the date and time when the record was last
        /// updated.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// Gets or sets shows the double value of the property.
        /// </summary>
        [JsonProperty(PropertyName = "valuedouble")]
        public decimal? Valuedouble { get; set; }

        /// <summary>
        /// Gets or sets shows the decimal value of the property.
        /// </summary>
        [JsonProperty(PropertyName = "valuedecimal")]
        public decimal? Valuedecimal { get; set; }

        /// <summary>
        /// Gets or sets shows who created the record on behalf of another
        /// user.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets shows the string value of the property.
        /// </summary>
        [JsonProperty(PropertyName = "valuestring")]
        public string Valuestring { get; set; }

        /// <summary>
        /// Gets or sets shows who created the record on behalf of another
        /// user.
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets internal Use Only
        /// </summary>
        [JsonProperty(PropertyName = "dmtimportstate")]
        public int? Dmtimportstate { get; set; }

        /// <summary>
        /// Gets or sets shows who last updated the record.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// Gets or sets shows who created the record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// Gets or sets shows whether the property value is valid.
        /// </summary>
        [JsonProperty(PropertyName = "validationstatus")]
        public bool? Validationstatus { get; set; }

        /// <summary>
        /// Gets or sets shows the property that this record is associated
        /// with.
        /// </summary>
        [JsonProperty(PropertyName = "_dynamicpropertyid_value")]
        public string _dynamicpropertyidValue { get; set; }

        /// <summary>
        /// Gets or sets shows the currency associated with the record.
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// Gets or sets shows the date and time when the record was created.
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// Gets or sets shows the object that the property is associated with.
        /// </summary>
        [JsonProperty(PropertyName = "_regardingobjectid_value")]
        public string _regardingobjectidValue { get; set; }

        /// <summary>
        /// Gets or sets shows the business unit that the record owner belongs
        /// to.
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// Gets or sets enter the user or team who is assigned to manage the
        /// record. This field is updated every time the record is assigned to
        /// a different user.
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// Gets or sets shows the user who owns the property instance.
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// Gets or sets shows the conversion rate of the record's currency.
        /// The exchange rate is used to convert all money fields in the record
        /// from the local currency to the system's default currency.
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// Gets or sets shows the integer value of the property.
        /// </summary>
        [JsonProperty(PropertyName = "valueinteger")]
        public int? Valueinteger { get; set; }

        /// <summary>
        /// Gets or sets shows the unique identifier of the property instance.
        /// </summary>
        [JsonProperty(PropertyName = "dynamicpropertyinstanceid")]
        public string Dynamicpropertyinstanceid { get; set; }

        /// <summary>
        /// Gets or sets shows the team who owns the property instance.
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dynamicpropertyid")]
        public MicrosoftDynamicsCRMdynamicproperty Dynamicpropertyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_quotedetail")]
        public MicrosoftDynamicsCRMquotedetail RegardingobjectidQuotedetail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_invoicedetail")]
        public MicrosoftDynamicsCRMinvoicedetail RegardingobjectidInvoicedetail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_opportunityproduct")]
        public MicrosoftDynamicsCRMopportunityproduct RegardingobjectidOpportunityproduct { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_salesorderdetail")]
        public MicrosoftDynamicsCRMsalesorderdetail RegardingobjectidSalesorderdetail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

    }
}
