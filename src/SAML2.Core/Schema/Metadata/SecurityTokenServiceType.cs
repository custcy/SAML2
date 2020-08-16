using System;
using System.Xml;
using System.Xml.Serialization;

namespace SAML2.Schema.Metadata
{
    /// <summary>
    /// The <c>&lt;SecurityTokenServiceType&gt;</c> element extends RoleDescriptorType.
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://docs.oasis-open.org/wsfed/federation/200706")]
    [XmlRoot(ElementName, Namespace = Saml20Constants.Metadata, IsNullable = false)]
    public class SecurityTokenServiceType : RoleDescriptor
    {
        /// <summary>
        /// The XML Element name of this class
        /// </summary>
        public new const string ElementName = "RoleDescriptor";

        #region Elements

        /// <summary>
        /// Gets or sets XML any element.
        /// </summary>
        /// <value>The XML Any element.</value>
        [XmlAnyElement(Order = 1)]
        public XmlElement[] AnyEle { get; set; }

        #endregion
    }
}
