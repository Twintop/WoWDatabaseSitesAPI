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
    }

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
    }

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
    }

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
    }

    public enum ArmorSubClass
    {
        Cloth = 1,
        Leather = 2,
        Mail = 3,
        Plate = 4
    }

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
    }

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
