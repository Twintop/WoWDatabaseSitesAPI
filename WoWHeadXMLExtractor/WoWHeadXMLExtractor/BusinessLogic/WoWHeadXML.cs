using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using WoWHeadXMLExtractor.Framework;
using WoWHeadXMLExtractor.Framework.Core;

namespace WoWHeadXMLExtractor.BusinessLogic
{
    public static class WoWHeadXML
    {
        public static XmlDocument GetWoWHeadXML(int id, string bonuses = "", WoWHeadSiteType sitetype = WoWHeadSiteType.Live)
        {
            XmlDocument wowheadXML = new XmlDocument();

            string objectURL = "http://";

            switch (sitetype)
            {
                case WoWHeadSiteType.Live:
                default:
                    objectURL += "www";
                    break;
                case WoWHeadSiteType.PTR:
                    objectURL += "ptr";
                    break;
                case WoWHeadSiteType.Beta:
                    objectURL += "beta";
                    break;
                case WoWHeadSiteType.Legion:
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
            WoWHeadXMLItem xmlItem = new WoWHeadXMLItem();

            xmlItem = WoWHeadXMLManager.Provider.GetXMLItem(rawXML, ParseSource);

            Item requestedItem = new Item()
            {
                WoWHeadXML = xmlItem
                ,RawXML = rawXML
            };

            return requestedItem;
        }
    }
}
