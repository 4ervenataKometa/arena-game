using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponsLibrary
{
    public class Sai : Weapon
    {
        public Sai(string name) : base(name)
        {
            BaseDamage = 60;
            TriggerPoints = 75;
            SpecialEffectDamage = 30;
        }
    }
}
