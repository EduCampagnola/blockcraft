using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockcraft
{
    internal class StoneAxe : Weapon
    {
        public StoneAxe(double damage) : base(damage)
        {
            this.damage = damage;
        }
    }
}
