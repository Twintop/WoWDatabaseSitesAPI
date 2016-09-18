using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml;
using WoWDatabaseSitesAPI.Framework.Core;

namespace WoWDatabaseSitesAPI.Framework
{
    public class Item : WoWDatabaseSitesAPI.Framework.Core.WDSAObject
    {
        public string Bonuses { get; set; }
    }
}
