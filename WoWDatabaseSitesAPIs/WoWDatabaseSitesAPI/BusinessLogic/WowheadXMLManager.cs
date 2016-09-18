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
    public class WowheadXMLManager
    {
        #region Singleton Implementation
        private static WowheadXMLManager _Service;
        public static WowheadXMLManager Provider
        {
            get
            {
                if (_Service == null)
                {
                    _Service = new WowheadXMLManager();
                }
                return _Service;
            }
        }
        
        #endregion

        #region Private Constructor
        private WowheadXMLManager() { }

        #endregion

        #region Items

        public WowheadXMLItem GetXMLItem(XmlDocument rawXML, int ParseSource = 2)
        {
            WowheadXMLItem returnXML = WowheadXMLItemService.Provider.ParseItemXML(rawXML, ParseSource);

            return returnXML;
        }

        #endregion
    }
}
