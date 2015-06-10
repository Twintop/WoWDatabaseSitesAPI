using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using WoWHeadXMLExtractor.Framework;
using WoWHeadXMLExtractor.Framework.Core;

namespace WoWHeadXMLExtractor.Services
{
    public class ItemService : WHXEObject
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

        public Item ItemGet(int id, string bonuses = "", WoWHeadSiteType sitetype = WoWHeadSiteType.Live, int ParseSource = 2)
        {   
            XmlDocument wowheadXML = WoWHeadXMLExtractor.BusinessLogic.WoWHeadXML.GetWoWHeadXML(id, bonuses, sitetype);

            Item returnedItem = WoWHeadXMLExtractor.BusinessLogic.WoWHeadXML.ParseItemXML(wowheadXML, ParseSource);

            return returnedItem;
        }


        #endregion
    }
}
