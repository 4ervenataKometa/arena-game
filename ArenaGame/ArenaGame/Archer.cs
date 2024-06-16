using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponsLibrary;

namespace ArenaGame
{
    public class Archer : Hero
    {
        private const int CriticalHitChance = 25;
        private const int EvadeChance = 15; 

        public Archer(string name, Weapon weapon) : base(name, weapon)
        {
            Strength = 90; 
        }

        public override int Attack()
        {
            int attack = base.Attack();
            if (ThrowDice(CriticalHitChance))
            {
                attack = attack * 200 / 100; 
                Console.WriteLine($"{Name} hits a critical shot!");
            }
            return attack;
        }

        public override void TakeDamage(int incomingDamage)
        {
            if (ThrowDice(EvadeChance))
            {
                Console.WriteLine($"{Name} evades the attack!");
                incomingDamage = 0;
            }
            base.TakeDamage(incomingDamage);
        }
    }
}
