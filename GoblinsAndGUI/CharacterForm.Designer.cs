namespace GoblinsAndGUI
{
    partial class CharacterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.enterName = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.characterDoneBtn = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterName
            // 
            this.enterName.AutoSize = true;
            this.enterName.Location = new System.Drawing.Point(12, 9);
            this.enterName.Name = "enterName";
            this.enterName.Size = new System.Drawing.Size(66, 13);
            this.enterName.TabIndex = 0;
            this.enterName.Text = "Enter Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(15, 35);
            this.nameTextBox.MaxLength = 32;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(136, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // characterDoneBtn
            // 
            this.characterDoneBtn.Location = new System.Drawing.Point(360, 415);
            this.characterDoneBtn.Name = "characterDoneBtn";
            this.characterDoneBtn.Size = new System.Drawing.Size(75, 23);
            this.characterDoneBtn.TabIndex = 2;
            this.characterDoneBtn.Text = "Done";
            this.characterDoneBtn.UseVisualStyleBackColor = true;
            this.characterDoneBtn.Click += new System.EventHandler(this.characterDoneBtn_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(15, 62);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(39, 13);
            this.lblError.TabIndex = 3;
            this.lblError.Text = "lblError";
            this.lblError.Visible = false;
            // 
            // CharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.characterDoneBtn);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.enterName);
            this.Name = "CharacterForm";
            this.Text = "CharacterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterName;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button characterDoneBtn;
        private System.Windows.Forms.Label lblError;
    }
}