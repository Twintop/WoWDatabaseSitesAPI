using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using WoWDatabaseSitesAPI.Framework;
using WoWDatabaseSitesAPI.Framework.Core;

namespace WoWDatabaseSitesAPI.BusinessLogic
{
    public static class WowheadXML
    {
        public static XmlDocument GetWoWHeadXML(int id, string bonuses = "", WowheadSiteType sitetype = WowheadSiteType.Live)
        {
            XmlDocument wowheadXML = new XmlDocument();

            string objectURL = "http://";

            switch (sitetype)
            {
                case WowheadSiteType.Live:
                default:
                    objectURL += "www";
                    break;
                case WowheadSiteType.PTR:
                    objectURL += "ptr";
                    break;
                case WowheadSiteType.Beta:
                    objectURL += "beta";
                    break;
                case WowheadSiteType.Legion:
                    objectURL += "legion";
                    break;
            }

            objectURL += ".wowhead.com/";
            objectURL += "item=" + id;

            if (!String.IsNullOrWhiteSpace(bonuses))
            {
                objectURL += "&bonus=" + bonuses;
            }

            objectURL += "&xml";

            wowheadXML.Load(objectURL);
            return wowheadXML;
        }

        public static Item ParseItemXML(XmlDocument rawXML, int ParseSource = 2)
        {
            WowheadXMLItem xmlItem = new WowheadXMLItem();

            xmlItem = WowheadXMLManager.Provider.GetXMLItem(rawXML, ParseSource);

            Item requestedItem = new Item()
            {
                source = ItemSource.Wowhead
                ,WoWHeadXML = xmlItem
                ,RawXML = rawXML
            };

            return requestedItem;
        }
    }
}
