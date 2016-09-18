using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;
using WoWDatabaseSitesAPI.BusinessLogic;
using WoWDatabaseSitesAPI.Framework;
using WoWDatabaseSitesAPI.Framework.Core;
using WoWDatabaseSitesAPI.Framework.WoWHeadXML;
using WoWDatabaseSitesAPI.Services;

namespace WoWDatabaseSitesAPI.Services
{
    public class WowheadXMLItemService : WowheadXMLObject
    {
        #region Singleton Implementation

        private static WowheadXMLItemService _Service;

        public static WowheadXMLItemService Provider
        {
            get
            {
                if (_Service == null)
                {
                    _Service = new WowheadXMLItemService();
                }
                return _Service;
            }
        }

        #endregion

        #region Private Constructor

        private WowheadXMLItemService() { }

        #endregion

        #region Public Methods

        public WowheadXMLItem ParseItemXML(XmlDocument rawXML, int ParseSource = 2)
        {
            WowheadXMLItem parsedItem = CreateObject(rawXML, ParseSource);

            return parsedItem;
        }

        protected WowheadXMLItem CreateObject(XmlDocument itemXML, int ParseSource = 2) // <= 0 = JSON only, 1 = Parse from htmlTooltip only, >= 2 = Both
        {
            WowheadXMLItem record = new WowheadXMLItem();
            string xml = itemXML.InnerXml.ToString();
            StringReader sreader = new StringReader(xml);
            XmlReader xmlReader = XmlReader.Create(sreader);

            XmlRootAttribute xRoot = new XmlRootAttribute();
            xRoot.ElementName = "wowhead";
            xRoot.IsNullable = true;

            XmlSerializer serializer = new XmlSerializer(typeof(WowheadXMLItem), xRoot);

            record = (WowheadXMLItem)serializer.Deserialize(xmlReader);

            string firstMatch = string.Empty;

            if (record.item != null)
            {
                record.StrippedHtmlString = Utility.StripNonCommentTagsCharArray(record.item.htmlTooltip);

                int indexStart,
                    indexEnd;

                if (ParseSource != 1) //Parse from htmlTooltip
                {
                    //Armor
                    try
                    {
                        firstMatch = "!--amr--|";
                        indexStart = record.StrippedHtmlString.IndexOf(firstMatch, 0) + firstMatch.Length;
                        indexEnd = record.StrippedHtmlString.IndexOf(" Armor", indexStart);

                        if (indexStart >= firstMatch.Length && indexEnd >= firstMatch.Length)
                        {
                            record.TooltipData.Armor = Convert.ToInt32(record.StrippedHtmlString.Substring(indexStart, (indexEnd - indexStart)));
                        }
                    }
                    catch { }

                    //AgilityStrengthIntellect
                    try
                    {
                        firstMatch = "!--stat71--|+";
                        indexStart = record.StrippedHtmlString.IndexOf(firstMatch, 0) + firstMatch.Length;
                        indexEnd = record.StrippedHtmlString.IndexOf(" [Agility or Strength or Intellect]", indexStart);

                        if (indexStart >= firstMatch.Length && indexEnd >= firstMatch.Length)
                        {
                            record.TooltipData.AgilityStrengthIntellect = Convert.ToInt32(record.StrippedHtmlString.Substring(indexStart, (indexEnd - indexStart)));
                        }
                    }
                    catch { }

                    //AgilityStrength
                    try
                    {
                        firstMatch = "!--stat72--|+";
                        indexStart = record.StrippedHtmlString.IndexOf(firstMatch, 0) + firstMatch.Length;
                        indexEnd = record.StrippedHtmlString.IndexOf(" [Agility or Strength]", indexStart);

                        if (indexStart >= firstMatch.Length && indexEnd >= firstMatch.Length)
                        {
                            record.TooltipData.AgilityStrength = Convert.ToInt32(record.StrippedHtmlString.Substring(indexStart, (indexEnd - indexStart)));
                        }
                    }
                    catch { }

                    //AgilityIntellect
                    try
                    {
                        firstMatch = "!--stat73--|+";
                        indexStart = record.StrippedHtmlString.IndexOf(firstMatch, 0) + firstMatch.Length;
                        indexEnd = record.StrippedHtmlString.IndexOf(" [Agility or Intellect]", indexStart);

                        if (indexStart >= firstMatch.Length && indexEnd >= firstMatch.Length)
                        {
                            record.TooltipData.AgilityIntellect = Convert.ToInt32(record.StrippedHtmlString.Substring(indexStart, (indexEnd - indexStart)));
                        }
                    }
                    catch { }

                    //StrengthIntellect
                    try
                    {
                        firstMatch = "!--stat74--|+";
                        indexStart = record.StrippedHtmlString.IndexOf(firstMatch, 0) + firstMatch.Length;
                        indexEnd = record.StrippedHtmlString.IndexOf(" [Strength or Intellect]", indexStart);

                        if (indexStart >= firstMatch.Length && indexEnd >= firstMatch.Length)
                        {
                            record.TooltipData.StrengthIntellect = Convert.ToInt32(record.StrippedHtmlString.Substring(indexStart, (indexEnd - indexStart)));
                        }
                    }
                    catch { }

                    //Intellect
                    try
                    {
                        firstMatch = "!--stat5--|+";
                        indexStart = record.StrippedHtmlString.IndexOf(firstMatch, 0) + firstMatch.Length;
                        indexEnd = record.StrippedHtmlString.IndexOf(" Intellect", indexStart);

                        if (indexStart >= firstMatch.Length && indexEnd >= firstMatch.Length)
                        {
                            record.TooltipData.Intellect = Convert.ToInt32(record.StrippedHtmlString.Substring(indexStart, (indexEnd - indexStart)));
                        }
                    }
                    catch { }

                    //Strength
                    try
                    {
                        firstMatch = "!--stat4--|+";
                        indexStart = record.StrippedHtmlString.IndexOf(firstMatch, 0) + firstMatch.Length;
                        indexEnd = record.StrippedHtmlString.IndexOf(" Strength", indexStart);

                        if (indexStart >= firstMatch.Length && indexEnd >= firstMatch.Length)
                        {
                            record.TooltipData.Strength = Convert.ToInt32(record.StrippedHtmlString.Substring(indexStart, (indexEnd - indexStart)));
                        }
                    }
                    catch { }

                    //Agility
                    try
                    {
                        firstMatch = "!--stat3--|+";
                        indexStart = record.StrippedHtmlString.IndexOf(firstMatch, 0) + firstMatch.Length;
                        indexEnd = record.StrippedHtmlString.IndexOf(" Agility", indexStart);

                        if (indexStart >= firstMatch.Length && indexEnd >= firstMatch.Length)
                        {
                            record.TooltipData.Agility = Convert.ToInt32(record.StrippedHtmlString.Substring(indexStart, (indexEnd - indexStart)));
                        }
                    }
                    catch { }

                    //Crit
                    try
                    {
                        firstMatch = "!--rtg32--|";
                        indexStart = record.StrippedHtmlString.IndexOf(firstMatch, 0) + firstMatch.Length;
                        indexEnd = record.StrippedHtmlString.IndexOf(" Critical Strike", indexStart);

                        if (indexStart >= firstMatch.Length && indexEnd >= firstMatch.Length)
                        {
                            record.TooltipData.Crit = Convert.ToInt32(record.StrippedHtmlString.Substring(indexStart, (indexEnd - indexStart)));
                        }
                    }
                    catch { }

                    //Haste
                    try
                    {
                        firstMatch = "!--rtg36--|";
                        indexStart = record.StrippedHtmlString.IndexOf(firstMatch, 0) + firstMatch.Length;
                        indexEnd = record.StrippedHtmlString.IndexOf(" Haste", indexStart);

                        if (indexStart >= firstMatch.Length && indexEnd >= firstMatch.Length)
                        {
                            record.TooltipData.Haste = Convert.ToInt32(record.StrippedHtmlString.Substring(indexStart, (indexEnd - indexStart)));
                        }
                    }
                    catch { }

                    //Mastery
                    try
                    {
                        firstMatch = "!--rtg49--|";
                        indexStart = record.StrippedHtmlString.IndexOf(firstMatch, 0) + firstMatch.Length;
                        indexEnd = record.StrippedHtmlString.IndexOf(" Mastery", indexStart);

                        if (indexStart >= firstMatch.Length && indexEnd >= firstMatch.Length)
                        {
                            record.TooltipData.Mastery = Convert.ToInt32(record.StrippedHtmlString.Substring(indexStart, (indexEnd - indexStart)));
                        }
                    }
                    catch { }

                    //Versatility
                    try
                    {
                        firstMatch = "!--rtg40--|";
                        indexStart = record.StrippedHtmlString.IndexOf(firstMatch, 0) + firstMatch.Length;
                        indexEnd = record.StrippedHtmlString.IndexOf(" Versatility", indexStart);

                        if (indexStart >= firstMatch.Length && indexEnd >= firstMatch.Length)
                        {
                            record.TooltipData.Versatility = Convert.ToInt32(record.StrippedHtmlString.Substring(indexStart, (indexEnd - indexStart)));
                        }
                    }
                    catch { }

                    //Stamina
                    try
                    {
                        firstMatch = "!--stat7--|+";
                        indexStart = record.StrippedHtmlString.IndexOf(firstMatch, 0) + firstMatch.Length;
                        indexEnd = record.StrippedHtmlString.IndexOf(" Stamina", indexStart);

                        if (indexStart >= firstMatch.Length && indexEnd >= firstMatch.Length)
                        {
                            record.TooltipData.Stamina = Convert.ToInt32(record.StrippedHtmlString.Substring(indexStart, (indexEnd - indexStart)));
                        }
                    }
                    catch { }

                    //SpellPower
                    try
                    {
                        firstMatch = "!--rtg45--|";
                        indexStart = record.StrippedHtmlString.IndexOf(firstMatch, 0) + firstMatch.Length;
                        indexEnd = record.StrippedHtmlString.IndexOf(" Spell Power", indexStart);

                        if (indexStart >= firstMatch.Length && indexEnd >= firstMatch.Length)
                        {
                            record.TooltipData.SpellPower = Convert.ToInt32(record.StrippedHtmlString.Substring(indexStart, (indexEnd - indexStart)));
                        }
                    }
                    catch { }

                    //Item Description
                    try
                    {
                        firstMatch = "!--ndstart--|";
                        indexStart = record.StrippedHtmlString.IndexOf(firstMatch, 0) + firstMatch.Length;
                        indexEnd = record.StrippedHtmlString.IndexOf("!--ndend--|", indexStart);

                        if (indexStart >= firstMatch.Length && indexEnd >= firstMatch.Length)
                        {
                            record.TooltipData.Description = record.StrippedHtmlString.Substring(indexStart, (indexEnd - indexStart));
                        }
                    }
                    catch { }

                    //Item Level
                    try
                    {
                        firstMatch = "!--ilvl--|";
                        indexStart = record.StrippedHtmlString.IndexOf(firstMatch, 0) + firstMatch.Length;
                        indexEnd = record.StrippedHtmlString.IndexOf("!", indexStart);

                        if (indexStart >= firstMatch.Length && indexEnd >= firstMatch.Length)
                        {
                            record.TooltipData.ItemLevel = Convert.ToInt32(record.StrippedHtmlString.Substring(indexStart, (indexEnd - indexStart)));
                        }
                    }
                    catch { }

                    //Source + Drop Chance
                    try
                    {
                        firstMatch = "Dropped by: ";
                        indexStart = record.StrippedHtmlString.IndexOf(firstMatch, 0) + firstMatch.Length;
                        indexEnd = record.StrippedHtmlString.IndexOf("!", indexStart);

                        if (indexStart >= firstMatch.Length && indexEnd >= firstMatch.Length)
                        {
                            try
                            {
                                firstMatch = "Drop Chance: ";
                                int indexStart2 = record.StrippedHtmlString.IndexOf(firstMatch, indexStart) + firstMatch.Length;
                                int indexEnd2 = record.StrippedHtmlString.IndexOf("%", indexStart2);

                                if (indexStart2 >= indexStart + firstMatch.Length && indexEnd2 >= indexStart + firstMatch.Length)
                                {
                                    record.TooltipData.DropChance = Convert.ToDouble(record.StrippedHtmlString.Substring(indexStart2, (indexEnd2 - indexStart2)));
                                    indexEnd = indexStart2 - firstMatch.Length;
                                }
                            }
                            catch { }

                            record.TooltipData.Source = record.StrippedHtmlString.Substring(indexStart, (indexEnd - indexStart));
                        }
                    }
                    catch { }

                }

                if (ParseSource >= 1) //pull from jsonEquip
                {
                    record.itemJsonData = JsonConvert.DeserializeObject<itemJson>("{" + record.item.json + "}");
                    record.itemJsonEquipData = JsonConvert.DeserializeObject<itemJsonEquip>("{" + record.item.jsonEquip + "}");
                }
            }

            return record;
        }

        #endregion
    }
}
