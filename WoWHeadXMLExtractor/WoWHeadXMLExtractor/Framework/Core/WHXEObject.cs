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
        Beta = 3,
        Legion = 4
    };

    public enum Classes
    {
        Warrior = 1,
        Paladin = 2,
        Hunter = 3,
        Rogue = 4,
        Priest = 5,
        DeathKnight = 6,
        Shaman = 7,
        Mage = 8,
        Warlock = 9,
        Monk = 10,
        Druid = 11,
        DemonHunter = 12
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
        Rogue_Outlaw = 260,
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
        DeathKnight_Unholy = 252,
        DemonHunter_Havoc = 577,
        DemonHunter_Vengeance = 581
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
        Unknown = -1,
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

        //TBC Dungeons
        Auchindoun___Shadow_Labyrinth = 3789,
        Auchindoun___Auchenai_Crypts = 3790,
        Auchindoun___Sethekk_Halls = 3791,
        Auchindoun___Mana__Tombs = 3792,
        Caverns_of_Time___The_Black_Morass = 2366,
        Caverns_of_Time___Old_Hillsbrad_Foothills = 2367,
        Coilfang_Reservoir___The_Steamvault = 3715,
        Coilfang_Reservoir___The_Underbog = 3716,
        Coilfang_Reservoir___The_Slave_Pens = 3717,
        Hellfire_Citadel___The_Blood_Furnace = 3713,
        Hellfire_Citadel___The_Shattered_Halls = 3714,
        Hellfire_Citadel___Hellfire_Ramparts = 3562,
        Magister____s_Terrace = 4131,
        Tempest_Keep___The_Botanica = 3847,
        Tempest_Keep___The_Arcatraz = 3848,
        Tempest_Keep___The_Mechanar = 3849,

        //WotLK Dungeons
        Azjol__Nerub___Ahn____kahet___The_Old_Kingdom = 4494,
        Azjol__Nerub___Azjol__Nerub = 4277,
        Caverns_of_Time___The_Culling_of_Stratholme = 4100,
        Crusaders_____Coliseum___Trial_of_the_Champion = 4723,
        Drak____Tharon_Keep = 4196,
        Gundrak = 4416,
        Icecrown_Citadel___Pit_of_Saron = 4813,
        Icecrown_Citadel___The_Forge_of_Souls = 4809,
        Icecrown_Citadel___Halls_of_Reflection = 4820,
        The_Nexus___The_Oculus = 4228,
        The_Nexus___The_Nexus = 4265,
        The_Violet_Hold = 4415,
        Ulduar___Halls_of_Lightning = 4272,
        Ulduar___Halls_of_Stone = 4264,
        Utgarde_Keep___Utgarde_Keep = 206,
        Utgarde_Keep___Utgard_Pinnacle = 1196,

        //Cata Dungeons
        Halls_of_Origination = 4945,
        Zul____Gurub = 1977,
        End_Time = 5789,
        Zul____Aman = 3805,
        Well_of_Eternity = 5788,
        Hour_of_Twilight = 5844,
        Grim_Batol = 4950,
        Lost_City_of_the_Tol____vir = 5396,
        The_Vortex_Pinnacle = 5035,
        The_Stonecore = 5088,
        Blackrock_Caverns = 4926,
        Throne_of_the_Tides = 5004,

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
        Nagrand______2 = 6755,
        Spires_of_Arak = 6722,
        Talador = 6662,
        Gorgrond = 6721,
        Frostfire_Ridge = 6720,
        Shadowmoon_Valley______2 = 6719,
        Frostwall = 7004,
        Defense_of_Karabor = 7083,
        Lunarfall = 7078,
        Shattrath_City = 6980,


        //Legion Zones
        Dalaran______2 = 7502,
        Suramar = 7637,
        Azsuna = 7334,
        Highmountain = 7503,
        Val____sharah = 7558,
        Stormheim = 7541,
        Thunder_Totem = 7731,
        Chamber_of_Shadows______2 = 8012,
        Azsuna______2 = 8000,
        The_Greater_Sea = 8053,
        Broken_Shore = 7543,
        Shield____s_Rest = 7744,
        The_Great_Sea = 7656,
        Stormheim______2 = 7921,
        Helmouth_Shallows = 7830,
        Suramar______2 = 7767,
        Thal____dranath = 8054,
        The_Great_Sea______2 = 8445,
        Eye_of_Azshara______2 = 7578,

        //Legion Raids
        The_Emerald_Nightmare = 8026,
        The_Nighthold = 8025,

        //Legion Dungeons
        The_Arcway = 7855,
        Vault_of_the_Wardens = 7787,
        Black_Rook_Hold = 7805,
        Court_of_Stars = 8079,
        Hellmouth_Cliffs = 7812,
        Assault_on_Violet_Hold = 7996,
        Eye_of_Azshara = 8040,
        Darkheart_Thicket = 7673,
        Neltharion____s_Lair = 7546,
        Halls_of_Valor = 7672,
        Sword_of_Dawn = 8124,

        //Legion Scenarios + Artifacts
        The_Arcway______2 = 8423,
        Gloaming_Reef = 8017,
        The_Cove_of_Nashal = 7658,
        Broken_Shore______2 = 7534,
        Rescue_Koltira = 8250,
        Tol_Barad______2 = 8309,
        Realm_of_the_Mage_Hunter = 8205,
        Karazhan______2 = 7969,
        Karazhan______3 = 8265,
        Temple_of_the_White_Tiger_Flight_Bounds = 8451,
        The_Maelstrom______2 = 8046,
        Abyssal_Maw = 8106,
        Sanctum_of_Light______2 = 8347,
        Temple_of_the_Jade_Serpent______2 = 8262,
        Shadowgore_Citadel = 8142,
        Black_Temple______2 = 8239,
        Ursoc___s_Lair = 7974,
        Tirisfal_Glades______2 = 8044,
        The_Beyond = 8094,
        Broken_Shore______3 = 7796,
        Deepholm______2 = 7955,
        Dreadscar_Rift______2 = 7918,
        Icecrown_Citadel______2 = 7695,
        Niskara = 7737,
        Skywall______2 = 7960,

        //Legion Class Halls
        The_Maelstrom = 7745,
        Acherus___The_Ebon_Hold = 7679,
        Dreadscar_Rift = 7875,
        The_Dreamgrove = 7846,
        Hall_of_the_Guardian = 7879,
        The_Fel_Hammer = 8023,
        Chamber_of_Shadows = 8012,
        Netherlight_Temple = 7834,
        Sanctum_of_Light = 7638,
        Skyhold = 7813,
        Temple_of_Five_Dawns = 7903,
        Trueshot_Lodge = 7877

    };
}
