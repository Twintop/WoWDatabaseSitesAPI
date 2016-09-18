using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using WoWDatabaseSitesAPI.Framework;
using WoWDatabaseSitesAPI.Framework.Core;

namespace WoWDatabaseSitesAPI.BusinessLogic
{
    public static class WoWDBAPI
    {
        public static string GetWoWDBItem(int id, string bonuses = "", WoWDBSiteType sitetype = WoWDBSiteType.Live)
        {
            string objectURL = "http://";

            switch (sitetype)
            {
                case WoWDBSiteType.Live:
                default:
                    objectURL += "www";
                    break;
                case WoWDBSiteType.PTR:
                    objectURL += "ptr";
                    break;
                case WoWDBSiteType.Beta:
                    objectURL += "beta";
                    break;
            }

            objectURL += ".wowdb.com/api/";
            objectURL += "item/" + id;

            if (!String.IsNullOrWhiteSpace(bonuses))
            {
                objectURL += "?bonusIDs=" + bonuses;
            }


            string wowdbJSON = new WebClient().DownloadString(objectURL);

            // The JSON returned by WoWDB's API is conclosed in parenthesis. Strip these out if they exist.
            if (wowdbJSON.Substring(0,1) == "(")
            {
                wowdbJSON = wowdbJSON.Substring(1);
            }

            if (wowdbJSON.Substring(wowdbJSON.Length-1, 1) == ")")
            {
                wowdbJSON = wowdbJSON.Substring(0, wowdbJSON.Length - 1);
            }

            return wowdbJSON;
        }

        public static Item ConvertItemJSON(string rawJSON)
        {
            WoWDBItem wowdb_Item = new WoWDBItem();

            wowdb_Item = WoWDBAPIManager.Provider.GetJSONItem(rawJSON);

            Item requestedItem = new Item()
            {
                source = ItemSource.WoWDB
                ,WoWDBAPIItem = wowdb_Item
            };

            return requestedItem;
        }
    }
}
