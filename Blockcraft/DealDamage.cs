using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockcraft
{
    public class DealDamage
    {
        private Enemy enemy;
        private Player player;

        public DealDamage(Enemy enemy, Player player)
        {
            this.enemy = enemy;
            this.player = player;
        }

        public void Attack()
        {
            double enemyHealth = enemy.getHealth();
            Weapon playerWeapon = this.player.getWeapon();
            double weaponDamage = playerWeapon.getDamage();
            double weaponDamage2 = (10 - weaponDamage) / 10 ;
            double currentHealth = enemyHealth * weaponDamage2;
            Console.WriteLine(currentHealth);
            enemy.setHealth(currentHealth);
        }
    }
}
