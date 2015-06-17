using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WoWHeadXMLExtractor.BusinessLogic;
using WoWHeadXMLExtractor.Framework;
using WoWHeadXMLExtractor.Framework.Core;

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
            requestedItem = WHXEManager.Provider.GetItemDetailsByURL(Convert.ToInt32(nudID.Value), tbBonuses.Text, (WoWHeadSiteType) Enum.Parse(typeof(WoWHeadSiteType), cbSite.Text, true), cbParseSource.SelectedIndex);

            textboxOutput.Clear();
            textboxOutput.Text = "ID = " + requestedItem.WoWHeadXML.item.id.ToString()
                + Environment.NewLine + "Name = " + requestedItem.WoWHeadXML.Name
                + Environment.NewLine + "Description = " + requestedItem.WoWHeadXML.Description
                + Environment.NewLine + "Source = " + requestedItem.WoWHeadXML.Source
                + Environment.NewLine + "Drop Chance = " + requestedItem.WoWHeadXML.DropChance
                + Environment.NewLine + "Level = " + requestedItem.WoWHeadXML.ItemLevel
                + Environment.NewLine + "Quality = " + requestedItem.WoWHeadXML.item.quality.id + " - " + requestedItem.WoWHeadXML.item.quality.Value
                + Environment.NewLine + "Class = " + requestedItem.WoWHeadXML.item.@class.id + " - " + requestedItem.WoWHeadXML.item.@class.Value
                + Environment.NewLine + "Subclass = " + requestedItem.WoWHeadXML.item.subclass.id + " - " + requestedItem.WoWHeadXML.item.subclass.Value
                + Environment.NewLine + "Icon = " + requestedItem.WoWHeadXML.item.icon.displayId + " - " + requestedItem.WoWHeadXML.item.icon.Value
                + Environment.NewLine + "Slot = " + requestedItem.WoWHeadXML.item.inventorySlot.id + " - " + requestedItem.WoWHeadXML.item.inventorySlot.Value
                + Environment.NewLine + "Link = " + requestedItem.WoWHeadXML.item.link
                + Environment.NewLine + Environment.NewLine + "Parsed Data:"
                + Environment.NewLine + "Stamina = " + requestedItem.WoWHeadXML.Stamina
                + Environment.NewLine + "Agility = " + requestedItem.WoWHeadXML.Agility
                + Environment.NewLine + "Intellect = " + requestedItem.WoWHeadXML.Intellect
                + Environment.NewLine + "Strength = " + requestedItem.WoWHeadXML.Strength
                + Environment.NewLine + "Crit = " + requestedItem.WoWHeadXML.Crit
                + Environment.NewLine + "Haste = " + requestedItem.WoWHeadXML.Haste
                + Environment.NewLine + "Mastery = " + requestedItem.WoWHeadXML.Mastery
                + Environment.NewLine + "Multistrike = " + requestedItem.WoWHeadXML.Multistrike
                + Environment.NewLine + "Versatility = " + requestedItem.WoWHeadXML.Versatility
                + Environment.NewLine + "Bonus Armor = " + requestedItem.WoWHeadXML.BonusArmor
                + Environment.NewLine + "Spirit = " + requestedItem.WoWHeadXML.Spirit
                + Environment.NewLine + "SpellPower = " + requestedItem.WoWHeadXML.SpellPower
                + Environment.NewLine + Environment.NewLine + "HTML Stripped = " + Environment.NewLine + Environment.NewLine + requestedItem.WoWHeadXML.StrippedHtmlString
                + Environment.NewLine + Environment.NewLine + "HTML Tooltip = " + Environment.NewLine + Environment.NewLine + requestedItem.WoWHeadXML.item.htmlTooltip
                + Environment.NewLine + Environment.NewLine + "JSON = " + Environment.NewLine + Environment.NewLine + requestedItem.WoWHeadXML.item.json
                + Environment.NewLine + Environment.NewLine + "JSON Equip = " + Environment.NewLine + Environment.NewLine + requestedItem.WoWHeadXML.item.jsonEquip
                + Environment.NewLine + Environment.NewLine + "Raw XML = " + Environment.NewLine + Environment.NewLine + requestedItem.RawXML.InnerXml.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbParseSource.SelectedIndex = 2;
            cbSite.SelectedIndex = 0;
        }
    }
}
