using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoWDatabaseSitesAPI.Framework.Core;
using WoWDatabaseSitesAPI.Framework.WoWDBAPI;

namespace WoWDatabaseSitesAPI.Framework.Core
{
    public class WoWDBItem : WoWDBAPIObject
    {
        public WoWDBItem()
        {
            this.RootObject = new WoWDBRootObject();
        }

        public WoWDBRootObject RootObject { get; set; }

        
        public int Agility
        {
            get
            {
                int returnValue = 0;

                List<Stat> agi = this.RootObject.Stats.FindAll(x => x.StatID == 71 || x.StatID == 72 || x.StatID == 73 || x.StatID == 3);

                if (agi.Count > 0)
                {
                    foreach (Stat x in agi)
                    {
                        if (x.Quantity > returnValue)
                        {
                            returnValue = x.Quantity;
                        }
                    }
                }

                return returnValue;
            }
        }

        public int Armor
        {
            get
            {
                return this.RootObject.Armor;
            }
        }

        public int BuyPrice
        {
            get
            {
                return this.RootObject.BuyPrice;
            }
        }

        public int Crit
        {
            get
            {
                int returnValue = 0;

                Stat crit = this.RootObject.Stats.Find(x => x.StatID == 32);

                if (crit != null && crit.Quantity > returnValue)
                {
                    returnValue = crit.Quantity;
                }

                return returnValue;
            }
        }

        /*
        public string Description
        {
            get
            {
                string returnValue = string.Empty;

                if (!String.IsNullOrWhiteSpace(this.RootObject..namedesc))
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
        */

        public int DamageMax
        {
            get
            {
                return (int)this.RootObject.MaxDamage;
            }
        }

        public int DamageMin
        {
            get
            {
                return (int)this.RootObject.MinDamage;
            }
        }

        public double DamageRange
        {
            get
            {
                return this.RootObject.DamageRange;
            }
        }

        /*
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
        */

        public double DPS
        {
            get
            {
                return this.RootObject.DPS;
            }
        }

        /*
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
        */

        public int Haste
        {
            get
            {
                int returnValue = 0;

                Stat haste = this.RootObject.Stats.Find(x => x.StatID == 36);

                if (haste != null && haste.Quantity > returnValue)
                {
                    returnValue = haste.Quantity;
                }

                return returnValue;
            }
        }

        public int ItemId
        {
            get
            {
                return this.RootObject.ID;
            }
        }

        public int Intellect
        {
            get
            {
                int returnValue = 0;

                List<Stat> intel = this.RootObject.Stats.FindAll(x => x.StatID == 71 || x.StatID == 73 || x.StatID == 74 || x.StatID == 5);

                if (intel.Count > 0)
                {
                    foreach (Stat x in intel)
                    {
                        if (x.Quantity > returnValue)
                        {
                            returnValue = x.Quantity;
                        }
                    }
                }

                return returnValue;
            }
        }

        public int ItemLevel
        {
            get
            {
                return this.RootObject.Level;
            }
        }

        public int ItemSetId
        {
            get
            {
                return this.RootObject.SetID;
            }
        }

        public string ItemSetName
        {
            get
            {
                return this.RootObject.SetName;
            }
        }

        public int Mastery
        {
            get
            {
                int returnValue = 0;

                Stat mast = this.RootObject.Stats.Find(x => x.StatID == 49);

                if (mast != null && mast.Quantity > returnValue)
                {
                    returnValue = mast.Quantity;
                }

                return returnValue;
            }
        }

        public int MeleeDamageMax
        {
            get
            {
                return (int)this.RootObject.MaxDamage;
            }
        }

        public int MeleeDamageMin
        {
            get
            {
                return (int)this.RootObject.MinDamage;
            }
        }

        public double MeleeDPS
        {
            get
            {
                return this.RootObject.DPS;
            }
        }

        public double MeleeSpeed
        {
            get
            {
                return (double)this.RootObject.WeaponSpeed / 1000.0;
            }
        }

        public string Name
        {
            get
            {
                string returnValue = string.Empty;

                if (!String.IsNullOrWhiteSpace(this.RootObject.Name))
                {
                    returnValue = this.RootObject.Name;
                }

                return returnValue;
            }
        }

        public Quality Quality
        {
            get
            {
                Quality returnValue = Quality.Unknown;

                if (Convert.ToInt32(this.RootObject.Quality) >= 0)
                {
                    returnValue = (Quality)Convert.ToInt32(this.RootObject.Quality);
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
                return (int)this.RootObject.MaxDamage;
            }
        }

        public int RangedDamageMin
        {
            get
            {
                return (int)this.RootObject.MinDamage;
            }
        }

        public double RangedDPS
        {
            get
            {
                return this.RootObject.DPS;
            }
        }

        public double RangedSpeed
        {
            get
            {
                return (double)this.RootObject.WeaponSpeed / 1000.0;
            }
        }

        public int SellPrice
        {
            get
            {
                return this.RootObject.SellPrice;
            }
        }

        public int SlotId
        {
            get
            {
                return this.RootObject.InventorySlot;
            }
        }

        public string SlotName
        {
            get
            {
                string returnValue = string.Empty;

                InventorySlot slot = (InventorySlot)this.RootObject.InventorySlot;

                returnValue = Enum.GetName(typeof(InventorySlot), slot);

                return returnValue;
            }
        }

        public int SpellPower
        {
            get
            {
                int returnValue = 0;

                Stat sp = this.RootObject.Stats.Find(x => x.StatID == 45);

                if (sp != null && sp.Quantity > returnValue)
                {
                    returnValue = sp.Quantity;
                }

                return returnValue;
            }
        }

        /*
        public string Source
        {
            get
            {
                string returnValue = string.Empty;

                if (!string.IsNullOrWhiteSpace(this.RootObject.Source))
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
        */

        public int Stamina
        {
            get
            {
                int returnValue = 0;

                Stat stam = this.RootObject.Stats.Find(x => x.StatID == 7);

                if (stam != null && stam.Quantity > returnValue)
                {
                    returnValue = stam.Quantity;
                }

                return returnValue;
            }
        }

        public int Strength
        {
            get
            {
                int returnValue = 0;

                List<Stat> str = this.RootObject.Stats.FindAll(x => x.StatID == 71 || x.StatID == 72 || x.StatID == 74 || x.StatID == 4);

                if (str.Count > 0)
                {
                    foreach (Stat x in str)
                    {
                        if (x.Quantity > returnValue)
                        {
                            returnValue = x.Quantity;
                        }
                    }
                }

                return returnValue;
            }
        }

        public int Versatility
        {
            get
            {
                int returnValue = 0;

                Stat vers = this.RootObject.Stats.Find(x => x.StatID == 40);

                if (vers != null && vers.Quantity > returnValue)
                {
                    returnValue = vers.Quantity;
                }

                return returnValue;
            }
        }

        /*        
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
         */
    
    }
}
