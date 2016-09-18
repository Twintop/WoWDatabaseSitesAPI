using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoWDatabaseSitesAPI.Framework.WoWDBAPI
{
    public class Stat
    {
        public int StatID { get; set; }
        public int Quantity { get; set; }
        public int RawQuantity { get; set; }
        public int RawScalingFactor { get; set; }
    }

    public class Stat2
    {
        public int StatID { get; set; }
        public int Quantity { get; set; }
        public int RawQuantity { get; set; }
        public int RawScalingFactor { get; set; }
    }

    public class Upgrade
    {
        public int UpgradeTypeId { get; set; }
        public int RequiredCurrencyId { get; set; }
        public int RequiredCurrencyAmount { get; set; }
        public int ItemLevel { get; set; }
        public int Armor { get; set; }
        public double MinDamage { get; set; }
        public double MaxDamage { get; set; }
        public double DPS { get; set; }
        public List<Stat2> Stats { get; set; }
        public string RequiredCurrencyName { get; set; }
    }

    public class Scaling
    {
    }

    public class DroppedBy
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public class WoWDBRootObject
    {
        public int ID { get; set; }
        public int Build { get; set; }
        public string Name { get; set; }
        public int Quality { get; set; }
        public int Class { get; set; }
        public int Subclass { get; set; }
        public int Subsubclass { get; set; }
        public string Icon { get; set; }
        public int InventorySlot { get; set; }
        public int Flags1 { get; set; }
        public int Flags2 { get; set; }
        public int BuyPrice { get; set; }
        public int SellPrice { get; set; }
        public int RequiredClassBitmask { get; set; }
        public int RequiredRaceBitmask { get; set; }
        public int Level { get; set; }
        public int RequiredLevel { get; set; }
        public string RequiredSkill { get; set; }
        public int RequiredSkillRank { get; set; }
        public int RequiredSpellID { get; set; }
        public string RequiredFaction { get; set; }
        public int RequiredFactionStanding { get; set; }
        public int UniqueMaxCount { get; set; }
        public int MaxStack { get; set; }
        public int ContainerSlots { get; set; }
        public int WeaponSpeed { get; set; }
        public int BindType { get; set; }
        public string FlavorText { get; set; }
        public int StartsQuestID { get; set; }
        public bool Locked { get; set; }
        public bool HasRandomStats { get; set; }
        public int SetID { get; set; }
        public string SetName { get; set; }
        public List<int> Sockets { get; set; }
        public string SocketBonus { get; set; }
        public int SocketBonusID { get; set; }
        public int Duration { get; set; }
        public double MinDamage { get; set; }
        public double MaxDamage { get; set; }
        public double DPS { get; set; }
        public int Armor { get; set; }
        public string UniqueCategory { get; set; }
        public double DamageRange { get; set; }
        public int RequiredDisenchantSkill { get; set; }
        public int GlyphType { get; set; }
        public int Availability { get; set; }
        public int GemRequiredItemLevel { get; set; }
        public bool GemIsJcOnly { get; set; }
        public bool IsPvpItem { get; set; }
        public bool IsNonConsumable { get; set; }
        public int Source { get; set; }
        public int SingleSourceID { get; set; }
        public bool IsStartingItem { get; set; }
        public int Side { get; set; }
        public int UsableByClassBitmask { get; set; }
        public int StatFlags { get; set; }
        public int ClassCategory { get; set; }
        public int RaidDifficultyType { get; set; }
        public int DisplayID { get; set; }
        public List<object> Spells { get; set; }
        public List<Stat> Stats { get; set; }
        public List<Upgrade> Upgrades { get; set; }
        public List<object> PossibleBonuses { get; set; }
        public List<object> SeenBonuses { get; set; }
        public string GreenText { get; set; }
        public List<object> CreatedBySpellIDs { get; set; }
        public Scaling Scaling { get; set; }
        public int RelicItemlevels { get; set; }
        public List<DroppedBy> DroppedBy { get; set; }
    }
}
