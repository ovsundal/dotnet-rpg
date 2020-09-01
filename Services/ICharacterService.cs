using dotnet_rpg.Models;

namespace dotnet_rpg.obj.Services.CharacterService
{
    public interface ICharacterService
    {
      List<Character> GetAllCharacters();
      Character GetCharacterById(int id);
      List<Character> AddCharacter(Character character);
    } 
}