namespace Synot.Task2.Models
{
    public class Player:BaseItem
    {
        public string Name { get; set; } = string.Empty;

        public Player(string name, Point worldSize):base(worldSize)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"Player - Name: {Name}, {base.ToString()}";
        }
    }    
}