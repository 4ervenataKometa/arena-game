using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponsLibrary
{
    public class Excalibur : Weapon
    {
        public Excalibur(string name) : base(name)
        {
            BaseDamage = 120; 
            TriggerPoints = 85; 
            SpecialEffectDamage = 60; 
        }
    }
}
