using Synot.Task2.Models;
using Synot.Task2.Services.Intefaces;

namespace Synot.Task2.Services
{
    public class World:IWorld
    {
        public List<BaseItem> ItemsInWorld { get; set; } = new List<BaseItem>();
        public Point WorldSize { get; set; }

        public World(Point size)
        {
            WorldSize = size;
        }

        public void CreateWorld()
        {
            ItemsInWorld.Add(new Player("Player", WorldSize));

            for(var i = 0;i<3;i++)
            {
                ItemsInWorld.Add(new Character($"Greeting {i}", WorldSize));                
            }

            for (var i = 0; i < 5; i++)
            {
                ItemsInWorld.Add(new Animal(WorldSize));
            }
        }

        public List<BaseItem> FindNearby(BaseItem referencePoint, int distance) 
        {
            return ItemsInWorld.Where(p => p.DistanceTo(referencePoint.Location) <= distance).ToList();
        }
    }
}
