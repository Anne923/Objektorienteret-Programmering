using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGVåbenssystem_Interface
{
    public class Sword : IWeapon, IUpgradeable
    {
        private int damage = 10;

        public int Attack()
        {
            return damage;
        }

        public void Upgrade()
        {
            damage += 5;
            Console.WriteLine("Sword upgraded! New damage: " + damage);
        }
    }
}
