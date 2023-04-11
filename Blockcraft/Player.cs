using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockcraft
{
    public class Player
    {
        //private List<Weapon> weapons = new List<Weapon>();

        private Weapon weapon;
        

        public Player(Weapon weapon)
        {
            this.weapon = weapon;
        }

        public Weapon getWeapon()
        {
            return this.weapon;
        }
        
        public void ChangeWeapon(Weapon weapon)
        {
            this.weapon = weapon;
        }
    }


}
