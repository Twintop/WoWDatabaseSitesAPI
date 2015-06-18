using System;
using System.Xml.Serialization;
using System.Data;
using System.Globalization;
using System.Runtime.Serialization;
using System.Xml;
using WoWHeadXMLExtractor.BusinessLogic;

namespace WoWHeadXMLExtractor.Framework.Core
{
    [Serializable()]
    public abstract class WHXEObject : ICloneable
    {
        #region Properties
        public int Id { get; set; }
        public XmlDocument RawXML { get; set; }
        public WoWHeadXMLItem WoWHeadXML { get; set; }
        public WoWHeadSiteType SiteType { get; set; }
        #endregion

        public WHXEObject()
        {

        }

        public new virtual object Clone()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public void SetBaseProperty(XmlTextReader reader)
        {
            switch (reader.Name.ToUpper(CultureInfo.CurrentCulture))
            {
                case "ID":
                    this.Id = reader.IsEmptyElement ? -1 : Convert.ToInt32(reader.Value);
                    break;
            }
        }
    }

    public enum WoWHeadSiteType
    {
        Live = 1,
        PTR = 2,
        Beta = 3
    };

    public enum Classes
    {
        Warrior = 1,
        Paladin = 2,
        Hunter = 3,
        Rogue = 4,
        Priest = 5,
        Druid = 6,
        Shaman = 7,
        Mage = 8,
        Warlock = 9,
        Monk = 10,
        DeathKnight = 11
    };

    public enum Specializations
    {
        None = 0,
        Pet = 1,
        Pet_Ferocity = 74,
        Pet_Tenacity = 81,
        Pet_Cunning = 79,
        Warrior_Arms = 71,
        Warrior_Fury = 72,
        Warrior_Protection = 73,
        Paladin_Holy = 65,
        Paladin_Protection = 66,
        Paladin_Retribution = 70,
        Hunder_BeastMastery = 253,
        Hunter_Marksmanship = 254,
        Hunter_Survival = 255,
        Rogue_Assassination = 259,
        Rogue_Combat = 260,
        Rogue_Subtlety = 261,
        Priest_Discipline = 256,
        Priest_Holy = 257,
        Priest_Shadow = 258,
        Druid_Balance = 102,
        Druid_Feral = 103,
        Druid_Guardian = 104,
        Druid_Restoration = 105,
        Shaman_Elemental = 262,
        Shaman_Enhancement = 263,
        Shaman_Restoration = 264,
        Mage_Arcane = 62,
        Mage_Fire = 63,
        Mage_Frost = 64,
        Warlock_Affliction = 265,
        Warlock_Demonology = 266,
        Warlock_Destruction = 267,
        Monk_Brewmaster = 268,
        Monk_Mistweaver = 270,
        Monk_Windwalker = 269,
        DeathKnight_Blood = 250,
        DeathKnight_Frost = 251,
        DeathKnight_Unholy = 252
    };

    public enum InventorySlot
    {
        None = 0,
        Head = 1,
        Neck = 2,
        Shoulder = 3,
        Shirt = 4,
        Chest = 5,
        Waist = 6,
        Legs = 7,
        Feet = 8,
        Wrist = 9,
        Hands = 10,
        Finger = 11,
        Trinket = 12,
        OneHand = 13,
        Shield = 14,
        Ranged = 15,
        Back = 16,
        TwoHand = 17,
        Bag = 18,
        Tabbard = 19,
        MainHand = 21,
        OffHand = 22,
        HeldInOffHand = 23,
        Projectile = 24,
        Thrown = 25
    };

    public enum ItemClass
    {
        Consumeable = 0,
        Container = 1,
        Weapon = 2,
        Gem = 3,
        Armor = 4,
        TradeGoods = 7,
        Recipe = 9,
        Currency = 10,
        Quest = 12,
        Key = 13,
        Miscellaneous = 15,
        Glyph = 16
    };

    public enum WeaponSubClass
    {
        OneHandedAxe = 0,
        TwoHandedAxe = 1,
        Bow = 2,
        Gun = 3,
        OneHandedMace = 4,
        TwoHandedMace = 5,
        Polearm = 6,
        OneHandedSword = 7,
        TwoHandedSword = 8,
        Staff = 10,
        FistWeapon = 13,
        MiscellaneousWeapon = 14,
        Dagger = 15,
        Thrown = 16,
        Crossbow = 18,
        Wand = 19,
        FishingPole = 20
    };

    public enum ArmorSubClass
    {
        Cloth = 1,
        Leather = 2,
        Mail = 3,
        Plate = 4
    };

    public enum Quality
    {
        Poor = 0,
        Common = 1,
        Uncommon = 2,
        Rare = 3,
        Epic = 4,
        Legendary = 5,
        Artifact = 6,
        Heirloom = 7,
        WoWToken = 8
    };

    public enum Zones
    {
        Unknown = -2,
        None = -1,

        //WoD Raids
        Highmaul = 6996,
        Blackrock_Foundry = 6967,
        Hellfire_Citadel = 7545,

        //WoD Dungeons
        Shadowmoon_Burial_Grounds = 6932,
        The_Everbloom = 7109,
        Grimrail_Depot = 6984,
        Upper_Blackrock_Spire = 7307,
        Skyreach = 6988,
        Auchindoun = 6912,
        Iron_Docks = 6951,
        Bloodmaul_Slag_Mines = 6874,

        //WoD Scenarios
        The_Trial_of_Faith = 7381,

        //WoD Zones
        Tanaan_Jungle = 6723,
        Faralohn = 6756,
        Ashran = 6941,
        Nagrand__2 = 6755,
        Spires_of_Arak = 6722,
        Talador = 6662,
        Gorgrond = 6721,
        Frostfire_Ridge = 6720,
        Shadowmoon_Valley__2 = 6719,
        Frostwall = 7004,
        Defense_of_Karabor = 7083,
        Lunarfall = 7078,
        Shattrath_City = 6980
    };
}
