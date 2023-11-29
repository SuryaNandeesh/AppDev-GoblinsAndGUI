using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoblinsAndGUI
{
    public class Enemy
    {
        //gets health
        public int Health { get; set; }

        // gets name
        public string Name { get; set; }

        //gameover / death mechanic
        public bool IsDead { get; set; }

        //max attack power the enemy has
        public int MaxAttackPower { get; set; }

        public Enemy(string name)
        {
            //set health to 100
            Health = 100;

            //set enemy name
            Name = name;

            //set default max attack power
            MaxAttackPower = 10;

        }


        //damage calc from getting hit
        public int Hit(int hit_value)
        {
            
            //subtract hit value from health
            Health -= hit_value;

            //print out the Enemy's current health and how much they got hit for

            //check death of Enemy
            if (Health <= 0)
            {
                //Enemy ded
                Die();
            }
            return Health;
        }

        private void Die()
        {
            //write that Enemy is dead

            //set bool for gameover to true;
            IsDead = true;
        }
    }
}
