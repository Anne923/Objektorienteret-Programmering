using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGVåbenssystem_Interface
{
    public class Staff : IWeapon, IUpgradeable
    {
        public int MagicPower { get; private set; }

        public Staff(int magicPower)
        {
            MagicPower = magicPower;
        }

        public int Attack()
        {
            return MagicPower * 2;
        }

        public void Upgrade()
        {
            MagicPower += 3;
            Console.WriteLine("Staff upgraded! New MagicPower: " + MagicPower);
        }
    }
}
