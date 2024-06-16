using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponsLibrary;

namespace ArenaGame
{
    public class Samurai : Hero
    {
        private const int DodgeChance = 20; 
        private const int CriticalStrikeChance = 10; 
        private const int HealEachNthRound = 3;
        private int attackCount;

        public Samurai(string name, Weapon weapon) : base(name, weapon)
        {
            attackCount = 0;
        }

        public override int Attack()
        {
            int attack = base.Attack();
            if (ThrowDice(CriticalStrikeChance))
            {
                attack = attack * 150 / 100; 
                Console.WriteLine($"{Name} lands a critical strike!");
            }
            attackCount++;
            if (attackCount % HealEachNthRound == 0 && ThrowDice(25))
            {
                Heal(StartingHealth * 30 / 100); 
                Console.WriteLine($"{Name} uses meditation to heal.");
            }
            return attack;
        }

        public override void TakeDamage(int incomingDamage)
        {
            if (ThrowDice(DodgeChance))
            {
                Console.WriteLine($"{Name} dodged the attack!");
                incomingDamage = 0;
            }
            base.TakeDamage(incomingDamage);
        }
    }
}
