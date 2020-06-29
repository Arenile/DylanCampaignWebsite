using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DylanCampaignWebsite.Models
{
    public class Character
    {
        public int Id { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
        public int ArmorClass { get; set; }
        public int Initiative { get; set; }
        public int Speed { get; set; }
        public int MaxHealth { get; set; }
        public int Acrobatics { get; set; }
        public int AnimalHandling { get; set; }
        public int Arcana { get; set; }
        public int Athletics { get; set; }
        public int Deception { get; set; }
        public int History { get; set; }
        public int Insight { get; set; }
        public int Intimidation { get; set; }
        public int Investigation { get; set; }
        public int Medicine { get; set; }
        public int Nature { get; set; }
        public int Perception { get; set; }
        public int Performance { get; set; }
        public int Persuasion { get; set; }
        public int Religion { get; set; }
        public int SleightOfHand { get; set; }
        public int Stealth { get; set; }
        public int Survival { get; set; }
        public int StrengthSavingThrow { get; set; }
        public int DexteritySavingThrow { get; set; }
        public int ConstitutionSavingThrow { get; set; }
        public int IntelligenceSavingThrow { get; set; }
        public int WisdomSavingThrow { get; set; }
        public int CharismaSavingThrow { get; set; }
        public string CharacterName { get; set; }
        public string CharacterClass { get; set; }
        public int CharacterLevel { get; set; }
        public string CharacterRace { get; set; }
        public string CharacterBackground { get; set; }
        public string CharacterBio { get; set; }
        /*public string[,] CharacterStatsArray { get; set; }
        public string[,] CharacterSkillsArray { get; set; }
        public string[,] CharacterSTArray { get; set; }
        public List<string> CharacterItems { get; set; }*/
    }
}