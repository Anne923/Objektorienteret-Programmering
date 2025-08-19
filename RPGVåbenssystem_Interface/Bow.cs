using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGVåbenssystem_Interface
{
    public class Bow : IWeapon, IUpgradeable
    {
        private Random rng = new Random();
        private int minDamage = 5;
        private int maxDamage = 15;

        public int Attack()
        {
            return rng.Next(minDamage, maxDamage + 1);
        }

        public void Upgrade()
        {
            minDamage += 2;
            maxDamage += 2;
            Console.WriteLine($"Bow upgraded! Damage range: {minDamage}-{maxDamage}");
        }
    }
}
