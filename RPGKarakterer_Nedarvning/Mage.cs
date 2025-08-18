using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGKarakterer_Nedarvning
{
    internal class Mage : Character
    {
        public int Mana { get; set; }
        public Mage(string name, int health, int mana) : base(name, health)
        {
            Mana = mana;
        }
        public override int Attack()
        {
            return Mana / 2;
        }
    }
}
