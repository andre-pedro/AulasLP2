using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortnite
{
    class FNPlayer
    {
        public string equippedWeapon;
        public double hitPoints;
        public double shield;


        public FNPlayer()
        {
            equippedWeapon = "picareta";
            hitPoints = 100;
            shield = 0;
        }


        public FNPlayer(string equippedWeapon, double hitPoints, double shield)
        {
            this.equippedWeapon = equippedWeapon;
            this.hitPoints = hitPoints;
            this.shield = shield;
        }

        public double GetShield()
        {
            return shield;
        }

        public void SetShield(double shield)
        {
            this.shield = shield;
        }


        public void Attack(FNPlayer enemy)
        {
            enemy.TakeDamage(10);
        }

        public void TakeDamage(double damage)
        {
            if (shield > 0)
            {
                shield -= damage;
                if (shield < 0)
                {
                    shield = 0;
                }
            }
            else
            {
                hitPoints -= damage;
                if (hitPoints <= 0)
                {
                    //Die();
                }
            }
        }

    }
}