using Synot.Task2.Services;
using Synot.Task2.Services.Intefaces;
using System.Runtime.InteropServices;

namespace Synot.Task2.ConsoleApp
{
    internal class Program
    {
        static IWorld _world;
        static void Main(string[] args)
        {
            _world = new World(new Models.Point(100, 100));
            _world.CreateWorld();

            var referencedItem = _world.ItemsInWorld.First();
            var distance = 30;
            var itemsNearBy = _world.FindNearby(referencedItem, distance);
            
            Console.WriteLine($"Referenced item: {referencedItem}");
            Console.WriteLine($"Near by items by distance: {distance}");
            foreach (var item in itemsNearBy)
                Console.WriteLine(item);

        }
    }
}