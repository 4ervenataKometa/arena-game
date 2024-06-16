using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponsLibrary
{
    public class Weapon
    {
        public string Name { get; private set; }
        public int BaseDamage { get; protected set; }
        public int TriggerPoints { get; protected set; }
        public int SpecialEffectDamage { get; protected set; }

        public Weapon(string name)
        {
            Name = name;
            BaseDamage = 0;
            TriggerPoints = 0;
            SpecialEffectDamage = 0;
        }

        public int CalculateDamage()
        {
            Random random = new Random();
            int totalDamage = BaseDamage;
            if (IsSpecialEffectTriggered())
            {
                totalDamage += SpecialEffectDamage;
            }
            return totalDamage;
        }

        private bool IsSpecialEffectTriggered()
        {
            Random random = new Random();
            int roll = random.Next(101);
            return roll <= TriggerPoints;
        }
    }
}
