using System;
using System.Xml.Serialization;
using System.Data;
using System.Globalization;
using System.Xml;
using System.Runtime.Serialization;
using WoWHeadXMLExtractor.BusinessLogic;


namespace WoWHeadXMLExtractor.Framework.Core
{
    [Serializable()]
    public abstract class WoWHeadXMLObjectService : WoWHeadXMLObject
    {
        #region Properties

        private static WoWHeadXMLObjectService _Service;

        public static WoWHeadXMLObjectService Provider
        {
            get
            {
                if (_Service == null)
                {
                    //_Service = new WoWHeadXMLObjectService();
                }
                return _Service;
            }
        }

        #endregion

        public WoWHeadXMLObjectService()
        {

        }

        public new virtual object Clone()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public void SetBaseProperty(XmlTextReader reader)
        {
            /*switch (reader.Name.ToUpper(CultureInfo.CurrentCulture))
            {
                case "ID":
                    this.Id = reader.IsEmptyElement ? -1 : Convert.ToInt32(reader.Value);
                    break;
            }*/
        }

        /*protected virtual ObjectType CreateObject(XmlDocument rawXML)
        {
            return null;
        }*/
    }
}
