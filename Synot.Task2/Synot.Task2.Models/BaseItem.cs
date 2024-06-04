namespace Synot.Task2.Models
{
    public class BaseItem
    {
        public Point Location { get; set; }
        public int Health { get; set; }

        public BaseItem(Point worldSize) 
        {
            Health = Random.Shared.Next(1, 100);
            Location = new Point(
                x: Random.Shared.Next(0, worldSize.X),
                y: Random.Shared.Next(0, worldSize.Y));
        }

        //Euclidean distance formula
        public double DistanceTo(Point other)
        {
            int dx = other.X - Location.X;
            int dy = other.Y - Location.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        public override string ToString()
        {
            return $"Health: {Health}, Location: {Location}";
        }
    }
}
