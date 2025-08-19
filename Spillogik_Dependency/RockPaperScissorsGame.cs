using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spillogik_Dependency
{
    public class RockPaperScissorsGame : IGameEngine
    {
        public void Play()
        {
            string[] options = { "rock", "paper", "scissors" };
            var random = new Random();
            string computerChoice = options[random.Next(0, 3)];

            Console.WriteLine("Choose rock, paper, or scissors:");
            string userChoice = Console.ReadLine()?.ToLower();

            Console.WriteLine($"Computer chose {computerChoice}");

            if (userChoice == computerChoice)
                Console.WriteLine("It's a draw!");
            else if ((userChoice == "rock" && computerChoice == "scissors") ||
                     (userChoice == "paper" && computerChoice == "rock") ||
                     (userChoice == "scissors" && computerChoice == "paper"))
                Console.WriteLine("You win!");
            else
                Console.WriteLine("You lose!");
        }
    }
}
