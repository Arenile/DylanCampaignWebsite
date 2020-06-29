using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DylanCampaignWebsite.Models
{
    public class SQLCharacterRepository : ICharacterRepository
    {
        private readonly AppDbContext context;
        public SQLCharacterRepository(AppDbContext context)
        {
            this.context = context;
        }
        public Character Add(Character character)
        {
            context.Characters.Add(character);
            context.SaveChanges();
            return character;
        }

        public Character Delete(int id)
        {
            Character character = context.Characters.Find(id);
            if (character != null)
            {
                context.Characters.Remove(character);
                context.SaveChanges();
            }
            return character;
        }

        public IEnumerable<Character> GetAllCharacters()
        {
            return context.Characters;
        }

        public Character GetCharacter(int Id)
        {
            return context.Characters.Find(Id);
        }

        public Character Update(Character characterChanges)
        {
            var character = context.Characters.Attach(characterChanges);
            character.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return characterChanges;
        }
    }
}
