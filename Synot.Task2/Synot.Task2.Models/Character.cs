using Synot.Task2.Models.Enums;
using System.Xml.Linq;

namespace Synot.Task2.Models
{
    public class Character:BaseItem
    {
        public CharacterType CharacterType { get; set; }
        public string GreetingPhrase { get; set; } = string.Empty;

        public Character(string greetingPhrase, Point worldSize) : base(worldSize)
        {
            GreetingPhrase = greetingPhrase;
            CharacterType = (CharacterType)Random.Shared.Next(0, 6);
        }

        public override string ToString()
        {
            return $"Character - CharacterType:{CharacterType}, GreetingPhrase: {GreetingPhrase}, {base.ToString()}";
        }
    }
}
