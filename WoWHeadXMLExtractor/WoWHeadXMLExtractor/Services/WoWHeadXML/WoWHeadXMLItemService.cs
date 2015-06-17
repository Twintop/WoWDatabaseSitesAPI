using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;
using WoWHeadXMLExtractor.BusinessLogic;
using WoWHeadXMLExtractor.Framework;
using WoWHeadXMLExtractor.Framework.Core;
using WoWHeadXMLExtractor.Framework.WoWHeadXML;
using WoWHeadXMLExtractor.Services;

namespace WoWHeadXMLExtractor.Services
{
    public class WoWHeadXMLItemService : WoWHeadXMLObject
    {
        #region Singleton Implementation

        private static WoWHeadXMLItemService _Service;

        public static WoWHeadXMLItemService Provider
        {
            get
            {
                if (_Service == null)
                {
                    _Service = new WoWHeadXMLItemService();
                }
                return _Service;
            }
        }

        #endregion

        #region Private Constructor

        private WoWHeadXMLItemService() { }

        #endregion

        #region Public Methods

        public WoWHeadXMLItem ParseItemXML(XmlDocument rawXML, int ParseSource = 2)
        {
            WoWHeadXMLItem parsedItem = CreateObject(rawXML, ParseSource);

            return parsedItem;
        }

        protected WoWHeadXMLItem CreateObject(XmlDocument itemXML, int ParseSource = 2) // <= 0 = JSON only, 1 = Parse from htmlTooltip only, >= 2 = Both
        {
            WoWHeadXMLItem record = new WoWHeadXMLItem();
            string xml = itemXML.InnerXml.ToString();
            StringReader sreader = new StringReader(xml);
            XmlReader xmlReader = XmlReader.Create(sreader);

            XmlRootAttribute xRoot = new XmlRootAttribute();
            xRoot.ElementName = "wowhead";
            xRoot.IsNullable = true;

            XmlSerializer serializer = new XmlSerializer(typeof(WoWHeadXMLItem), xRoot);

            record = (WoWHeadXMLItem)serializer.Deserialize(xmlReader);

            record.StrippedHtmlString = Utility.StripNonCommentTagsCharArray(record.item.htmlTooltip);            

            int indexStart,
                indexEnd;

            if (ParseSource > 0) //Parse from htmlTooltip
            {
                //Armor
                try
                {
                    indexStart = record.StrippedHtmlString.IndexOf("!--amr--|", 0) + 9;
                    indexEnd = record.StrippedHtmlString.IndexOf(" Armor", indexStart);

                    if (indexStart >= 0 && indexEnd >= 0)
                    {
                        record.TooltipData.Armor = Convert.ToInt32(record.StrippedHtmlString.Substring(indexStart, (indexEnd - indexStart)));
                    }
                }
                catch { }

                //Bonus Armor
                try
                {
                    indexStart = record.StrippedHtmlString.IndexOf("!--rtg50--|", 0) + 11;
                    indexEnd = record.StrippedHtmlString.IndexOf(" Bonus Armor", indexStart);

                    if (indexStart >= 0 && indexEnd >= 0)
                    {
                        record.TooltipData.BonusArmor = Convert.ToInt32(record.StrippedHtmlString.Substring(indexStart, (indexEnd - indexStart)));
                    }
                }
                catch { }

                //AgilityStrengthIntellect
                try
                {
                    indexStart = record.StrippedHtmlString.IndexOf("!--stat71--|+", 0) + 12;
                    indexEnd = record.StrippedHtmlString.IndexOf(" [Agility or Strength or Intellect]", indexStart);

                    if (indexStart >= 0 && indexEnd >= 0)
                    {
                        record.TooltipData.AgilityStrengthIntellect = Convert.ToInt32(record.StrippedHtmlString.Substring(indexStart, (indexEnd - indexStart)));
                    }
                }
                catch { }

                //AgilityStrength
                try
                {
                    indexStart = record.StrippedHtmlString.IndexOf("!--stat72--|+", 0) + 12;
                    indexEnd = record.StrippedHtmlString.IndexOf(" [Agility or Strength]", indexStart);

                    if (indexStart >= 0 && indexEnd >= 0)
                    {
                        record.TooltipData.AgilityStrength = Convert.ToInt32(record.StrippedHtmlString.Substring(indexStart, (indexEnd - indexStart)));
                    }
                }
                catch { }

                //AgilityIntellect
                try
                {
                    indexStart = record.StrippedHtmlString.IndexOf("!--stat73--|+", 0) + 12;
                    indexEnd = record.StrippedHtmlString.IndexOf(" [Agility or Intellect]", indexStart);

                    if (indexStart >= 0 && indexEnd >= 0)
                    {
                        record.TooltipData.AgilityIntellect = Convert.ToInt32(record.StrippedHtmlString.Substring(indexStart, (indexEnd - indexStart)));
                    }
                }
                catch { }

                //StrengthIntellect
                try
                {
                    indexStart = record.StrippedHtmlString.IndexOf("!--stat74--|+", 0) + 12;
                    indexEnd = record.StrippedHtmlString.IndexOf(" [Strength or Intellect]", indexStart);

                    if (indexStart >= 0 && indexEnd >= 0)
                    {
                        record.TooltipData.StrengthIntellect = Convert.ToInt32(record.StrippedHtmlString.Substring(indexStart, (indexEnd - indexStart)));
                    }
                }
                catch { }

                //Intellect
                try
                {
                    indexStart = record.StrippedHtmlString.IndexOf("!--stat5--|+", 0) + 12;
                    indexEnd = record.StrippedHtmlString.IndexOf(" Intellect", indexStart);

                    if (indexStart >= 0 && indexEnd >= 0)
                    {
                        record.TooltipData.Intellect = Convert.ToInt32(record.StrippedHtmlString.Substring(indexStart, (indexEnd - indexStart)));
                    }
                }
                catch { }

                //Strength
                try
                {
                    indexStart = record.StrippedHtmlString.IndexOf("!--stat4--|+", 0) + 12;
                    indexEnd = record.StrippedHtmlString.IndexOf(" Strength", indexStart);

                    if (indexStart >= 0 && indexEnd >= 0)
                    {
                        record.TooltipData.Strength = Convert.ToInt32(record.StrippedHtmlString.Substring(indexStart, (indexEnd - indexStart)));
                    }
                }
                catch { }

                //Agility
                try
                {
                    indexStart = record.StrippedHtmlString.IndexOf("!--stat3--|+", 0) + 12;
                    indexEnd = record.StrippedHtmlString.IndexOf(" Agility", indexStart);

                    if (indexStart >= 0 && indexEnd >= 0)
                    {
                        record.TooltipData.Agility = Convert.ToInt32(record.StrippedHtmlString.Substring(indexStart, (indexEnd - indexStart)));
                    }
                }
                catch { }

                //Crit
                try
                {
                    indexStart = record.StrippedHtmlString.IndexOf("!--rtg32--|", 0) + 11;
                    indexEnd = record.StrippedHtmlString.IndexOf(" Critical Strike", indexStart);

                    if (indexStart >= 0 && indexEnd >= 0)
                    {
                        record.TooltipData.Crit = Convert.ToInt32(record.StrippedHtmlString.Substring(indexStart, (indexEnd - indexStart)));
                    }
                }
                catch { }

                //Haste
                try
                {
                    indexStart = record.StrippedHtmlString.IndexOf("!--rtg36--|", 0) + 11;
                    indexEnd = record.StrippedHtmlString.IndexOf(" Haste", indexStart);

                    if (indexStart >= 0 && indexEnd >= 0)
                    {
                        record.TooltipData.Haste = Convert.ToInt32(record.StrippedHtmlString.Substring(indexStart, (indexEnd - indexStart)));
                    }
                }
                catch { }

                //Mastery
                try
                {
                    indexStart = record.StrippedHtmlString.IndexOf("!--rtg49--|", 0) + 11;
                    indexEnd = record.StrippedHtmlString.IndexOf(" Mastery", indexStart);

                    if (indexStart >= 0 && indexEnd >= 0)
                    {
                        record.TooltipData.Mastery = Convert.ToInt32(record.StrippedHtmlString.Substring(indexStart, (indexEnd - indexStart)));
                    }
                }
                catch { }

                //Multistrike
                try
                {
                    indexStart = record.StrippedHtmlString.IndexOf("!--rtg59--|", 0) + 11;
                    indexEnd = record.StrippedHtmlString.IndexOf(" Multistrike", indexStart);

                    if (indexStart >= 0 && indexEnd >= 0)
                    {
                        record.TooltipData.Multistrike = Convert.ToInt32(record.StrippedHtmlString.Substring(indexStart, (indexEnd - indexStart)));
                    }
                }
                catch { }

                //Versatility
                try
                {
                    indexStart = record.StrippedHtmlString.IndexOf("!--rtg40--|", 0) + 11;
                    indexEnd = record.StrippedHtmlString.IndexOf(" Versatility", indexStart);

                    if (indexStart >= 0 && indexEnd >= 0)
                    {
                        record.TooltipData.Versatility = Convert.ToInt32(record.StrippedHtmlString.Substring(indexStart, (indexEnd - indexStart)));
                    }
                }
                catch { }

                //Spirit
                try
                {
                    indexStart = record.StrippedHtmlString.IndexOf("!--rtg6--|", 0) + 10;
                    indexEnd = record.StrippedHtmlString.IndexOf(" Spirit", indexStart);

                    if (indexStart >= 0 && indexEnd >= 0)
                    {
                        record.TooltipData.Spirit = Convert.ToInt32(record.StrippedHtmlString.Substring(indexStart, (indexEnd - indexStart)));
                    }
                }
                catch { }

                //Stamina
                try
                {
                    indexStart = record.StrippedHtmlString.IndexOf("!--stat7--|+", 0) + 12;
                    indexEnd = record.StrippedHtmlString.IndexOf(" Stamina", indexStart);

                    if (indexStart >= 0 && indexEnd >= 0)
                    {
                        record.TooltipData.Stamina = Convert.ToInt32(record.StrippedHtmlString.Substring(indexStart, (indexEnd - indexStart)));
                    }
                }
                catch { }

                //SpellPower
                try
                {
                    indexStart = record.StrippedHtmlString.IndexOf("!--rtg45--|", 0) + 11;
                    indexEnd = record.StrippedHtmlString.IndexOf(" Spell Power", indexStart);

                    if (indexStart >= 0 && indexEnd >= 0)
                    {
                        record.TooltipData.SpellPower = Convert.ToInt32(record.StrippedHtmlString.Substring(indexStart, (indexEnd - indexStart)));
                    }
                }
                catch { }

                //Item Description
                try
                {
                    indexStart = record.StrippedHtmlString.IndexOf("!--ndstart--|", 0) + 13;
                    indexEnd = record.StrippedHtmlString.IndexOf("!--ndend--|", indexStart);

                    if (indexStart >= 0 && indexEnd >= 0)
                    {
                        record.TooltipData.Description = record.StrippedHtmlString.Substring(indexStart, (indexEnd - indexStart));
                    }
                }
                catch { }

                //Item Level
                try
                {
                    indexStart = record.StrippedHtmlString.IndexOf("!--ilvl--|", 0) + 10;
                    indexEnd = record.StrippedHtmlString.IndexOf("!", indexStart);

                    if (indexStart >= 0 && indexEnd >= 0)
                    {
                        record.TooltipData.ItemLevel = Convert.ToInt32(record.StrippedHtmlString.Substring(indexStart, (indexEnd - indexStart)));
                    }
                }
                catch { }

                //Source + Drop Chance
                try
                {
                    indexStart = record.StrippedHtmlString.IndexOf("Dropped by: ", 0) + 12;
                    indexEnd = record.StrippedHtmlString.IndexOf("!", indexStart);

                    if (indexStart >= 0 && indexEnd >= 0)
                    {
                        try
                        {
                            int indexStart2 = record.StrippedHtmlString.IndexOf("Drop Chance: ", indexStart) + 13;
                            int indexEnd2 = record.StrippedHtmlString.IndexOf("%", indexStart2);

                            if (indexStart2 >= indexStart && indexEnd2 >= indexStart)
                            {
                                record.TooltipData.DropChance = Convert.ToDouble(record.StrippedHtmlString.Substring(indexStart2, (indexEnd2 - indexStart2)));
                                indexEnd = indexStart2-13;
                            }
                        }
                        catch { }

                        record.TooltipData.Source = record.StrippedHtmlString.Substring(indexStart, (indexEnd - indexStart));
                    }
                }
                catch { }
                
            }

            if (ParseSource != 1) //pull from jsonEquip
            {
                record.itemJsonData = JsonConvert.DeserializeObject<itemJson>("{" + record.item.json + "}");
                record.itemJsonEquipData = JsonConvert.DeserializeObject<itemJsonEquip>("{" + record.item.jsonEquip + "}");
            }



            return record;
        }

        #endregion
    }
}
