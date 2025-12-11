using System;
using System.Collections.Generic;
using System.Text;

namespace azds2ssmsxml.destination
{
    internal class RegisteredServers
    {
        public RegisteredServers() { }
        public bufferData? bufferData { get; set; }
    }

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/sqlserver/RegisteredServers/2007/08")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/RegisteredServers/2007/08", IsNullable = false)]
    public partial class bufferData
    {

        private instancesDocument[] instancesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Namespace = "")]
        [System.Xml.Serialization.XmlArrayItemAttribute("document", IsNullable = false)]
        public instancesDocument[] instances
        {
            get
            {
                return this.instancesField;
            }
            set
            {
                this.instancesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class instancesDocument
    {

        private instancesDocumentDocinfo docinfoField;

        private instancesDocumentData dataField;

        /// <remarks/>
        public instancesDocumentDocinfo docinfo
        {
            get
            {
                return this.docinfoField;
            }
            set
            {
                this.docinfoField = value;
            }
        }

        /// <remarks/>
        public instancesDocumentData data
        {
            get
            {
                return this.dataField;
            }
            set
            {
                this.dataField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class instancesDocumentDocinfo
    {

        private instancesDocumentDocinfoAliases aliasesField;

        private version versionField;

        /// <remarks/>
        public instancesDocumentDocinfoAliases aliases
        {
            get
            {
                return this.aliasesField;
            }
            set
            {
                this.aliasesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/sfc/serialization/2007/08")]
        public version version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class instancesDocumentDocinfoAliases
    {

        private string aliasField;

        /// <remarks/>
        public string alias
        {
            get
            {
                return this.aliasField;
            }
            set
            {
                this.aliasField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/sqlserver/sfc/serialization/2007/08")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/sfc/serialization/2007/08", IsNullable = false)]
    public partial class version
    {

        private byte domainVersionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte DomainVersion
        {
            get
            {
                return this.domainVersionField;
            }
            set
            {
                this.domainVersionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class instancesDocumentData
    {

        private RegisteredServer registeredServerField;

        private ServerGroup serverGroupField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/RegisteredServers/2007/08")]
        public RegisteredServer RegisteredServer
        {
            get
            {
                return this.registeredServerField;
            }
            set
            {
                this.registeredServerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/RegisteredServers/2007/08")]
        public ServerGroup ServerGroup
        {
            get
            {
                return this.serverGroupField;
            }
            set
            {
                this.serverGroupField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/sqlserver/RegisteredServers/2007/08")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/RegisteredServers/2007/08", IsNullable = false)]
    public partial class RegisteredServer
    {

        private RegisteredServerParent parentField;

        private RegisteredServerName nameField;

        private RegisteredServerDescription descriptionField;

        private RegisteredServerServerName serverNameField;

        private RegisteredServerUseCustomConnectionColor useCustomConnectionColorField;

        private RegisteredServerCustomConnectionColorArgb customConnectionColorArgbField;

        private RegisteredServerServerType serverTypeField;

        private RegisteredServerConnectionStringWithEncryptedPassword connectionStringWithEncryptedPasswordField;

        private RegisteredServerCredentialPersistenceType credentialPersistenceTypeField;

        private RegisteredServerOtherParams otherParamsField;

        private RegisteredServerAuthenticationType authenticationTypeField;

        private RegisteredServerActiveDirectoryTenant activeDirectoryTenantField;

        /// <remarks/>
        public RegisteredServerParent Parent
        {
            get
            {
                return this.parentField;
            }
            set
            {
                this.parentField = value;
            }
        }

        /// <remarks/>
        public RegisteredServerName Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public RegisteredServerDescription Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public RegisteredServerServerName ServerName
        {
            get
            {
                return this.serverNameField;
            }
            set
            {
                this.serverNameField = value;
            }
        }

        /// <remarks/>
        public RegisteredServerUseCustomConnectionColor UseCustomConnectionColor
        {
            get
            {
                return this.useCustomConnectionColorField;
            }
            set
            {
                this.useCustomConnectionColorField = value;
            }
        }

        /// <remarks/>
        public RegisteredServerCustomConnectionColorArgb CustomConnectionColorArgb
        {
            get
            {
                return this.customConnectionColorArgbField;
            }
            set
            {
                this.customConnectionColorArgbField = value;
            }
        }

        /// <remarks/>
        public RegisteredServerServerType ServerType
        {
            get
            {
                return this.serverTypeField;
            }
            set
            {
                this.serverTypeField = value;
            }
        }

        /// <remarks/>
        public RegisteredServerConnectionStringWithEncryptedPassword ConnectionStringWithEncryptedPassword
        {
            get
            {
                return this.connectionStringWithEncryptedPasswordField;
            }
            set
            {
                this.connectionStringWithEncryptedPasswordField = value;
            }
        }

        /// <remarks/>
        public RegisteredServerCredentialPersistenceType CredentialPersistenceType
        {
            get
            {
                return this.credentialPersistenceTypeField;
            }
            set
            {
                this.credentialPersistenceTypeField = value;
            }
        }

        /// <remarks/>
        public RegisteredServerOtherParams OtherParams
        {
            get
            {
                return this.otherParamsField;
            }
            set
            {
                this.otherParamsField = value;
            }
        }

        /// <remarks/>
        public RegisteredServerAuthenticationType AuthenticationType
        {
            get
            {
                return this.authenticationTypeField;
            }
            set
            {
                this.authenticationTypeField = value;
            }
        }

        /// <remarks/>
        public RegisteredServerActiveDirectoryTenant ActiveDirectoryTenant
        {
            get
            {
                return this.activeDirectoryTenantField;
            }
            set
            {
                this.activeDirectoryTenantField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/sqlserver/RegisteredServers/2007/08")]
    public partial class RegisteredServerParent
    {

        private Reference referenceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/sfc/serialization/2007/08")]
        public Reference Reference
        {
            get
            {
                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/sqlserver/sfc/serialization/2007/08")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/sfc/serialization/2007/08", IsNullable = false)]
    public partial class Reference
    {

        private string uriField;

        private bool refField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.serviceml.org/sml/2007/02")]
        public string Uri
        {
            get
            {
                return this.uriField;
            }
            set
            {
                this.uriField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.serviceml.org/sml/2007/02")]
        public bool @ref
        {
            get
            {
                return this.refField;
            }
            set
            {
                this.refField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/sqlserver/RegisteredServers/2007/08")]
    public partial class RegisteredServerName
    {

        private string typeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/sqlserver/RegisteredServers/2007/08")]
    public partial class RegisteredServerDescription
    {

        private string typeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/sqlserver/RegisteredServers/2007/08")]
    public partial class RegisteredServerServerName
    {

        private string typeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/sqlserver/RegisteredServers/2007/08")]
    public partial class RegisteredServerUseCustomConnectionColor
    {

        private string typeField;

        private bool valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public bool Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/sqlserver/RegisteredServers/2007/08")]
    public partial class RegisteredServerCustomConnectionColorArgb
    {

        private string typeField;

        private int valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public int Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/sqlserver/RegisteredServers/2007/08")]
    public partial class RegisteredServerServerType
    {

        private string typeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/sqlserver/RegisteredServers/2007/08")]
    public partial class RegisteredServerConnectionStringWithEncryptedPassword
    {

        private string typeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/sqlserver/RegisteredServers/2007/08")]
    public partial class RegisteredServerCredentialPersistenceType
    {

        private string typeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/sqlserver/RegisteredServers/2007/08")]
    public partial class RegisteredServerOtherParams
    {

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/sqlserver/RegisteredServers/2007/08")]
    public partial class RegisteredServerAuthenticationType
    {

        private string typeField;

        private byte valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public byte Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/sqlserver/RegisteredServers/2007/08")]
    public partial class RegisteredServerActiveDirectoryTenant
    {

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/sqlserver/RegisteredServers/2007/08")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/RegisteredServers/2007/08", IsNullable = false)]
    public partial class ServerGroup
    {

        private ServerGroupRegisteredServers registeredServersField;

        private ServerGroupServerGroups serverGroupsField;

        private ServerGroupParent parentField;

        private ServerGroupName nameField;

        private ServerGroupDescription descriptionField;

        private ServerGroupServerType serverTypeField;

        /// <remarks/>
        public ServerGroupRegisteredServers RegisteredServers
        {
            get
            {
                return this.registeredServersField;
            }
            set
            {
                this.registeredServersField = value;
            }
        }

        /// <remarks/>
        public ServerGroupServerGroups ServerGroups
        {
            get
            {
                return this.serverGroupsField;
            }
            set
            {
                this.serverGroupsField = value;
            }
        }

        /// <remarks/>
        public ServerGroupParent Parent
        {
            get
            {
                return this.parentField;
            }
            set
            {
                this.parentField = value;
            }
        }

        /// <remarks/>
        public ServerGroupName Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public ServerGroupDescription Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public ServerGroupServerType ServerType
        {
            get
            {
                return this.serverTypeField;
            }
            set
            {
                this.serverTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/sqlserver/RegisteredServers/2007/08")]
    public partial class ServerGroupRegisteredServers
    {

        private CollectionReference[] collectionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/sfc/serialization/2007/08")]
        [System.Xml.Serialization.XmlArrayItemAttribute("Reference", IsNullable = false)]
        public CollectionReference[] Collection
        {
            get
            {
                return this.collectionField;
            }
            set
            {
                this.collectionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/sqlserver/sfc/serialization/2007/08")]
    public partial class CollectionReference
    {

        private string uriField;

        private bool refField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.serviceml.org/sml/2007/02")]
        public string Uri
        {
            get
            {
                return this.uriField;
            }
            set
            {
                this.uriField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.serviceml.org/sml/2007/02")]
        public bool @ref
        {
            get
            {
                return this.refField;
            }
            set
            {
                this.refField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/sqlserver/RegisteredServers/2007/08")]
    public partial class ServerGroupServerGroups
    {

        private CollectionReference[] collectionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/sfc/serialization/2007/08")]
        [System.Xml.Serialization.XmlArrayItemAttribute("Reference", IsNullable = false)]
        public CollectionReference[] Collection
        {
            get
            {
                return this.collectionField;
            }
            set
            {
                this.collectionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/sqlserver/RegisteredServers/2007/08")]
    public partial class ServerGroupParent
    {

        private Reference referenceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/sfc/serialization/2007/08")]
        public Reference Reference
        {
            get
            {
                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/sqlserver/RegisteredServers/2007/08")]
    public partial class ServerGroupName
    {

        private string typeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/sqlserver/RegisteredServers/2007/08")]
    public partial class ServerGroupDescription
    {

        private string typeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/sqlserver/RegisteredServers/2007/08")]
    public partial class ServerGroupServerType
    {

        private string typeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class instances
    {

        private instancesDocument[] documentField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("document")]
        public instancesDocument[] document
        {
            get
            {
                return this.documentField;
            }
            set
            {
                this.documentField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/sqlserver/sfc/serialization/2007/08")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/sfc/serialization/2007/08", IsNullable = false)]
    public partial class Collection
    {

        private CollectionReference[] referenceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Reference")]
        public CollectionReference[] Reference
        {
            get
            {
                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
            }
        }
    }


}
