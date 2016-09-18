using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoWDatabaseSitesAPI.Framework.Core;

namespace WoWDatabaseSitesAPI
{
    public class Utility
    {
        public static string StripNonCommentTagsCharArray(string source)
        {
            if (string.IsNullOrWhiteSpace(source))
            {
                return string.Empty;
            }
            else
            {
                char[] array = new char[source.Length];
                int arrayIndex = 0;
                int inside = 0;
                for (int i = 0; i < source.Length; i++)
                {
                    char let = source[i];
                    if (let == '<')
                    {
                        inside = 1;
                        continue;
                    }
                    if (let == '>')
                    {
                        if (inside == 2)
                        {
                            array[arrayIndex] = '|';
                            arrayIndex++;
                        }
                        inside = 0;
                        continue;
                    }
                    if (let == '!')
                    {
                        inside = 2;
                    }
                    if (inside != 1)
                    {
                        array[arrayIndex] = let;
                        arrayIndex++;
                    }
                }
                return new string(array, 0, arrayIndex);
            }
        }

        public static bool IsZoneRaid(Zones zone)
        {
            switch (zone)
            {
                //WoD
                case Zones.Highmaul:
                case Zones.Blackrock_Foundry:
                case Zones.Hellfire_Citadel:
                //Legion
                case Zones.The_Emerald_Nightmare:
                case Zones.The_Nighthold:
                    return true;
                default:
                    return false;
            }
        }

        public static bool IsZoneDungeon(Zones zone)
        {
            switch (zone)
            {
                //TBC
                case Zones.Auchindoun___Auchenai_Crypts:
                case Zones.Auchindoun___Mana__Tombs:
                case Zones.Auchindoun___Sethekk_Halls:
                case Zones.Auchindoun___Shadow_Labyrinth:
                case Zones.Caverns_of_Time___Old_Hillsbrad_Foothills:
                case Zones.Caverns_of_Time___The_Black_Morass:
                case Zones.Coilfang_Reservoir___The_Slave_Pens:
                case Zones.Coilfang_Reservoir___The_Steamvault:
                case Zones.Coilfang_Reservoir___The_Underbog:
                case Zones.Hellfire_Citadel___Hellfire_Ramparts:
                case Zones.Hellfire_Citadel___The_Blood_Furnace:
                case Zones.Hellfire_Citadel___The_Shattered_Halls:
                case Zones.Magister____s_Terrace:
                case Zones.Tempest_Keep___The_Arcatraz:
                case Zones.Tempest_Keep___The_Botanica:
                case Zones.Tempest_Keep___The_Mechanar:
                //WotLK
                case Zones.Azjol__Nerub___Ahn____kahet___The_Old_Kingdom:
                case Zones.Azjol__Nerub___Azjol__Nerub:
                case Zones.Caverns_of_Time___The_Culling_of_Stratholme:
                case Zones.Crusaders_____Coliseum___Trial_of_the_Champion:
                case Zones.Drak____Tharon_Keep:
                case Zones.Gundrak:
                case Zones.Icecrown_Citadel___Halls_of_Reflection:
                case Zones.Icecrown_Citadel___Pit_of_Saron:
                case Zones.Icecrown_Citadel___The_Forge_of_Souls:
                case Zones.The_Nexus___The_Nexus:
                case Zones.The_Nexus___The_Oculus:
                case Zones.Ulduar___Halls_of_Lightning:
                case Zones.Ulduar___Halls_of_Stone:
                case Zones.Utgarde_Keep___Utgard_Pinnacle:
                case Zones.Utgarde_Keep___Utgarde_Keep:
                //Cata
                case Zones.Halls_of_Origination:
                case Zones.Zul____Aman:
                case Zones.End_Time:
                case Zones.Zul____Gurub:
                case Zones.Well_of_Eternity:
                case Zones.Hour_of_Twilight:
                case Zones.Grim_Batol:
                case Zones.Lost_City_of_the_Tol____vir:
                case Zones.The_Vortex_Pinnacle:
                case Zones.The_Stonecore:
                case Zones.Blackrock_Caverns:
                case Zones.Throne_of_the_Tides:
                //MoP
                //WoD
                case Zones.Shadowmoon_Burial_Grounds:
                case Zones.The_Everbloom:
                case Zones.Grimrail_Depot:
                case Zones.Upper_Blackrock_Spire:
                case Zones.Skyreach:
                case Zones.Auchindoun:
                case Zones.Iron_Docks:
                case Zones.Bloodmaul_Slag_Mines:
                //Legion
                case Zones.The_Arcway:
                case Zones.Vault_of_the_Wardens:
                case Zones.Black_Rook_Hold:
                case Zones.Court_of_Stars:
                case Zones.Hellmouth_Cliffs:
                case Zones.Assault_on_Violet_Hold:
                case Zones.Eye_of_Azshara:
                case Zones.Darkheart_Thicket:
                case Zones.Neltharion____s_Lair:
                case Zones.Halls_of_Valor:
                case Zones.Sword_of_Dawn:
                    return true;
                default:
                    return false;
            }
        }

        public static bool IsZoneScenario(Zones zone)
        {
            switch (zone)
            {
                //WoD
                case Zones.The_Trial_of_Faith:
                //Legion
                case Zones.The_Arcway______2:
                case Zones.Gloaming_Reef:
                case Zones.The_Cove_of_Nashal:
                case Zones.Broken_Shore______2:
                case Zones.Rescue_Koltira:
                case Zones.Tol_Barad______2:
                case Zones.Realm_of_the_Mage_Hunter:
                case Zones.Karazhan______2:
                case Zones.Karazhan______3:
                case Zones.Temple_of_the_White_Tiger_Flight_Bounds:
                case Zones.The_Maelstrom______2:
                case Zones.Abyssal_Maw:
                case Zones.Sanctum_of_Light______2:
                case Zones.Temple_of_the_Jade_Serpent______2:
                case Zones.Shadowgore_Citadel:
                case Zones.Black_Temple______2:
                case Zones.Ursoc___s_Lair:
                case Zones.Tirisfal_Glades______2:
                case Zones.The_Beyond:
                case Zones.Broken_Shore______3:
                case Zones.Deepholm______2:
                case Zones.Dreadscar_Rift______2:
                case Zones.Icecrown_Citadel______2:
                case Zones.Niskara:
                case Zones.Skywall______2:
                    return true;
                default:
                    return false;
            }
        }

        public static bool IsZoneWorldZone(Zones zone)
        {
            switch (zone)
            {
                //WoD
                case Zones.Tanaan_Jungle:
                case Zones.Faralohn:
                case Zones.Ashran:
                case Zones.Nagrand______2:
                case Zones.Spires_of_Arak:
                case Zones.Talador:
                case Zones.Gorgrond:
                case Zones.Frostfire_Ridge:
                case Zones.Shadowmoon_Valley______2:
                case Zones.Frostwall:
                case Zones.Defense_of_Karabor:
                case Zones.Lunarfall:
                case Zones.Shattrath_City:
                //Legion
                case Zones.Dalaran______2:
                case Zones.Suramar:
                case Zones.Azsuna:
                case Zones.Highmountain:
                case Zones.Val____sharah:
                case Zones.Stormheim:
                case Zones.Thunder_Totem:
                case Zones.Chamber_of_Shadows:
                case Zones.Azsuna______2:
                case Zones.The_Greater_Sea:
                case Zones.Broken_Shore:
                case Zones.Shield____s_Rest:
                case Zones.The_Great_Sea:
                case Zones.Stormheim______2:
                case Zones.Helmouth_Shallows:
                case Zones.Suramar______2:
                case Zones.Thal____dranath:
                case Zones.The_Great_Sea______2:
                case Zones.Eye_of_Azshara______2:
                    return true;
                default:
                    return false;
            }
        }

        public static bool IsZoneTBCZone(Zones zone)
        {
            switch (zone)
            {
                //Dungeons
                case Zones.Auchindoun___Auchenai_Crypts:
                case Zones.Auchindoun___Mana__Tombs:
                case Zones.Auchindoun___Sethekk_Halls:
                case Zones.Auchindoun___Shadow_Labyrinth:
                case Zones.Caverns_of_Time___Old_Hillsbrad_Foothills:
                case Zones.Caverns_of_Time___The_Black_Morass:
                case Zones.Coilfang_Reservoir___The_Slave_Pens:
                case Zones.Coilfang_Reservoir___The_Steamvault:
                case Zones.Coilfang_Reservoir___The_Underbog:
                case Zones.Hellfire_Citadel___Hellfire_Ramparts:
                case Zones.Hellfire_Citadel___The_Blood_Furnace:
                case Zones.Hellfire_Citadel___The_Shattered_Halls:
                case Zones.Magister____s_Terrace:
                case Zones.Tempest_Keep___The_Arcatraz:
                case Zones.Tempest_Keep___The_Botanica:
                case Zones.Tempest_Keep___The_Mechanar:
                    return true;
                default:
                    return false;
            }
        }

        public static bool IsZoneWotLKZone(Zones zone)
        {
            switch (zone)
            {
                //Dungeons
                case Zones.Azjol__Nerub___Ahn____kahet___The_Old_Kingdom:
                case Zones.Azjol__Nerub___Azjol__Nerub:
                case Zones.Caverns_of_Time___The_Culling_of_Stratholme:
                case Zones.Crusaders_____Coliseum___Trial_of_the_Champion:
                case Zones.Drak____Tharon_Keep:
                case Zones.Gundrak:
                case Zones.Icecrown_Citadel___Halls_of_Reflection:
                case Zones.Icecrown_Citadel___Pit_of_Saron:
                case Zones.Icecrown_Citadel___The_Forge_of_Souls:
                case Zones.The_Nexus___The_Nexus:
                case Zones.The_Nexus___The_Oculus:
                case Zones.Ulduar___Halls_of_Lightning:
                case Zones.Ulduar___Halls_of_Stone:
                case Zones.Utgarde_Keep___Utgard_Pinnacle:
                case Zones.Utgarde_Keep___Utgarde_Keep:
                    return true;
                default:
                    return false;
            }
        }

        public static bool IsZoneCataZone(Zones zone)
        {
            switch (zone)
            {
                case Zones.Halls_of_Origination:
                case Zones.Zul____Aman:
                case Zones.End_Time:
                case Zones.Zul____Gurub:
                case Zones.Well_of_Eternity:
                case Zones.Hour_of_Twilight:
                case Zones.Grim_Batol:
                case Zones.Lost_City_of_the_Tol____vir:
                case Zones.The_Vortex_Pinnacle:
                case Zones.The_Stonecore:
                case Zones.Blackrock_Caverns:
                case Zones.Throne_of_the_Tides:
                    return true;
                default:
                    return false;
            }
        }

        public static bool IsZoneWoDZone(Zones zone)
        {
            switch (zone)
            {
                //Zones
                case Zones.Tanaan_Jungle:
                case Zones.Faralohn:
                case Zones.Ashran:
                case Zones.Nagrand______2:
                case Zones.Spires_of_Arak:
                case Zones.Talador:
                case Zones.Gorgrond:
                case Zones.Frostfire_Ridge:
                case Zones.Shadowmoon_Valley______2:
                case Zones.Frostwall:
                case Zones.Defense_of_Karabor:
                case Zones.Lunarfall:
                case Zones.Shattrath_City:
                //Dungeons
                case Zones.Shadowmoon_Burial_Grounds:
                case Zones.The_Everbloom:
                case Zones.Grimrail_Depot:
                case Zones.Upper_Blackrock_Spire:
                case Zones.Skyreach:
                case Zones.Auchindoun:
                case Zones.Iron_Docks:
                case Zones.Bloodmaul_Slag_Mines:
                //Raids
                case Zones.Highmaul:
                case Zones.Blackrock_Foundry:
                case Zones.Hellfire_Citadel:
                //Scenarios
                case Zones.The_Trial_of_Faith:
                    return true;
                default:
                    return false;
            }
        }

        public static bool IsZoneLegionZone(Zones zone)
        {
            switch (zone)
            {
                //Zones
                case Zones.Dalaran______2:
                case Zones.Suramar:
                case Zones.Azsuna:
                case Zones.Highmountain:
                case Zones.Val____sharah:
                case Zones.Stormheim:
                case Zones.Thunder_Totem:
                case Zones.Azsuna______2:
                case Zones.The_Greater_Sea:
                case Zones.Broken_Shore:
                case Zones.Shield____s_Rest:
                case Zones.The_Great_Sea:
                case Zones.Stormheim______2:
                case Zones.Helmouth_Shallows:
                case Zones.Suramar______2:
                case Zones.Thal____dranath:
                case Zones.The_Great_Sea______2:
                case Zones.Eye_of_Azshara______2:
                //Scenarios
                case Zones.The_Arcway______2:
                case Zones.Gloaming_Reef:
                case Zones.The_Cove_of_Nashal:
                case Zones.Broken_Shore______2:
                case Zones.Rescue_Koltira:
                case Zones.Tol_Barad______2:
                case Zones.Realm_of_the_Mage_Hunter:
                case Zones.Karazhan______2:
                case Zones.Karazhan______3:
                case Zones.Temple_of_the_White_Tiger_Flight_Bounds:
                case Zones.The_Maelstrom______2:
                case Zones.Abyssal_Maw:
                case Zones.Sanctum_of_Light______2:
                case Zones.Temple_of_the_Jade_Serpent______2:
                case Zones.Shadowgore_Citadel:
                case Zones.Black_Temple______2:
                case Zones.Ursoc___s_Lair:
                case Zones.Tirisfal_Glades______2:
                case Zones.The_Beyond:
                case Zones.Broken_Shore______3:
                case Zones.Deepholm______2:
                case Zones.Dreadscar_Rift______2:
                case Zones.Icecrown_Citadel______2:
                case Zones.Niskara:
                case Zones.Skywall______2:
                //Dungeons
                case Zones.The_Arcway:
                case Zones.Vault_of_the_Wardens:
                case Zones.Black_Rook_Hold:
                case Zones.Court_of_Stars:
                case Zones.Hellmouth_Cliffs:
                case Zones.Assault_on_Violet_Hold:
                case Zones.Eye_of_Azshara:
                case Zones.Darkheart_Thicket:
                case Zones.Neltharion____s_Lair:
                case Zones.Halls_of_Valor:
                case Zones.Sword_of_Dawn:
                //Raids
                case Zones.The_Emerald_Nightmare:
                case Zones.The_Nighthold:
                //Class Halls
                case Zones.The_Maelstrom:
                case Zones.Acherus___The_Ebon_Hold:
                case Zones.Dreadscar_Rift:
                case Zones.The_Dreamgrove:
                case Zones.Hall_of_the_Guardian:
                case Zones.The_Fel_Hammer:
                case Zones.Chamber_of_Shadows:
                case Zones.Netherlight_Temple:
                case Zones.Sanctum_of_Light:
                case Zones.Skyhold:
                case Zones.Temple_of_Five_Dawns:
                case Zones.Trueshot_Lodge:
                    return true;
                default:
                    return false;
            }
        }

        public static bool IsZoneLegionClassHall(Zones zone)
        {
            switch (zone)
            {
                case Zones.The_Maelstrom:
                case Zones.Acherus___The_Ebon_Hold:
                case Zones.Dreadscar_Rift:
                case Zones.The_Dreamgrove:
                case Zones.Hall_of_the_Guardian:
                case Zones.The_Fel_Hammer:
                case Zones.Chamber_of_Shadows:
                case Zones.Netherlight_Temple:
                case Zones.Sanctum_of_Light:
                case Zones.Skyhold:
                case Zones.Temple_of_Five_Dawns:
                case Zones.Trueshot_Lodge:
                    return true;
                default:
                    return false;
            }
        }
    }
}
