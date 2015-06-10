using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using WoWHeadXMLExtractor.Framework;
using WoWHeadXMLExtractor.Framework.Core;
using WoWHeadXMLExtractor.Services;

namespace WoWHeadXMLExtractor.BusinessLogic
{
    public class WoWHeadXMLManager
    {
        #region Singleton Implementation
        private static WoWHeadXMLManager _Service;
        public static WoWHeadXMLManager Provider
        {
            get
            {
                if (_Service == null)
                {
                    _Service = new WoWHeadXMLManager();
                }
                return _Service;
            }
        }
        
        #endregion

        #region Private Constructor
        private WoWHeadXMLManager() { }

        #endregion

        #region Items

        public WoWHeadXMLItem GetXMLItem(XmlDocument rawXML, int ParseSource = 2)
        {
            WoWHeadXMLItem returnXML = WoWHeadXMLItemService.Provider.ParseItemXML(rawXML, ParseSource);

            return returnXML;
        }

        #endregion
    }
}
