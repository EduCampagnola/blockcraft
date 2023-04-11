using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockcraft
{
    public class GoldenSword : Weapon
    {
        public GoldenSword(double damage) : base(damage)
        {
            this.damage = damage;
        }
    }
}
