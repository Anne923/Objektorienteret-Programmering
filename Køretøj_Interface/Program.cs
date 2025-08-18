namespace Køretøj_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var driveables = new List<IDriveable>
            {
                new Car("Toyota"),
                new Motorcycle("Harley-Davidson"),
                new Car("BMW"),
                new Motorcycle("Yamaha")
            };

            Console.WriteLine("Starting all vehicles:\n");
            DriveManager.StartAllVehicles(driveables);

            Console.WriteLine("\nStopping all vehicles:\n");
            foreach (var vehicle in driveables)
            {
                vehicle.Stop();
            }
        }
    }
}
