using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponsLibrary
{
    public class RecurveBow : Weapon
    {
        public RecurveBow(string name) : base(name)
        {
            BaseDamage = 80; 
            TriggerPoints = 70; 
            SpecialEffectDamage = 50; 
        }
    }
}
