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
    public partial class CharacterForm : Form
    {
        private Main_Menu caller;
        public CharacterForm(Main_Menu callerForm)
        {
            InitializeComponent();

            //referencece caller
            caller = callerForm;

            //keydown event
            nameTextBox.KeyDown += (sender, args) =>
            {
                //Check if key is enter key
                if (args.KeyCode == Keys.Enter)
                {
                    //click submit
                    characterDoneBtn.PerformClick();
                }
            };
        }

        private void characterDoneBtn_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(nameTextBox.Text))
            {
                //start game in caller form
                caller.StartGame(nameTextBox.Text.Trim());

                //close form after done
                this.Close();
            }
            else
            {
                //name not entered
                lblError.Visible = true;
                lblError.Text = "No name was given. Please enter a 32 character name.";
            }
        }
    }
}
