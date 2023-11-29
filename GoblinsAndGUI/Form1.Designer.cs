namespace GoblinsAndGUI
{
    partial class Main_Menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.gameLogBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.battleGrid = new System.Windows.Forms.TableLayoutPanel();
            this.runBtn = new System.Windows.Forms.Button();
            this.healBtn = new System.Windows.Forms.Button();
            this.defendBtn = new System.Windows.Forms.Button();
            this.attackBtn = new System.Windows.Forms.Button();
            this.battleGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "RPG PlaceHolder";
            // 
            // gameLogBox
            // 
            this.gameLogBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gameLogBox.Location = new System.Drawing.Point(12, 81);
            this.gameLogBox.Multiline = true;
            this.gameLogBox.Name = "gameLogBox";
            this.gameLogBox.ReadOnly = true;
            this.gameLogBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gameLogBox.Size = new System.Drawing.Size(776, 278);
            this.gameLogBox.TabIndex = 1;
            this.gameLogBox.Visible = false;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(364, 365);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start Game";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // battleGrid
            // 
            this.battleGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.battleGrid.AutoSize = true;
            this.battleGrid.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.battleGrid.ColumnCount = 2;
            this.battleGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.battleGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.battleGrid.Controls.Add(this.runBtn, 1, 1);
            this.battleGrid.Controls.Add(this.healBtn, 0, 1);
            this.battleGrid.Controls.Add(this.defendBtn, 1, 0);
            this.battleGrid.Controls.Add(this.attackBtn, 0, 0);
            this.battleGrid.Location = new System.Drawing.Point(12, 394);
            this.battleGrid.Name = "battleGrid";
            this.battleGrid.RowCount = 2;
            this.battleGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.battleGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.battleGrid.Size = new System.Drawing.Size(776, 92);
            this.battleGrid.TabIndex = 3;
            this.battleGrid.Visible = false;
            // 
            // runBtn
            // 
            this.runBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.runBtn.AutoSize = true;
            this.runBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.runBtn.Location = new System.Drawing.Point(391, 49);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(382, 40);
            this.runBtn.TabIndex = 3;
            this.runBtn.Text = "Run";
            this.runBtn.UseVisualStyleBackColor = true;
            this.runBtn.Click += new System.EventHandler(this.runBtn_Click);
            // 
            // healBtn
            // 
            this.healBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.healBtn.AutoSize = true;
            this.healBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.healBtn.Location = new System.Drawing.Point(3, 49);
            this.healBtn.Name = "healBtn";
            this.healBtn.Size = new System.Drawing.Size(382, 40);
            this.healBtn.TabIndex = 2;
            this.healBtn.Text = "Heal";
            this.healBtn.UseVisualStyleBackColor = true;
            this.healBtn.Click += new System.EventHandler(this.healBtn_Click);
            // 
            // defendBtn
            // 
            this.defendBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.defendBtn.AutoSize = true;
            this.defendBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.defendBtn.Location = new System.Drawing.Point(391, 3);
            this.defendBtn.Name = "defendBtn";
            this.defendBtn.Size = new System.Drawing.Size(382, 40);
            this.defendBtn.TabIndex = 1;
            this.defendBtn.Text = "Defend";
            this.defendBtn.UseVisualStyleBackColor = true;
            this.defendBtn.Click += new System.EventHandler(this.defendBtn_Click);
            // 
            // attackBtn
            // 
            this.attackBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.attackBtn.AutoSize = true;
            this.attackBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.attackBtn.Location = new System.Drawing.Point(3, 3);
            this.attackBtn.Name = "attackBtn";
            this.attackBtn.Size = new System.Drawing.Size(382, 40);
            this.attackBtn.TabIndex = 0;
            this.attackBtn.Text = "Attack";
            this.attackBtn.UseVisualStyleBackColor = true;
            this.attackBtn.Click += new System.EventHandler(this.attackBtn_Click);
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.battleGrid);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.gameLogBox);
            this.Controls.Add(this.label1);
            this.Name = "Main_Menu";
            this.Text = "Main Menu";
            this.battleGrid.ResumeLayout(false);
            this.battleGrid.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox gameLogBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TableLayoutPanel battleGrid;
        private System.Windows.Forms.Button runBtn;
        private System.Windows.Forms.Button healBtn;
        private System.Windows.Forms.Button defendBtn;
        private System.Windows.Forms.Button attackBtn;
    }
}

