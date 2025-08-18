using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGKarakterer_Nedarvning
{
    internal class Warrior : Character
    {
        public int Strength { get; set; }
        public Warrior(string name, int health, int strength) : base(name, health)
        {
            Strength = strength;
        }
        public override int Attack()
        {
            return Strength * 2;
        }
    }
}
