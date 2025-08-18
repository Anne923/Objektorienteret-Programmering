namespace Dyrelyde_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IMakeSound> animals = new List<IMakeSound>
            {
                new Dog(),
                new Cat(),
                new Cow()
            };

            Console.WriteLine("Animal sounds:");
            foreach (var animal in animals)
            {
                animal.MakeSound();
            }

            Console.WriteLine("\nFeeding feedable animals:");
            foreach (var animal in animals)
            {
                if (animal is IFeedable feedable)
                {
                    feedable.Feed();
                }
            }
        }
    }
}
