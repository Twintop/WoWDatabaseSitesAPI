using System;
using System.Xml.Serialization;
using System.Data;
using System.Globalization;
using System.Xml;
using System.Runtime.Serialization;
using WoWDatabaseSitesAPI.BusinessLogic;


namespace WoWDatabaseSitesAPI.Framework.Core
{
    [Serializable()]
    public abstract class WowheadXMLObjectService : WowheadXMLObject
    {
        #region Properties

        private static WowheadXMLObjectService _Service;

        public static WowheadXMLObjectService Provider
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

        public WowheadXMLObjectService()
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
