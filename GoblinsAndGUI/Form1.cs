using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoblinsAndGUI
{
    public partial class Main_Menu : Form
    {
        private Player player;
        private Enemy currentEnemy;
        private Random random;
        private const int maxPlayerAttackPower = 10;
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            //load form
            CharacterForm characterForm = new CharacterForm(this);

            //display form
            characterForm.ShowDialog();
        }

        public void StartGame(String playerName)
        {
            //assign name
            player = new Player()
            {
                Name = playerName
            };

            //init random
            random = new Random();

            //display game and hide start button
            startButton.Visible = false;
            battleGrid.Visible = true;
            gameLogBox.Visible = true;

            //print out start game text
            gameLogBox.Text = "Name: " + playerName + Environment.NewLine;

            //make current enemy
            currentEnemy = new Enemy("Dog");

            //print text for when enemy is encountered
            gameLogBox.AppendText(player.Name + " encountered a " + currentEnemy.Name + "!" + Environment.NewLine + "What ACTION will you take?" + Environment.NewLine);
        }

        private void PerformAction(string action)
        {
            //create intitial hit value
            int hit_value = 0;

            //check ACTION of player
            switch(action) 
            {
                case "1":
                    //write out attack text
                    gameLogBox.AppendText(player.Name + " attacked " + currentEnemy.Name + "!" + Environment.NewLine);

                    //attack enemy
                    hit_value = random.Next(1, maxPlayerAttackPower);

                    currentEnemy.Hit(hit_value);

                    //print out dmg
                    gameLogBox.AppendText(player.Name + " hit " + currentEnemy.Name + " for " + hit_value + " damage! They have " + currentEnemy.Health + " remaining." + Environment.NewLine);

                    break;
                case "2":

                    //write out defend text
                    gameLogBox.AppendText(player.Name + " defended against " + currentEnemy.Name + "!" + Environment.NewLine);

                    //defend against enemy
                    player.IsDefend = true;

                    break;
                case "3":
                    //write out heal text
                    gameLogBox.AppendText(player.Name + " healed themselves!" + Environment.NewLine);

                    //heal player
                    int healAmount = random.Next(5, 25);

                    player.Heal(healAmount);

                    //print out heal text
                    gameLogBox.AppendText(player.Name + "has healed " + healAmount + " health." + player.Name + " now has " + player.Health + " health remaining." + Environment.NewLine);

                    break;

                case "4":
                    //run from enemy chance
                    player.Run(random.Next(1, 5));

                    if(player.RanAway == true)
                    {
                        //write out run text
                        gameLogBox.AppendText(player.Name + " ran from " + currentEnemy.Name + "!" + Environment.NewLine);

                        //make current enemy after player runs (you cant escape)
                        currentEnemy = new Enemy("Another Dog");

                        //print text for when enemy is encountered
                        gameLogBox.AppendText(player.Name + " encountered a " + currentEnemy.Name + " after running away from another enemy!" + Environment.NewLine + "What ACTION will you take?" + Environment.NewLine);
                    }
                    defendBtn.Visible = true;
                    attackBtn.Visible = true;
                    healBtn.Visible = true;

                    break;
                default:
                    break;
            }

            //check if enemy is dead
            if (!currentEnemy.IsDead)
            {

                //check if player is guarding
                if (player.IsDefend)
                {
                    //print out that player was defendign
                    gameLogBox.AppendText(player.Name + " defended against " + currentEnemy.Name + "!" + Environment.NewLine);

                    //remove the guard
                    player.IsDefend = false;
                }
                else
                {
                    //have enemy attack player and print
                    gameLogBox.AppendText("The " + currentEnemy.Name + " attacked " + player.Name 
                        + " and they have " + player.Hit(random.Next(1, currentEnemy.MaxAttackPower)) 
                        + " health remaining." + Environment.NewLine);

                }

            }
            else
            {
                //print out that the enemy is dead
                gameLogBox.AppendText(currentEnemy.Name + " has fallen! " + player.Name + " is victorious!" + Environment.NewLine);
                attackBtn.Visible = false;
                defendBtn.Visible = false;
                healBtn.Visible = false;
            }

            //Check if either enmeny of player dead
            if(player.IsDead)
            {
                //gameover
                GameOver();
            }
            else if(currentEnemy.IsDead)
            {
                // player win
                gameLogBox.AppendText("Congratulations! " + player.Name + " has completed their journey! (or have they?)" + Environment.NewLine);
            }
        }

        private void GameOver()
        {
            //print out game end and hide controls
            gameLogBox.AppendText("Death has befallen " + player.Name + "! Game Over!" + Environment.NewLine);

            //hide controls and show start game
            startButton.Visible = true;
            battleGrid.Visible = false;
        }

        private void attackBtn_Click(object sender, EventArgs e)
        {
            //perfrom action
            PerformAction("1");
        }

        private void defendBtn_Click(object sender, EventArgs e)
        {
            //perform action
            PerformAction("2");
        }

        private void healBtn_Click(object sender, EventArgs e)
        {
            //perform action
            PerformAction("3");
        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            //perform action
            PerformAction("4");
        }
    }
}
