using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using WoWDatabaseSitesAPI.Framework;
using WoWDatabaseSitesAPI.Framework.Core;
using WoWDatabaseSitesAPI.Services;

namespace WoWDatabaseSitesAPI.BusinessLogic
{
    public class WoWDBAPIManager
    {
        #region Singleton Implementation
        private static WoWDBAPIManager _Service;
        public static WoWDBAPIManager Provider
        {
            get
            {
                if (_Service == null)
                {
                    _Service = new WoWDBAPIManager();
                }
                return _Service;
            }
        }
        
        #endregion

        #region Private Constructor
        private WoWDBAPIManager() { }

        #endregion

        #region Items

        public WoWDBItem GetJSONItem(string rawJSON)
        {
            WoWDBItem returnItem = WoWDBJSONItemService.Provider.ConvertItemJSON(rawJSON);

            return returnItem;
        }

        #endregion
    }
}
