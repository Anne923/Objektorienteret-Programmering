namespace Transport_Nedarvning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>
            {
                new Car { Brand = "Toyota", MaxSpeed = 180, NumberOfDoors = 4 },
                new Bicycle { Brand = "Gazelle", MaxSpeed = 25, HasBell = true },
                new Car { Brand = "Ford", MaxSpeed = 200, NumberOfDoors = 2 },
                new Bicycle { Brand = "Trek", MaxSpeed = 30, HasBell = false }
            };

            foreach (var vehicle in vehicles)
            {
                vehicle.Drive();
            }
        }
    }
}
