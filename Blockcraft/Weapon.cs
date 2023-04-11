using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockcraft
{
    public abstract class Weapon
    {
        protected double damage;

        public Weapon(double damage)
        {
            this.damage = damage;
        }

        public double getDamage()
        {
            return this.damage;
        }
        
    }
}
