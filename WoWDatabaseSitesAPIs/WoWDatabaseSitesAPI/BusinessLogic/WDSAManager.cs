using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoWDatabaseSitesAPI.Framework;
using WoWDatabaseSitesAPI.Framework.Core;
using WoWDatabaseSitesAPI.Services;

namespace WoWDatabaseSitesAPI.BusinessLogic
{
    public class WDSAManager
    {
        #region Singleton Implementation
        private static WDSAManager _Service;
        public static WDSAManager Provider
        {
            get
            {
                if (_Service == null)
                {
                    _Service = new WDSAManager();
                }
                return _Service;
            }
        }
        
        #endregion

        #region Private Constructor
        private WDSAManager() { }

        #endregion

        #region Items

        public Item Wowhead_GetItemDetailsByURL(int id, string bonuses = "", WowheadSiteType sitetype = WowheadSiteType.Live, int ParseSource = 2)
        {
            Item returnItem = new Item();

            returnItem = ItemService.Provider.ItemGet(id, bonuses, sitetype, ParseSource);

            if (returnItem == null)
                return null;

            returnItem.Id = returnItem.WoWHeadXML.Id = id;
            returnItem.Bonuses = returnItem.WoWHeadXML.Bonuses = bonuses;
            returnItem.WowheadSite = sitetype;

            return returnItem;
        }

        public Item WoWDB_GetItemDetailsByAPI(int id, string bonuses = "", WoWDBSiteType sitetype = WoWDBSiteType.Live)
        {
            Item returnItem = new Item();

            returnItem = ItemService.Provider.ItemGet(id, bonuses, sitetype);

            if (returnItem == null)
                return null;

            returnItem.Id = returnItem.WoWDBAPIItem.RootObject.ID = id;
            returnItem.Bonuses = returnItem.Bonuses = bonuses;
            returnItem.WoWDBSite = sitetype;

            return returnItem;
        }

        #endregion
    }
}
