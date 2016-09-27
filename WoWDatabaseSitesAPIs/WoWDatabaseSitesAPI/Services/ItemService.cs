using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using WoWDatabaseSitesAPI.Framework;
using WoWDatabaseSitesAPI.Framework.Core;

namespace WoWDatabaseSitesAPI.Services
{
    public class ItemService : WDSAObject
    {
        #region Singleton Implementation

        private static ItemService _Service;

        public static ItemService Provider
        {
            get
            {
                if (_Service == null)
                {
                    _Service = new ItemService();
                }
                return _Service;
            }
        }

        #endregion

        #region Private Constructor

        private ItemService() { }

        #endregion

        #region Public Methods

        public Item ItemGet(int id, string bonuses = "", WowheadSiteType sitetype = WowheadSiteType.Live, int ParseSource = 2)
        {   
            XmlDocument wowheadXML = WoWDatabaseSitesAPI.BusinessLogic.WowheadXML.GetWoWHeadXML(id, bonuses, sitetype);

            Item returnedItem = WoWDatabaseSitesAPI.BusinessLogic.WowheadXML.ParseItemXML(wowheadXML, ParseSource);

            return returnedItem;
        }

        public Item ItemGet(int id, string bonuses = "", WoWDBSiteType sitetype = WoWDBSiteType.Live)
        {
            string wowdbJSON = WoWDatabaseSitesAPI.BusinessLogic.WoWDBAPI.GetWoWDBItem(id, bonuses, sitetype);

            Item returnedItem = WoWDatabaseSitesAPI.BusinessLogic.WoWDBAPI.ConvertItemJSON(wowdbJSON);

            returnedItem.WoWDBAPIJSON = wowdbJSON;
            returnedItem.WoWDBAPIItem.Bonuses = bonuses;

            return returnedItem;
        }


        #endregion
    }
}
