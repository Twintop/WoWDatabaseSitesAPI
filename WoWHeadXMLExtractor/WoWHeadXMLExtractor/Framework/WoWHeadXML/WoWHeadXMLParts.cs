using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoWHeadXMLExtractor.Framework.WoWHeadXML
{
    #region WoWHeadXML Parts
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class wowheadItem
    {

        private string nameField;

        private ushort levelField;

        private wowheadItemQuality qualityField;

        private wowheadItemClass classField;

        private wowheadItemSubclass subclassField;

        private wowheadItemIcon iconField;

        private wowheadItemInventorySlot inventorySlotField;

        private string htmlTooltipField;

        private string jsonField;

        private string jsonEquipField;

        private string linkField;

        private uint idField;

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public ushort level
        {
            get
            {
                return this.levelField;
            }
            set
            {
                this.levelField = value;
            }
        }

        /// <remarks/>
        public wowheadItemQuality quality
        {
            get
            {
                return this.qualityField;
            }
            set
            {
                this.qualityField = value;
            }
        }

        /// <remarks/>
        public wowheadItemClass @class
        {
            get
            {
                return this.classField;
            }
            set
            {
                this.classField = value;
            }
        }

        /// <remarks/>
        public wowheadItemSubclass subclass
        {
            get
            {
                return this.subclassField;
            }
            set
            {
                this.subclassField = value;
            }
        }

        /// <remarks/>
        public wowheadItemIcon icon
        {
            get
            {
                return this.iconField;
            }
            set
            {
                this.iconField = value;
            }
        }

        /// <remarks/>
        public wowheadItemInventorySlot inventorySlot
        {
            get
            {
                return this.inventorySlotField;
            }
            set
            {
                this.inventorySlotField = value;
            }
        }

        /// <remarks/>
        public string htmlTooltip
        {
            get
            {
                return this.htmlTooltipField;
            }
            set
            {
                this.htmlTooltipField = value;
            }
        }

        /// <remarks/>
        public string json
        {
            get
            {
                return this.jsonField;
            }
            set
            {
                this.jsonField = value;
            }
        }

        /// <remarks/>
        public string jsonEquip
        {
            get
            {
                return this.jsonEquipField;
            }
            set
            {
                this.jsonEquipField = value;
            }
        }

        /// <remarks/>
        public string link
        {
            get
            {
                return this.linkField;
            }
            set
            {
                this.linkField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class wowheadItemQuality
    {

        private byte idField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class wowheadItemClass
    {

        private byte idField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class wowheadItemSubclass
    {

        private sbyte idField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public sbyte id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class wowheadItemIcon
    {

        private uint displayIdField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint displayId
        {
            get
            {
                return this.displayIdField;
            }
            set
            {
                this.displayIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class wowheadItemInventorySlot
    {

        private byte idField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
    #endregion

    #region JSON Structures


    public class Appearances
    {
        public List<object> __invalid_name__0 { get; set; }
        public List<object> __invalid_name__1 { get; set; }
        public List<object> __invalid_name__2 { get; set; }
        public List<object> __invalid_name__3 { get; set; }
        public List<object> __invalid_name__4 { get; set; }
        public List<object> __invalid_name__5 { get; set; }
        public List<object> __invalid_name__6 { get; set; }
        public List<object> __invalid_name__7 { get; set; }
        public List<object> __invalid_name__8 { get; set; }
        public List<object> __invalid_name__9 { get; set; }
    }

    public class itemSourcemore
    {
        public int bd { get; set; }
        public int c { get; set; }
        public string icon { get; set; }
        public string n { get; set; }
        public int p { get; set; }
        public int q { get; set; }
        public int s { get; set; }
        public int t { get; set; }
        public int ti { get; set; }
        public int z { get; set; }
    }

    public class itemJson
    {
        public Appearances appearances { get; set; }
        public int armor { get; set; }
        public List<int> bonustrees { get; set; }
        public int classs { get; set; }
        public int displayid { get; set; }
        public double dps { get; set; }
        public int flags2 { get; set; }
        public int id { get; set; }
        public int level { get; set; }
        public string name { get; set; }
        public string namedesc { get; set; }
        public int pvpUpgrade { get; set; }
        public int reqclass { get; set; }
        public int reqlevel { get; set; }
        public int reqrace { get; set; }
        public int side { get; set; }
        public int slot { get; set; }
        public int slotbak { get; set; }
        public List<int> source { get; set; }
        public List<itemSourcemore> sourcemore { get; set; }
        public List<int> specs { get; set; }
        public double speed { get; set; }
        public int subclass { get; set; }
    }

    public class itemJsonEquip
    {
        public int agi { get; set; }
        public int agiint { get; set; }
        public int agistr { get; set; }
        public int agistrint { get; set; }
        public Appearances appearances { get; set; }
        public int armor { get; set; }
        public int armorbonus { get; set; }
        public int buyprice { get; set; }
        public int classes { get; set; }
        public int critstrkrtng { get; set; }
        public int displayid { get; set; }
        public int dmgmax1 { get; set; }
        public int dmgmin1 { get; set; }
        public double dmgrange { get; set; }
        public int dmgtype1 { get; set; }
        public double dps { get; set; }
        public int dura { get; set; }
        public int hastertng { get; set; }
        public int @int { get; set; }
        public int itemset { get; set; }
        public int mastrtng { get; set; }
        public int mledmgmax { get; set; }
        public int mledmgmin { get; set; }
        public double mledps { get; set; }
        public double mlespeed { get; set; }
        public int multistrike { get; set; }
        public int races { get; set; }
        public int reqlevel { get; set; }
        public int rgddmgmax { get; set; }
        public int rgddmgmin { get; set; }
        public double rgddps { get; set; }
        public double rgdspeed { get; set; }
        public int sellprice { get; set; }
        public int slotbak { get; set; }
        public double speed { get; set; }
        public int spi { get; set; }
        public int splpwr { get; set; }
        public int sta { get; set; }
        public int str { get; set; }
        public int strint { get; set; }
        public int versatility { get; set; }
    }

    #endregion

}