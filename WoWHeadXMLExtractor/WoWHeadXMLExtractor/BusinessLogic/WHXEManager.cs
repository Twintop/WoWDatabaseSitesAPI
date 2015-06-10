using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoWHeadXMLExtractor.Framework;
using WoWHeadXMLExtractor.Framework.Core;
using WoWHeadXMLExtractor.Services;

namespace WoWHeadXMLExtractor.BusinessLogic
{
    public class WHXEManager
    {
        #region Singleton Implementation
        private static WHXEManager _Service;
        public static WHXEManager Provider
        {
            get
            {
                if (_Service == null)
                {
                    _Service = new WHXEManager();
                }
                return _Service;
            }
        }
        
        #endregion

        #region Private Constructor
        private WHXEManager() { }

        #endregion

        #region Items

        public Item GetItemDetailsByURL(int id, string bonuses = "", WoWHeadSiteType sitetype = WoWHeadSiteType.Live, int ParseSource = 2)
        {
            Item returnItem = new Item();

            returnItem = ItemService.Provider.ItemGet(id, bonuses, sitetype, ParseSource);

            if (returnItem == null)
                return null;

            returnItem.Id = returnItem.WoWHeadXML.Id = id;
            returnItem.Bonuses = returnItem.WoWHeadXML.Bonuses = bonuses;
            returnItem.SiteType = sitetype;

            return returnItem;
        }

        #endregion
    }
}
