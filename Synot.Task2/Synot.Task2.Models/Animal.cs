using Synot.Task2.Models.Enums;

namespace Synot.Task2.Models
{
    public class Animal : BaseItem
    {
        public AnimalType AnimalType { get; set; }

        public bool IsFrendly { get; set; }

        public Animal(Point worldSize) : base(worldSize)
        {
            AnimalType = (AnimalType)Random.Shared.Next(0, 6);
            IsFrendly = Random.Shared.Next(0, 2) == 1;
        }

        public override string ToString()
        {
            return $"Animal - AnimalType: {AnimalType}, IsFrendly:{IsFrendly}, {base.ToString()}";
        }
    }
}
