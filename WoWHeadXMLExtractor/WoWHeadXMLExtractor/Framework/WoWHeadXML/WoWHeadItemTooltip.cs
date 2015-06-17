using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoWHeadXMLExtractor.Framework.WoWHeadXML
{
    public class WoWHeadItemTooltip
    {
        public int ItemLevel { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Source { get; set; }
        public int QualityId { get; set; }
        public int SlotId { get; set; }
        public int SubclassId { get; set; }
        public int Intellect { get; set; }
        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Stamina { get; set; }
        public int Crit { get; set; }
        public int Haste { get; set; }
        public int Mastery { get; set; }
        public int Multistrike { get; set; }
        public int Versatility { get; set; }
        public int Spirit { get; set; }
        public int DamageLow { get; set; }
        public int DamageHigh { get; set; }
        public int Armor { get; set; }
        public int AttackSpeed { get; set; }
        public int BonusArmor { get; set; }
        public int SpellPower { get; set; }
        public int AgilityStrength { get; set; }
        public int AgilityIntellect { get; set; }
        public int StrengthIntellect { get; set; }
        public int AgilityStrengthIntellect { get; set; }
        public double DropChance { get; set; }
    }
}
