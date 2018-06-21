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

    public partial class MicrosoftDynamicsCRMrole
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMrole class.
        /// </summary>
        public MicrosoftDynamicsCRMrole()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMrole class.
        /// </summary>
        public MicrosoftDynamicsCRMrole(IList<MicrosoftDynamicsCRMasyncoperation> roleAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> roleBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMsyncerror> roleSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), string _businessunitidValue = default(string), string _createdbyValue = default(string), string _createdonbehalfbyValue = default(string), string _modifiedbyValue = default(string), string _modifiedonbehalfbyValue = default(string), string _parentroleidValue = default(string), string _parentrootroleidValue = default(string), string _roletemplateidValue = default(string), MicrosoftDynamicsCRMbusinessunit businessunitid = default(MicrosoftDynamicsCRMbusinessunit), int? componentstate = default(int?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), int? importsequencenumber = default(int?), MicrosoftDynamicsCRMBooleanManagedProperty iscustomizable = default(MicrosoftDynamicsCRMBooleanManagedProperty), bool? ismanaged = default(bool?), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), string name = default(string), string organizationid = default(string), MicrosoftDynamicsCRMorganization organizationidOrganization = default(MicrosoftDynamicsCRMorganization), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), MicrosoftDynamicsCRMrole parentroleid = default(MicrosoftDynamicsCRMrole), MicrosoftDynamicsCRMrole parentrootroleid = default(MicrosoftDynamicsCRMrole), IList<MicrosoftDynamicsCRMrole> roleParentRole = default(IList<MicrosoftDynamicsCRMrole>), IList<MicrosoftDynamicsCRMrole> roleParentRootRole = default(IList<MicrosoftDynamicsCRMrole>), string roleid = default(string), string roleidunique = default(string), IList<MicrosoftDynamicsCRMprivilege> roleprivilegesAssociation = default(IList<MicrosoftDynamicsCRMprivilege>), MicrosoftDynamicsCRMroletemplate roletemplateid = default(MicrosoftDynamicsCRMroletemplate), string solutionid = default(string), IList<MicrosoftDynamicsCRMsystemuser> systemuserrolesAssociation = default(IList<MicrosoftDynamicsCRMsystemuser>), IList<MicrosoftDynamicsCRMteam> teamrolesAssociation = default(IList<MicrosoftDynamicsCRMteam>), object versionnumber = default(object))
        {
            RoleAsyncOperations = roleAsyncOperations;
            RoleBulkDeleteFailures = roleBulkDeleteFailures;
            RoleSyncErrors = roleSyncErrors;
            this._businessunitidValue = _businessunitidValue;
            this._createdbyValue = _createdbyValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._modifiedbyValue = _modifiedbyValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._parentroleidValue = _parentroleidValue;
            this._parentrootroleidValue = _parentrootroleidValue;
            this._roletemplateidValue = _roletemplateidValue;
            Businessunitid = businessunitid;
            Componentstate = componentstate;
            Createdby = createdby;
            Createdon = createdon;
            Createdonbehalfby = createdonbehalfby;
            Importsequencenumber = importsequencenumber;
            Iscustomizable = iscustomizable;
            Ismanaged = ismanaged;
            Modifiedby = modifiedby;
            Modifiedon = modifiedon;
            Modifiedonbehalfby = modifiedonbehalfby;
            Name = name;
            Organizationid = organizationid;
            OrganizationidOrganization = organizationidOrganization;
            Overriddencreatedon = overriddencreatedon;
            Overwritetime = overwritetime;
            Parentroleid = parentroleid;
            Parentrootroleid = parentrootroleid;
            RoleParentRole = roleParentRole;
            RoleParentRootRole = roleParentRootRole;
            Roleid = roleid;
            Roleidunique = roleidunique;
            RoleprivilegesAssociation = roleprivilegesAssociation;
            Roletemplateid = roletemplateid;
            Solutionid = solutionid;
            SystemuserrolesAssociation = systemuserrolesAssociation;
            TeamrolesAssociation = teamrolesAssociation;
            Versionnumber = versionnumber;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Role_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> RoleAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Role_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> RoleBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Role_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> RoleSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_businessunitid_value")]
        public string _businessunitidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_parentroleid_value")]
        public string _parentroleidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_parentrootroleid_value")]
        public string _parentrootroleidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_roletemplateid_value")]
        public string _roletemplateidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "businessunitid")]
        public MicrosoftDynamicsCRMbusinessunit Businessunitid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "iscustomizable")]
        public MicrosoftDynamicsCRMBooleanManagedProperty Iscustomizable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public string Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid_organization")]
        public MicrosoftDynamicsCRMorganization OrganizationidOrganization { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parentroleid")]
        public MicrosoftDynamicsCRMrole Parentroleid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parentrootroleid")]
        public MicrosoftDynamicsCRMrole Parentrootroleid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "role_parent_role")]
        public IList<MicrosoftDynamicsCRMrole> RoleParentRole { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "role_parent_root_role")]
        public IList<MicrosoftDynamicsCRMrole> RoleParentRootRole { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "roleid")]
        public string Roleid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "roleidunique")]
        public string Roleidunique { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "roleprivileges_association")]
        public IList<MicrosoftDynamicsCRMprivilege> RoleprivilegesAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "roletemplateid")]
        public MicrosoftDynamicsCRMroletemplate Roletemplateid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public string Solutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "systemuserroles_association")]
        public IList<MicrosoftDynamicsCRMsystemuser> SystemuserrolesAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "teamroles_association")]
        public IList<MicrosoftDynamicsCRMteam> TeamrolesAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public object Versionnumber { get; set; }

    }
}