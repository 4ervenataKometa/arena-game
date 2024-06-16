using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponsLibrary
{
    public class Katana : Weapon
    {
        public Katana(string name) : base(name)
        {
            BaseDamage = 120;
            TriggerPoints = 90; 
            SpecialEffectDamage = 50; 
        }

    }
}
