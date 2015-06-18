using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoWHeadXMLExtractor.Framework.Core;

namespace WoWHeadXMLExtractor
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
                case Zones.Highmaul:
                case Zones.Blackrock_Foundry:
                case Zones.Hellfire_Citadel:
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
                    return true;
                default:
                    return false;
            }
        }

        public static bool IsZoneScenario(Zones zone)
        {
            switch (zone)
            {
                case Zones.The_Trial_of_Faith:
                    return true;
                default:
                    return false;
            }
        }

        public static bool IsZoneWorldZone(Zones zone)
        {
            switch (zone)
            {
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
    }
}
