using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoblinsAndGUI
{
    public class Player
    {
        //gets health
        public int Health { get; set; }

        // gets name
        public string Name { get; set; }

        //gameover / death mechanic
        public bool IsDead { get; set; }

        //looks to see if player used defend last turn (similar to protect from pokemon)
        public bool IsDefend { get; set; }

        //for if the player ran or not
        public bool RanAway { get; set; }

        public Player() 
        {
            //set health to 100
            Health = 100;
        }


        //damage calc from getting hit
        public int Hit(int hit_value)
        {
            //subtract hit value from health
            Health -= hit_value;

            //check death of player
            if(Health <= 0) 
            {
                //player ded
                Die();
            }
            return Health;
        }

        public void Heal(int healAmount)
        {
            //makes it so that heal is unable to go over 100 (max)
            Health = (Health + healAmount > 100) ? 100: (Health + healAmount);
        }
        
        public void Run(int runChance)
        {
            //runs a run chance to see if the player can escape, if not, they skip a turn in battle
            switch(runChance)
            {
                case 1:
                    RanAway = true;
                    break;
                case 2:
                    RanAway= false;
                    break;
                case 3:
                    RanAway= true;
                    break;
                case 4:
                    RanAway = true;
                    break;
                default:
                    RanAway = false;
                    break;
            }
        }

        private void Die()
        {
            //set bool for gameover to true;
            IsDead = true;
        }
    }
}
