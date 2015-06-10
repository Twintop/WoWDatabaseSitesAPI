using System;
using System.Xml.Serialization;
using System.Data;
using System.Globalization;
using System.Runtime.Serialization;
using System.Xml;
using WoWHeadXMLExtractor.BusinessLogic;

namespace WoWHeadXMLExtractor.Framework.Core
{
    [Serializable()]
    public abstract class WHXEObject : ICloneable
    {
        #region Properties
        public int Id { get; set; }
        public XmlDocument RawXML { get; set; }
        public WoWHeadXMLItem WoWHeadXML { get; set; }
        public WoWHeadSiteType SiteType { get; set; }
        #endregion

        public WHXEObject()
        {

        }

        public new virtual object Clone()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public void SetBaseProperty(XmlTextReader reader)
        {
            switch (reader.Name.ToUpper(CultureInfo.CurrentCulture))
            {
                case "ID":
                    this.Id = reader.IsEmptyElement ? -1 : Convert.ToInt32(reader.Value);
                    break;
            }
        }
    }

    public enum WoWHeadSiteType
    {
        Live = 1
        ,PTR = 2
        ,Beta = 3
    };
}
