using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WoWDatabaseSitesAPI.BusinessLogic;
using WoWDatabaseSitesAPI.Framework;
using WoWDatabaseSitesAPI.Framework.Core;
using WoWDatabaseSitesAPI.Framework.WoWDBAPI;
using WoWDatabaseSitesAPI.Services;

namespace WoWDatabaseSitesAPI.Services
{
    public class WoWDBJSONItemService : WoWDBAPIObject
    {
        #region Singleton Implementation

        private static WoWDBJSONItemService _Service;

        public static WoWDBJSONItemService Provider
        {
            get
            {
                if (_Service == null)
                {
                    _Service = new WoWDBJSONItemService();
                }
                return _Service;
            }
        }

        #endregion

        #region Private Constructor

        private WoWDBJSONItemService() { }

        #endregion

        #region Public Methods

        public WoWDBItem ConvertItemJSON(string rawJSON)
        {
            WoWDBItem Item = CreateObject(rawJSON);

            return Item;
        }

        protected WoWDBItem CreateObject(string rawJSON)
        {
            WoWDBItem record = new WoWDBItem();
            record.RootObject = new WoWDBRootObject();

            record.RootObject = JsonConvert.DeserializeObject<WoWDBRootObject>(rawJSON);
            
            return record;
        }

        #endregion
    }
}
