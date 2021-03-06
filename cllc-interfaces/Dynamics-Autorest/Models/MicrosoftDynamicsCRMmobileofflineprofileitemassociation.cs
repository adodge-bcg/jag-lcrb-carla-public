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
    /// Microsoft.Dynamics.CRM.mobileofflineprofileitemassociation
    /// </summary>
    public partial class MicrosoftDynamicsCRMmobileofflineprofileitemassociation
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmobileofflineprofileitemassociation class.
        /// </summary>
        public MicrosoftDynamicsCRMmobileofflineprofileitemassociation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmobileofflineprofileitemassociation class.
        /// </summary>
        /// <param name="mobileofflineprofileitemassociationidunique">For
        /// Internal Use Only</param>
        /// <param name="_createdbyValue">Shows who created the record.</param>
        /// <param name="createdon">Shows the date and time when the record was
        /// created. The date and time are displayed in the time zone selected
        /// in Microsoft Dynamics 365 options.</param>
        /// <param name="stageid">Shows the ID of the stage.</param>
        /// <param name="isvalidated">Information about whether profile item
        /// association is validated or not</param>
        /// <param name="modifiedon">Shows the date and time when the record
        /// was last updated. The date and time are displayed in the time zone
        /// selected in Microsoft Dynamics 365 options.</param>
        /// <param name="versionnumber">Version number of the Mobile Offline
        /// profileitemassociation.</param>
        /// <param name="relationshipdisplayname">Entity relationship schema
        /// name</param>
        /// <param name="_mobileofflineprofileitemidValue">Id of the parent
        /// profile item.</param>
        /// <param name="relationshipname">Display name of entity
        /// relationship</param>
        /// <param name="_organizationidValue">Unique identifier of the
        /// organization associated with the Mobile Offline Profile Item
        /// Association.</param>
        /// <param name="_createdonbehalfbyValue">Shows who created the record
        /// on behalf of another user.</param>
        /// <param name="relationshipid">Shows the relationship</param>
        /// <param name="relationshipdata">Internal Use Only</param>
        /// <param name="_modifiedonbehalfbyValue">Shows who updated the record
        /// on behalf of another user.</param>
        /// <param name="name">Enter the name of the mobile offline profile
        /// item association.</param>
        /// <param name="mobileofflineprofileitemassociationid">Unique
        /// identifier of the mobile offline profile item associaition.</param>
        /// <param name="introducedversion">Version in which the Mobile offline
        /// Profile Item Association is introduced.</param>
        /// <param name="selectedrelationshipsschema">List of relationships of
        /// entity selected in parent profile item</param>
        /// <param name="_modifiedbyValue">Shows who last updated the
        /// record.</param>
        /// <param name="processid">Shows the ID of the process.</param>
        /// <param name="overwritetime">For internal use only.</param>
        /// <param name="profileitemassociationentityfilter">Profile item
        /// association entity filter criteria.</param>
        /// <param name="componentstate">For internal use only.</param>
        /// <param name="publishedon">Displays the last published date
        /// time.</param>
        /// <param name="traversedpath">For internal use only.</param>
        /// <param name="solutionid">Unique identifier of the associated
        /// solution.</param>
        /// <param name="ismanaged">For internal use only.</param>
        public MicrosoftDynamicsCRMmobileofflineprofileitemassociation(string mobileofflineprofileitemassociationidunique = default(string), string _createdbyValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string stageid = default(string), bool? isvalidated = default(bool?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string versionnumber = default(string), string relationshipdisplayname = default(string), string _mobileofflineprofileitemidValue = default(string), string relationshipname = default(string), string _organizationidValue = default(string), string _createdonbehalfbyValue = default(string), string relationshipid = default(string), string relationshipdata = default(string), string _modifiedonbehalfbyValue = default(string), string name = default(string), string mobileofflineprofileitemassociationid = default(string), string introducedversion = default(string), int? selectedrelationshipsschema = default(int?), string _modifiedbyValue = default(string), string processid = default(string), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), string profileitemassociationentityfilter = default(string), int? componentstate = default(int?), System.DateTimeOffset? publishedon = default(System.DateTimeOffset?), string traversedpath = default(string), string solutionid = default(string), bool? ismanaged = default(bool?), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), MicrosoftDynamicsCRMmobileofflineprofileitem regardingobjectid = default(MicrosoftDynamicsCRMmobileofflineprofileitem), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser))
        {
            Mobileofflineprofileitemassociationidunique = mobileofflineprofileitemassociationidunique;
            this._createdbyValue = _createdbyValue;
            Createdon = createdon;
            Stageid = stageid;
            Isvalidated = isvalidated;
            Modifiedon = modifiedon;
            Versionnumber = versionnumber;
            Relationshipdisplayname = relationshipdisplayname;
            this._mobileofflineprofileitemidValue = _mobileofflineprofileitemidValue;
            Relationshipname = relationshipname;
            this._organizationidValue = _organizationidValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Relationshipid = relationshipid;
            Relationshipdata = relationshipdata;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Name = name;
            Mobileofflineprofileitemassociationid = mobileofflineprofileitemassociationid;
            Introducedversion = introducedversion;
            Selectedrelationshipsschema = selectedrelationshipsschema;
            this._modifiedbyValue = _modifiedbyValue;
            Processid = processid;
            Overwritetime = overwritetime;
            Profileitemassociationentityfilter = profileitemassociationentityfilter;
            Componentstate = componentstate;
            Publishedon = publishedon;
            Traversedpath = traversedpath;
            Solutionid = solutionid;
            Ismanaged = ismanaged;
            Modifiedonbehalfby = modifiedonbehalfby;
            Modifiedby = modifiedby;
            Organizationid = organizationid;
            Regardingobjectid = regardingobjectid;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets for Internal Use Only
        /// </summary>
        [JsonProperty(PropertyName = "mobileofflineprofileitemassociationidunique")]
        public string Mobileofflineprofileitemassociationidunique { get; set; }

        /// <summary>
        /// Gets or sets shows who created the record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// Gets or sets shows the date and time when the record was created.
        /// The date and time are displayed in the time zone selected in
        /// Microsoft Dynamics 365 options.
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// Gets or sets shows the ID of the stage.
        /// </summary>
        [JsonProperty(PropertyName = "stageid")]
        public string Stageid { get; set; }

        /// <summary>
        /// Gets or sets information about whether profile item association is
        /// validated or not
        /// </summary>
        [JsonProperty(PropertyName = "isvalidated")]
        public bool? Isvalidated { get; set; }

        /// <summary>
        /// Gets or sets shows the date and time when the record was last
        /// updated. The date and time are displayed in the time zone selected
        /// in Microsoft Dynamics 365 options.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// Gets or sets version number of the Mobile Offline
        /// profileitemassociation.
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// Gets or sets entity relationship schema name
        /// </summary>
        [JsonProperty(PropertyName = "relationshipdisplayname")]
        public string Relationshipdisplayname { get; set; }

        /// <summary>
        /// Gets or sets id of the parent profile item.
        /// </summary>
        [JsonProperty(PropertyName = "_mobileofflineprofileitemid_value")]
        public string _mobileofflineprofileitemidValue { get; set; }

        /// <summary>
        /// Gets or sets display name of entity relationship
        /// </summary>
        [JsonProperty(PropertyName = "relationshipname")]
        public string Relationshipname { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the organization associated with
        /// the Mobile Offline Profile Item Association.
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// Gets or sets shows who created the record on behalf of another
        /// user.
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets shows the relationship
        /// </summary>
        [JsonProperty(PropertyName = "relationshipid")]
        public string Relationshipid { get; set; }

        /// <summary>
        /// Gets or sets internal Use Only
        /// </summary>
        [JsonProperty(PropertyName = "relationshipdata")]
        public string Relationshipdata { get; set; }

        /// <summary>
        /// Gets or sets shows who updated the record on behalf of another
        /// user.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets enter the name of the mobile offline profile item
        /// association.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the mobile offline profile item
        /// associaition.
        /// </summary>
        [JsonProperty(PropertyName = "mobileofflineprofileitemassociationid")]
        public string Mobileofflineprofileitemassociationid { get; set; }

        /// <summary>
        /// Gets or sets version in which the Mobile offline Profile Item
        /// Association is introduced.
        /// </summary>
        [JsonProperty(PropertyName = "introducedversion")]
        public string Introducedversion { get; set; }

        /// <summary>
        /// Gets or sets list of relationships of entity selected in parent
        /// profile item
        /// </summary>
        [JsonProperty(PropertyName = "selectedrelationshipsschema")]
        public int? Selectedrelationshipsschema { get; set; }

        /// <summary>
        /// Gets or sets shows who last updated the record.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// Gets or sets shows the ID of the process.
        /// </summary>
        [JsonProperty(PropertyName = "processid")]
        public string Processid { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

        /// <summary>
        /// Gets or sets profile item association entity filter criteria.
        /// </summary>
        [JsonProperty(PropertyName = "profileitemassociationentityfilter")]
        public string Profileitemassociationentityfilter { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// Gets or sets displays the last published date time.
        /// </summary>
        [JsonProperty(PropertyName = "publishedon")]
        public System.DateTimeOffset? Publishedon { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "traversedpath")]
        public string Traversedpath { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the associated solution.
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public string Solutionid { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid")]
        public MicrosoftDynamicsCRMmobileofflineprofileitem Regardingobjectid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

    }
}
