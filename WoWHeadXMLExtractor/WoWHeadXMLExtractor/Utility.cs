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
                case Zones.Nagrand__2:
                case Zones.Spires_of_Arak:
                case Zones.Talador:
                case Zones.Gorgrond:
                case Zones.Frostfire_Ridge:
                case Zones.Shadowmoon_Valley__2:
                case Zones.Frostwall:
                case Zones.Defense_of_Karabor:
                case Zones.Lunarfall:
                case Zones.Shattrath_City:
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
                case Zones.Nagrand__2:
                case Zones.Spires_of_Arak:
                case Zones.Talador:
                case Zones.Gorgrond:
                case Zones.Frostfire_Ridge:
                case Zones.Shadowmoon_Valley__2:
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
