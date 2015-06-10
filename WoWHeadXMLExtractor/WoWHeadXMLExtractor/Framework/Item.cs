using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml;
using WoWHeadXMLExtractor.Framework.Core;

namespace WoWHeadXMLExtractor.Framework
{
    public class Item : WoWHeadXMLExtractor.Framework.Core.WHXEObject
    {
        public string Bonuses { get; set; }
    }
}
