namespace RPGVåbenssystem_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<IWeapon> weapons = new List<IWeapon>
            {
                new Sword(),
                new Bow(),
                new Staff(7)
            };

            Console.WriteLine("Initial Attacks:");
            foreach (var weapon in weapons)
            {
                Console.WriteLine($"Damage dealt: {weapon.Attack()}");
            }

            Console.WriteLine("\nUpgrading Weapons:");
            foreach (var weapon in weapons)
            {
                if (weapon is IUpgradeable upgradeable)
                {
                    upgradeable.Upgrade();
                }
            }
            Console.WriteLine("\nAttacks after Upgrade:");
            foreach (var weapon in weapons)
            {
                Console.WriteLine($"Damage dealt: {weapon.Attack()}");
            }
        }
    }
}
