namespace Zoo_Nedarvning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>
            {
                new Parrot { Name = "Polly" },
                new Elephant { Name = "Dumbo" },
                new Lion { Name = "Simba" },
                new Parrot { Name = "Coco" },
                new Elephant { Name = "Babar" },
                new Lion { Name = "Mufasa" },
            };

            foreach (var animal in animals)
            {
                animal.MakeSound();
                animal.Feed();
            }
        }
    }
}
