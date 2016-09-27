using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoWDatabaseSitesAPI.Framework.Core;
using WoWDatabaseSitesAPI.Framework.WoWHeadXML;

namespace WoWDatabaseSitesAPI.Framework.Core
{
    [Serializable()]
    public class WowheadXMLItem : WowheadXMLObject
    {
        public WowheadXMLItem()
        {
            this.TooltipData = new WowheadItemTooltip();
            this.itemJsonData = new itemJson();
            this.itemJsonEquipData = new itemJsonEquip();
            this.item = new wowheadItem();
        }

        public itemJson itemJsonData { get; set; }

        public itemJsonEquip itemJsonEquipData { get; set; }

        public string StrippedHtmlString { get; set; }

        public string Bonuses { get; set; }

        public int Id { get; set; }

        public WowheadItemTooltip TooltipData { get; set; }

        public wowheadItem itemField;

        public wowheadItem item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        public int Agility
        {
            get
            {
                int returnValue = 0;

                if (this.itemJsonEquipData.agistrint > returnValue)
                {
                    returnValue = this.itemJsonEquipData.agistrint;
                }

                if (this.TooltipData.AgilityStrengthIntellect > returnValue)
                {
                    returnValue = this.TooltipData.AgilityStrengthIntellect;
                }

                if (this.itemJsonEquipData.agiint > returnValue)
                {
                    returnValue = this.itemJsonEquipData.agiint;
                }

                if (this.TooltipData.AgilityIntellect > returnValue)
                {
                    returnValue = this.TooltipData.AgilityIntellect;
                }

                if (this.itemJsonEquipData.agistr > returnValue)
                {
                    returnValue = this.itemJsonEquipData.agistr;
                }

                if (this.TooltipData.AgilityStrength > returnValue)
                {
                    returnValue = this.TooltipData.AgilityStrength;
                }

                if (this.itemJsonEquipData.agi > returnValue)
                {
                    returnValue = this.itemJsonEquipData.agi;
                }

                if (this.TooltipData.Agility > returnValue)
                {
                    returnValue = this.TooltipData.Agility;
                }

                return returnValue;
            }
        }

        public int Armor
        {
            get
            {
                int returnValue = 0;

                if (this.itemJsonEquipData.armor > returnValue)
                {
                    returnValue = this.itemJsonEquipData.armor;
                }

                if (this.TooltipData.Armor > returnValue)
                {
                    returnValue = this.TooltipData.Armor;
                }

                return returnValue;
            }
        }

        public int BuyPrice
        {
            get
            {
                return this.itemJsonEquipData.buyprice;
            }
        }

        public int Crit
        {
            get
            {
                int returnValue = 0;

                if (this.itemJsonEquipData.critstrkrtng > returnValue)
                {
                    returnValue = this.itemJsonEquipData.critstrkrtng;
                }

                if (this.TooltipData.Crit < returnValue || returnValue == 0)
                {
                    returnValue = this.TooltipData.Crit;
                }

                return returnValue;
            }
        }

        public string Description
        {
            get
            {
                string returnValue = string.Empty;

                if (!String.IsNullOrWhiteSpace(this.itemJsonData.namedesc))
                {
                    returnValue = this.itemJsonData.namedesc;
                }

                if (!String.IsNullOrWhiteSpace(this.TooltipData.Description))
                {
                    returnValue = this.TooltipData.Description;
                }

                return returnValue;
            }
        }

        public int DamageMax
        {
            get
            {
                int returnValue = 0;

                if (this.itemJsonEquipData.dmgmax1 > returnValue)
                {
                    returnValue = this.itemJsonEquipData.dmgmax1;
                }

                if (this.TooltipData.DamageHigh > returnValue)
                {
                    returnValue = this.TooltipData.DamageHigh;
                }

                return returnValue;
            }
        }

        public int DamageMin
        {
            get
            {
                int returnValue = 0;

                if (this.itemJsonEquipData.dmgmin1 > returnValue)
                {
                    returnValue = this.itemJsonEquipData.dmgmin1;
                }

                if (this.TooltipData.DamageLow > returnValue)
                {
                    returnValue = this.TooltipData.DamageLow;
                }

                return returnValue;
            }
        }

        public double DamageRange
        {
            get
            {
                double returnValue = 0;

                if (this.itemJsonEquipData.dmgrange > returnValue)
                {
                    returnValue = this.itemJsonEquipData.dmgrange;
                }

                return returnValue;
            }
        }

        public int DamageType
        {
            get
            {
                int returnValue = 0;

                if (this.itemJsonEquipData.dmgtype1 > returnValue)
                {
                    returnValue = this.itemJsonEquipData.dmgtype1;
                }

                return returnValue;
            }
        }

        public double DPS
        {
            get
            {
                double returnValue = 0;

                if (this.itemJsonEquipData.dps > returnValue)
                {
                    returnValue = this.itemJsonEquipData.dps;
                }

                return returnValue;
            }
        }

        public double DropChance
        {
            get
            {
                double returnValue = 0;

                if (this.TooltipData.DropChance > returnValue)
                {
                    returnValue = this.TooltipData.DropChance;
                }

                return returnValue;
            }
        }

        public int Durability
        {
            get
            {
                int returnValue = 0;

                if (this.itemJsonEquipData.dura > returnValue)
                {
                    returnValue = this.itemJsonEquipData.dura;
                }

                return returnValue;
            }
        }

        public int Haste
        {
            get
            {
                int returnValue = 0;

                if (this.itemJsonEquipData.hastertng > returnValue)
                {
                    returnValue = this.itemJsonEquipData.hastertng;
                }

                if (this.TooltipData.Haste < returnValue || returnValue == 0)
                {
                    returnValue = this.TooltipData.Haste;
                }

                return returnValue;
            }
        }

        public int ItemId
        {
            get
            {
                int returnValue = 0;

                if (this.Id > returnValue)
                {
                    returnValue = this.Id;
                }

                if (this.itemJsonData.id > returnValue)
                {
                    returnValue = this.itemJsonData.displayid;
                }

                return returnValue;
            }
        }

        public int Intellect
        {
            get
            {
                int returnValue = 0;

                if (this.itemJsonEquipData.agistrint > returnValue)
                {
                    returnValue = this.itemJsonEquipData.agistrint;
                }

                if (this.TooltipData.AgilityStrengthIntellect > returnValue)
                {
                    returnValue = this.TooltipData.AgilityStrengthIntellect;
                }

                if (this.itemJsonEquipData.agiint > returnValue)
                {
                    returnValue = this.itemJsonEquipData.agiint;
                }

                if (this.TooltipData.AgilityIntellect > returnValue)
                {
                    returnValue = this.TooltipData.AgilityIntellect;
                }

                if (this.itemJsonEquipData.strint > returnValue)
                {
                    returnValue = this.itemJsonEquipData.strint;
                }

                if (this.TooltipData.StrengthIntellect > returnValue)
                {
                    returnValue = this.TooltipData.StrengthIntellect;
                }

                if (this.itemJsonEquipData.@int > returnValue)
                {
                    returnValue = this.itemJsonEquipData.@int;
                }

                if (this.TooltipData.Intellect > returnValue)
                {
                    returnValue = this.TooltipData.Intellect;
                }

                return returnValue;
            }
        }

        public int ItemLevel
        {
            get
            {
                int returnValue = 0;

                if (this.itemJsonData.level > returnValue)
                {
                    returnValue = this.itemJsonData.level;
                }

                if (this.TooltipData.ItemLevel > returnValue)
                {
                    returnValue = this.TooltipData.ItemLevel;
                }

                if (this.item.level > returnValue)
                {
                    returnValue = this.TooltipData.ItemLevel;
                }

                return returnValue;
            }
        }

        public int ItemSetId
        {
            get
            {
                int returnValue = 0;

                if (this.itemJsonEquipData.itemset > returnValue)
                {
                    returnValue = this.itemJsonEquipData.itemset;
                }

                return returnValue;
            }
        }

        public int Mastery
        {
            get
            {
                int returnValue = 0;

                if (this.itemJsonEquipData.mastrtng > returnValue)
                {
                    returnValue = this.itemJsonEquipData.mastrtng;
                }

                if (this.TooltipData.Mastery < returnValue || returnValue == 0)
                {
                    returnValue = this.TooltipData.Mastery;
                }

                return returnValue;
            }
        }

        public int MeleeDamageMax
        {
            get
            {
                int returnValue = 0;

                if (this.itemJsonEquipData.mledmgmax > returnValue)
                {
                    returnValue = this.itemJsonEquipData.mledmgmax;
                }

                return returnValue;
            }
        }

        public int MeleeDamageMin
        {
            get
            {
                int returnValue = 0;

                if (this.itemJsonEquipData.mledmgmin > returnValue)
                {
                    returnValue = this.itemJsonEquipData.mledmgmin;
                }

                return returnValue;
            }
        }

        public double MeleeDPS
        {
            get
            {
                double returnValue = 0;

                if (this.itemJsonEquipData.mledps > returnValue)
                {
                    returnValue = this.itemJsonEquipData.mledps;
                }

                return returnValue;
            }
        }

        public double MeleeSpeed
        {
            get
            {
                double returnValue = 0;

                if (this.itemJsonEquipData.mlespeed > returnValue)
                {
                    returnValue = this.itemJsonEquipData.mlespeed;
                }

                return returnValue;
            }
        }

        public string Name
        {
            get
            {
                string returnValue = string.Empty;

                if (!String.IsNullOrWhiteSpace(this.itemJsonData.name))
                {
                    returnValue = this.itemJsonData.name;
                }

                if (!String.IsNullOrWhiteSpace(this.TooltipData.Name))
                {
                    returnValue = this.TooltipData.Name;
                }

                if (!String.IsNullOrWhiteSpace(this.item.name))
                {
                    returnValue = this.item.name;
                }

                return returnValue;
            }
        }

        public int PvPItemLevel
        {
            get
            {
                int returnValue = 0;

                if (this.itemJsonData.level > returnValue)
                {
                    returnValue = this.itemJsonData.level;
                }

                if (this.TooltipData.ItemLevel > returnValue)
                {
                    returnValue = this.TooltipData.ItemLevel;
                }

                if (this.itemJsonData.pvpUpgrade > 0)
                {
                    returnValue += this.itemJsonData.pvpUpgrade;
                }

                return returnValue;
            }
        }

        public Quality Quality
        {
            get
            {
                Quality returnValue = Quality.Unknown;

                if (Convert.ToInt32(this.item.quality.id) >= 0)
                {
                    returnValue = (Quality)Convert.ToInt32(this.item.quality.id);
                }

                return returnValue;
            }
        }

        public int QualityId
        {
            get
            {
                int returnValue = (int)this.Quality;

                return returnValue;
            }
        }

        public string QualityName
        {
            get
            {
                string returnValue = Enum.GetName(typeof(Quality), this.Quality);

                return returnValue;
            }
        }

        public int RangedDamageMax
        {
            get
            {
                int returnValue = 0;

                if (this.itemJsonEquipData.rgddmgmax > returnValue)
                {
                    returnValue = this.itemJsonEquipData.rgddmgmax;
                }

                return returnValue;
            }
        }

        public int RangedDamageMin
        {
            get
            {
                int returnValue = 0;

                if (this.itemJsonEquipData.rgddmgmin > returnValue)
                {
                    returnValue = this.itemJsonEquipData.rgddmgmin;
                }

                return returnValue;
            }
        }

        public double RangedDPS
        {
            get
            {
                double returnValue = 0;

                if (this.itemJsonEquipData.rgddps > returnValue)
                {
                    returnValue = this.itemJsonEquipData.rgddps;
                }

                return returnValue;
            }
        }

        public double RangedSpeed
        {
            get
            {
                double returnValue = 0;

                if (this.itemJsonEquipData.rgdspeed > returnValue)
                {
                    returnValue = this.itemJsonEquipData.rgdspeed;
                }

                return returnValue;
            }
        }

        public int SellPrice
        {
            get
            {
                return this.itemJsonEquipData.sellprice;
            }
        }

        public int SlotId
        {
            get
            {
                int returnValue = 0;

                if (this.itemJsonData.slot > returnValue)
                {
                    returnValue = this.itemJsonData.slot;
                }

                if (this.TooltipData.SlotId > returnValue)
                {
                    returnValue = this.TooltipData.SlotId;
                }

                return returnValue;
            }
        }

        public string SlotName
        {
            get
            {
                string returnValue = string.Empty;

                InventorySlot slot = (InventorySlot)this.SlotId;

                returnValue = Enum.GetName(typeof(InventorySlot), slot);

                return returnValue;
            }
        }

        public int SpellPower
        {
            get
            {
                int returnValue = 0;

                if (this.itemJsonEquipData.splpwr > returnValue)
                {
                    returnValue = this.itemJsonEquipData.splpwr;
                }

                if (this.TooltipData.SpellPower > returnValue)
                {
                    returnValue = this.TooltipData.SpellPower;
                }

                return returnValue;
            }
        }

        public string Source
        {
            get
            {
                string returnValue = string.Empty;

                if (!string.IsNullOrWhiteSpace(this.TooltipData.Source))
                {
                    returnValue = this.TooltipData.Source;
                }

                if (this.itemJsonData.sourcemore != null && this.itemJsonData.sourcemore.Count > 0)
                {
                    if (!string.IsNullOrWhiteSpace(this.itemJsonData.sourcemore[0].n))
                    {
                        returnValue = this.itemJsonData.sourcemore[0].n;
                    }
                }

                return returnValue;
            }
        }

        public int Stamina
        {
            get
            {
                int returnValue = 0;

                if (this.itemJsonEquipData.sta > returnValue)
                {
                    returnValue = this.itemJsonEquipData.sta;
                }

                if (this.TooltipData.Stamina > returnValue)
                {
                    returnValue = this.TooltipData.Stamina;
                }

                return returnValue;
            }
        }

        public int Strength
        {
            get
            {
                int returnValue = 0;

                if (this.itemJsonEquipData.agistrint > returnValue)
                {
                    returnValue = this.itemJsonEquipData.agistrint;
                }

                if (this.TooltipData.AgilityStrengthIntellect > returnValue)
                {
                    returnValue = this.TooltipData.AgilityStrengthIntellect;
                }

                if (this.itemJsonEquipData.strint > returnValue)
                {
                    returnValue = this.itemJsonEquipData.strint;
                }

                if (this.TooltipData.StrengthIntellect > returnValue)
                {
                    returnValue = this.TooltipData.AgilityStrengthIntellect;
                }

                if (this.itemJsonEquipData.agistr > returnValue)
                {
                    returnValue = this.itemJsonEquipData.agistr;
                }

                if (this.TooltipData.AgilityStrength > returnValue)
                {
                    returnValue = this.TooltipData.AgilityStrengthIntellect;
                }

                if (this.itemJsonEquipData.str > returnValue)
                {
                    returnValue = this.itemJsonEquipData.str;
                }

                if (this.TooltipData.Strength > returnValue)
                {
                    returnValue = this.TooltipData.Strength;
                }

                return returnValue;
            }
        }

        public int Versatility
        {
            get
            {
                int returnValue = 0;

                if (this.itemJsonEquipData.versatility < returnValue || returnValue == 0)
                {
                    returnValue = this.itemJsonEquipData.versatility;
                }

                if (this.TooltipData.Versatility > returnValue)
                {
                    returnValue = this.TooltipData.Versatility;
                }

                return returnValue;
            }
        }

        public Zones ZoneEnum
        {
            get
            {
                Zones returnValue = Zones.Unknown;

                if (this.itemJsonData.sourcemore != null && this.itemJsonData.sourcemore.Count > 0)
                {
                    returnValue = (Zones)this.itemJsonData.sourcemore[0].z;
                }

                return returnValue;
            }
        }

        public int ZoneId
        {
            get
            {
                int returnValue = 0;

                if (this.itemJsonData.sourcemore != null && this.itemJsonData.sourcemore.Count > 0)
                {
                    returnValue = this.itemJsonData.sourcemore[0].z;
                }

                return returnValue;
            }
        }

        public string ZoneName
        {
            get
            {
                string returnValue = string.Empty;

                if (this.itemJsonData.sourcemore != null && this.itemJsonData.sourcemore.Count > 0 && this.itemJsonData.sourcemore[0].z > 0)
                {
                    string[] name = Enum.GetName(typeof(Zones), this.itemJsonData.sourcemore[0].z).Split(new string[] {"______"}, StringSplitOptions.None);
                    returnValue = name[0].Replace("_____", "' ");
                    returnValue = returnValue.Replace("____", "'");
                    returnValue = returnValue.Replace("___", ": ");
                    returnValue = returnValue.Replace("__", "-");
                    returnValue = returnValue.Replace('_', ' ');
                }

                return returnValue;
            }
        }
    }
}
