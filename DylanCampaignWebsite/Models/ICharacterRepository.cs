using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DylanCampaignWebsite.Models
{
    public interface ICharacterRepository
    {
        Character GetCharacter(int Id);
        IEnumerable<Character> GetAllCharacters();
        Character Add(Character character);
        Character Update(Character characterChanges);
        Character Delete(int id);
    }
}