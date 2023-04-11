using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockcraft
{
    public class Enemy
    {
        protected double health = 100;

        /*public Enemy(int health)
        {
            this.health = health;
        }*/

        public double getHealth()
        {
            return this.health;
        }

        public void setHealth(double _health)
        {
            this.health = _health;
        }
    }
}
