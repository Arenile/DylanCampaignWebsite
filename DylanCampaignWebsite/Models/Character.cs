using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DylanCampaignWebsite.Models
{
    public class Character
    {
        public int Id { get; set; }
        public struct CharacterStats
        {
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

            public void ResetStats()
            {
                this.Strength = 0;
                this.Dexterity = 0;
                this.Constitution = 0;
                this.Intelligence = 0;
                this.Wisdom = 0;
                this.Charisma = 0;
                this.ArmorClass = 0;
                this.Initiative = 0;
                this.Speed = 0;
                this.MaxHealth = 0;
            }
        }
        public struct CharacterSkills
        {
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

            public void ResetSkills()
            {
                this.Acrobatics = 0;
                this.AnimalHandling = 0;
                this.Arcana = 0;
                this.Athletics = 0;
                this.Deception = 0;
                this.History = 0;
                this.Insight = 0;
                this.Intimidation = 0;
                this.Investigation = 0;
                this.Medicine = 0;
                this.Nature = 0;
                this.Perception = 0;
                this.Performance = 0;
                this.Persuasion = 0;
                this.Religion = 0;
                this.SleightOfHand = 0;
                this.Stealth = 0;
                this.Survival = 0;
            }
        }
        public struct CharacterSavingThrows
        {
            public int StrengthSavingThrow { get; set; }
            public int DexteritySavingThrow { get; set; }
            public int ConstitutionSavingThrow { get; set; }
            public int IntelligenceSavingThrow { get; set; }
            public int WisdomSavingThrow { get; set; }
            public int CharismaSavingThrow { get; set; }

            public void ResetSavingThrows()
            {
                this.StrengthSavingThrow = 0;
                this.DexteritySavingThrow = 0;
                this.ConstitutionSavingThrow = 0;
                this.IntelligenceSavingThrow = 0;
                this.WisdomSavingThrow = 0;
                this.CharismaSavingThrow = 0;
            }
        }
        public string CharacterName { get; set; }
        public string CharacterClass { get; set; }
        public int CharacterLevel { get; set; }
        public string CharacterRace { get; set; }
        public string CharacterBackground { get; set; }
        public string CharacterBio { get; set; }
        public List<string> CharacterItems { get; set; }
    }
}