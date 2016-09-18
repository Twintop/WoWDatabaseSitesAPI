using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WoWDatabaseSitesAPI;
using WoWDatabaseSitesAPI.BusinessLogic;
using WoWDatabaseSitesAPI.Framework;
using WoWDatabaseSitesAPI.Framework.Core;

namespace WoWHeadItems
{
    public partial class ExampleForm : Form
    {
        public ExampleForm()
        {
            InitializeComponent();
            this.AcceptButton = buttonGetXML;
        }

        private void buttonGetXML_Click(object sender, EventArgs e)
        {
            Item requestedItem = new Item();
            requestedItem = WDSAManager.Provider.Wowhead_GetItemDetailsByURL(Convert.ToInt32(wowhead_nudID.Value), wowhead_tbBonuses.Text, (WowheadSiteType) Enum.Parse(typeof(WowheadSiteType), wowhead_cbSite.Text, true), wowhead_cbParseSource.SelectedIndex);

            wowhead_textboxOutput.Clear();
            wowhead_textboxOutput.Text = "ID = " + requestedItem.WoWHeadXML.item.id.ToString()
                + Environment.NewLine + "Name = " + requestedItem.WoWHeadXML.Name
                + Environment.NewLine + "Description = " + requestedItem.WoWHeadXML.Description
                + Environment.NewLine + "Source = " + requestedItem.WoWHeadXML.Source
                + Environment.NewLine + "Drop Chance = " + requestedItem.WoWHeadXML.DropChance
                + Environment.NewLine + "Zone = " + requestedItem.WoWHeadXML.ZoneId + " - " + requestedItem.WoWHeadXML.ZoneName
                + Environment.NewLine + "\tWorld? = " + WoWDatabaseSitesAPI.Utility.IsZoneWorldZone(requestedItem.WoWHeadXML.ZoneEnum)
                + Environment.NewLine + "\tRaid? = " + WoWDatabaseSitesAPI.Utility.IsZoneRaid(requestedItem.WoWHeadXML.ZoneEnum)
                + Environment.NewLine + "\tDungeon? = " + WoWDatabaseSitesAPI.Utility.IsZoneDungeon(requestedItem.WoWHeadXML.ZoneEnum)
                + Environment.NewLine + "\tScenario? = " + WoWDatabaseSitesAPI.Utility.IsZoneScenario(requestedItem.WoWHeadXML.ZoneEnum)
                + Environment.NewLine + "Level = " + requestedItem.WoWHeadXML.ItemLevel
                + Environment.NewLine + "Quality = " + requestedItem.WoWHeadXML.QualityId + " - " + requestedItem.WoWHeadXML.QualityName
                + Environment.NewLine + "Class = " + requestedItem.WoWHeadXML.item.@class.id + " - " + requestedItem.WoWHeadXML.item.@class.Value
                + Environment.NewLine + "Subclass = " + requestedItem.WoWHeadXML.item.subclass.id + " - " + requestedItem.WoWHeadXML.item.subclass.Value
                + Environment.NewLine + "Icon = " + requestedItem.WoWHeadXML.item.icon.displayId + " - " + requestedItem.WoWHeadXML.item.icon.Value
                + Environment.NewLine + "Slot = " + requestedItem.WoWHeadXML.SlotId + " - " + requestedItem.WoWHeadXML.SlotName
                + Environment.NewLine + "Link = " + requestedItem.WoWHeadXML.item.link
                + Environment.NewLine + Environment.NewLine
                + Environment.NewLine + "Armor = " + requestedItem.WoWHeadXML.Armor
                + Environment.NewLine + "Stamina = " + requestedItem.WoWHeadXML.Stamina
                + Environment.NewLine + "Agility = " + requestedItem.WoWHeadXML.Agility
                + Environment.NewLine + "Intellect = " + requestedItem.WoWHeadXML.Intellect
                + Environment.NewLine + "Strength = " + requestedItem.WoWHeadXML.Strength
                + Environment.NewLine + "Crit = " + requestedItem.WoWHeadXML.Crit
                + Environment.NewLine + "Haste = " + requestedItem.WoWHeadXML.Haste
                + Environment.NewLine + "Mastery = " + requestedItem.WoWHeadXML.Mastery
                + Environment.NewLine + "Versatility = " + requestedItem.WoWHeadXML.Versatility
                + Environment.NewLine + "SpellPower = " + requestedItem.WoWHeadXML.SpellPower
                + Environment.NewLine + Environment.NewLine + "HTML Stripped = " + Environment.NewLine + Environment.NewLine + requestedItem.WoWHeadXML.StrippedHtmlString
                + Environment.NewLine + Environment.NewLine + "HTML Tooltip = " + Environment.NewLine + Environment.NewLine + requestedItem.WoWHeadXML.item.htmlTooltip
                + Environment.NewLine + Environment.NewLine + "JSON = " + Environment.NewLine + Environment.NewLine + requestedItem.WoWHeadXML.item.json
                + Environment.NewLine + Environment.NewLine + "JSON Equip = " + Environment.NewLine + Environment.NewLine + requestedItem.WoWHeadXML.item.jsonEquip
                + Environment.NewLine + Environment.NewLine + "Raw XML = " + Environment.NewLine + Environment.NewLine + requestedItem.RawXML.InnerXml.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            wowhead_cbParseSource.SelectedIndex = 0;
            wowhead_cbSite.SelectedIndex = 0;

            wowdb_cbSite.SelectedIndex = 0;
        }

        private void buttonGetJSON_Click(object sender, EventArgs e)
        {
            Item requestedItem = new Item();
            requestedItem = WDSAManager.Provider.WoWDB_GetItemDetailsByAPI(Convert.ToInt32(wowdb_nudID.Value), wowdb_tbBonuses.Text, (WoWDBSiteType)Enum.Parse(typeof(WoWDBSiteType), wowdb_cbSite.Text, true));

            wowdb_textboxOutput.Clear();
            wowdb_textboxOutput.Text = "ID = " + requestedItem.WoWDBAPIItem.ItemId.ToString()
                + Environment.NewLine + "Name = " + requestedItem.WoWDBAPIItem.Name
                //+ Environment.NewLine + "Description = " + requestedItem.WoWHeadXML.Description
                //+ Environment.NewLine + "Source = " + requestedItem.WoWDBAPIItem.Source
                //+ Environment.NewLine + "Drop Chance = " + requestedItem.WoWHeadXML.DropChance
                //+ Environment.NewLine + "Zone = " + requestedItem.WoWHeadXML.ZoneId + " - " + requestedItem.WoWHeadXML.ZoneName
                //+ Environment.NewLine + "\tWorld? = " + WoWDatabaseSitesAPIs.Utility.IsZoneWorldZone(requestedItem.WoWHeadXML.ZoneEnum)
                //+ Environment.NewLine + "\tRaid? = " + WoWDatabaseSitesAPIs.Utility.IsZoneRaid(requestedItem.WoWHeadXML.ZoneEnum)
                //+ Environment.NewLine + "\tDungeon? = " + WoWDatabaseSitesAPIs.Utility.IsZoneDungeon(requestedItem.WoWHeadXML.ZoneEnum)
                //+ Environment.NewLine + "\tScenario? = " + WoWDatabaseSitesAPIs.Utility.IsZoneScenario(requestedItem.WoWHeadXML.ZoneEnum)
                + Environment.NewLine + "Level = " + requestedItem.WoWDBAPIItem.ItemLevel
                + Environment.NewLine + "Quality = " + requestedItem.WoWDBAPIItem.QualityId + " - " + requestedItem.WoWDBAPIItem.QualityName
                + Environment.NewLine + "Class = " + requestedItem.WoWDBAPIItem.RootObject.Class + " - " + requestedItem.WoWDBAPIItem.RootObject.ClassCategory
                + Environment.NewLine + "Subclass = " + requestedItem.WoWDBAPIItem.RootObject.Subclass + " - " + requestedItem.WoWDBAPIItem.RootObject.Subsubclass
                + Environment.NewLine + "Icon = " + requestedItem.WoWDBAPIItem.RootObject.Icon
                + Environment.NewLine + "Slot = " + requestedItem.WoWDBAPIItem.SlotId + " - " + requestedItem.WoWDBAPIItem.SlotName
                //+ Environment.NewLine + "Link = " + requestedItem.WoWHeadXML.item.link
                + Environment.NewLine + Environment.NewLine
                + Environment.NewLine + "Armor = " + requestedItem.WoWDBAPIItem.Armor
                + Environment.NewLine + "Stamina = " + requestedItem.WoWDBAPIItem.Stamina
                + Environment.NewLine + "Agility = " + requestedItem.WoWDBAPIItem.Agility
                + Environment.NewLine + "Intellect = " + requestedItem.WoWDBAPIItem.Intellect
                + Environment.NewLine + "Strength = " + requestedItem.WoWDBAPIItem.Strength
                + Environment.NewLine + "Crit = " + requestedItem.WoWDBAPIItem.Crit
                + Environment.NewLine + "Haste = " + requestedItem.WoWDBAPIItem.Haste
                + Environment.NewLine + "Mastery = " + requestedItem.WoWDBAPIItem.Mastery
                + Environment.NewLine + "Versatility = " + requestedItem.WoWDBAPIItem.Versatility
                + Environment.NewLine + "SpellPower = " + requestedItem.WoWDBAPIItem.SpellPower
                + Environment.NewLine + Environment.NewLine + "JSON = " + Environment.NewLine + Environment.NewLine + requestedItem.WoWDBAPIJSON;
        }
    }
}
