namespace RPGKarakterer_Nedarvning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Character player1 = new Warrior("Thorin", 100, 20);
            Character player2 = new Mage("Elira", 80, 50);

            Console.WriteLine("Battle Begins!\n");

            while (player1.Health > 0 && player2.Health > 0)
            {
                int damageToP2 = player1.Attack();
                player2.Health -= damageToP2;
                Console.WriteLine($"{player1.Name} attacks {player2.Name} for {damageToP2} damage. {player2.Name} has {Math.Max(player2.Health, 0)} health left.");

                if (player2.Health <= 0) break;

                int damageToP1 = player2.Attack();
                player1.Health -= damageToP1;
                Console.WriteLine($"{player2.Name} attacks {player1.Name} for {damageToP1} damage. {player1.Name} has {Math.Max(player1.Health, 0)} health left.\n");
            }

            Console.WriteLine("Battle Over!");
            if (player1.Health <= 0 && player2.Health <= 0)
            {
                Console.WriteLine("It's a draw!");
            }
            else if (player1.Health <= 0)
            {
                Console.WriteLine($"{player2.Name} wins!");
            }
            else
            {
                Console.WriteLine($"{player1.Name} wins!");
            }
        }
    }
}
