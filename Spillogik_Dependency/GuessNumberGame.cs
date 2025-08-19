using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spillogik_Dependency
{
    public class GuessNumberGame : IGameEngine
    {
        public void Play()
        {
            var random = new Random();
            int number = random.Next(1, 11);
            Console.WriteLine("Guess a number between 1 and 10:");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int guess) && guess == number)
                Console.WriteLine("Correct!");
            else
                Console.WriteLine($"Wrong! The number was {number}");
        }
    }
}
