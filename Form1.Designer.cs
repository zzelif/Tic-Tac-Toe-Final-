namespace FinalTicTacToe
{
    partial class formTictactoe
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formTictactoe));
            this.Btn1 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.lblScore1 = new System.Windows.Forms.Label();
            this.lblScore2 = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.timerAi = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn1
            // 
            this.Btn1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn1.BackgroundImage")));
            this.Btn1.Font = new System.Drawing.Font("Blackadder ITC", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1.ForeColor = System.Drawing.Color.DarkCyan;
            this.Btn1.Location = new System.Drawing.Point(41, 47);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(150, 120);
            this.Btn1.TabIndex = 0;
            this.Btn1.Tag = "play";
            this.Btn1.UseVisualStyleBackColor = false;
            this.Btn1.Click += new System.EventHandler(this.buttonClick);
            // 
            // Btn2
            // 
            this.Btn2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn2.BackgroundImage")));
            this.Btn2.Font = new System.Drawing.Font("Blackadder ITC", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn2.ForeColor = System.Drawing.Color.DarkCyan;
            this.Btn2.Location = new System.Drawing.Point(279, 47);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(150, 120);
            this.Btn2.TabIndex = 1;
            this.Btn2.Tag = "play";
            this.Btn2.UseVisualStyleBackColor = false;
            this.Btn2.Click += new System.EventHandler(this.buttonClick);
            // 
            // Btn3
            // 
            this.Btn3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn3.BackgroundImage")));
            this.Btn3.Font = new System.Drawing.Font("Blackadder ITC", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn3.ForeColor = System.Drawing.Color.DarkCyan;
            this.Btn3.Location = new System.Drawing.Point(519, 47);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(150, 120);
            this.Btn3.TabIndex = 2;
            this.Btn3.Tag = "play";
            this.Btn3.UseVisualStyleBackColor = false;
            this.Btn3.Click += new System.EventHandler(this.buttonClick);
            // 
            // Btn4
            // 
            this.Btn4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn4.BackgroundImage")));
            this.Btn4.Font = new System.Drawing.Font("Blackadder ITC", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn4.ForeColor = System.Drawing.Color.DarkCyan;
            this.Btn4.Location = new System.Drawing.Point(41, 238);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(150, 120);
            this.Btn4.TabIndex = 3;
            this.Btn4.Tag = "play";
            this.Btn4.UseVisualStyleBackColor = false;
            this.Btn4.Click += new System.EventHandler(this.buttonClick);
            // 
            // Btn5
            // 
            this.Btn5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn5.BackgroundImage")));
            this.Btn5.Font = new System.Drawing.Font("Blackadder ITC", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn5.ForeColor = System.Drawing.Color.DarkCyan;
            this.Btn5.Location = new System.Drawing.Point(279, 238);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(150, 120);
            this.Btn5.TabIndex = 4;
            this.Btn5.Tag = "play";
            this.Btn5.UseVisualStyleBackColor = false;
            this.Btn5.Click += new System.EventHandler(this.buttonClick);
            // 
            // Btn6
            // 
            this.Btn6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn6.BackgroundImage")));
            this.Btn6.Font = new System.Drawing.Font("Blackadder ITC", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn6.ForeColor = System.Drawing.Color.DarkCyan;
            this.Btn6.Location = new System.Drawing.Point(519, 238);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(150, 120);
            this.Btn6.TabIndex = 5;
            this.Btn6.Tag = "play";
            this.Btn6.UseVisualStyleBackColor = false;
            this.Btn6.Click += new System.EventHandler(this.buttonClick);
            // 
            // Btn8
            // 
            this.Btn8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn8.BackgroundImage")));
            this.Btn8.Font = new System.Drawing.Font("Blackadder ITC", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn8.ForeColor = System.Drawing.Color.DarkCyan;
            this.Btn8.Location = new System.Drawing.Point(279, 423);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(150, 120);
            this.Btn8.TabIndex = 6;
            this.Btn8.Tag = "play";
            this.Btn8.UseVisualStyleBackColor = false;
            this.Btn8.Click += new System.EventHandler(this.buttonClick);
            // 
            // Btn7
            // 
            this.Btn7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn7.BackgroundImage")));
            this.Btn7.Font = new System.Drawing.Font("Blackadder ITC", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn7.ForeColor = System.Drawing.Color.DarkCyan;
            this.Btn7.Location = new System.Drawing.Point(41, 423);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(150, 120);
            this.Btn7.TabIndex = 6;
            this.Btn7.Tag = "play";
            this.Btn7.UseVisualStyleBackColor = false;
            this.Btn7.Click += new System.EventHandler(this.buttonClick);
            // 
            // Btn9
            // 
            this.Btn9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn9.BackgroundImage")));
            this.Btn9.Font = new System.Drawing.Font("Blackadder ITC", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn9.ForeColor = System.Drawing.Color.DarkCyan;
            this.Btn9.Location = new System.Drawing.Point(519, 423);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(150, 120);
            this.Btn9.TabIndex = 7;
            this.Btn9.Tag = "play";
            this.Btn9.UseVisualStyleBackColor = false;
            this.Btn9.Click += new System.EventHandler(this.buttonClick);
            // 
            // lblScore1
            // 
            this.lblScore1.AutoSize = true;
            this.lblScore1.BackColor = System.Drawing.Color.BurlyWood;
            this.lblScore1.Font = new System.Drawing.Font("Brush Script MT", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore1.Location = new System.Drawing.Point(751, 161);
            this.lblScore1.Name = "lblScore1";
            this.lblScore1.Size = new System.Drawing.Size(30, 41);
            this.lblScore1.TabIndex = 8;
            this.lblScore1.Text = "?";
            // 
            // lblScore2
            // 
            this.lblScore2.AutoSize = true;
            this.lblScore2.BackColor = System.Drawing.Color.BurlyWood;
            this.lblScore2.Font = new System.Drawing.Font("Brush Script MT", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore2.Location = new System.Drawing.Point(751, 271);
            this.lblScore2.Name = "lblScore2";
            this.lblScore2.Size = new System.Drawing.Size(30, 41);
            this.lblScore2.TabIndex = 9;
            this.lblScore2.Text = "?";
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.BurlyWood;
            this.resetButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resetButton.BackgroundImage")));
            this.resetButton.Font = new System.Drawing.Font("Blackadder ITC", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.Color.Cornsilk;
            this.resetButton.Location = new System.Drawing.Point(834, 423);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(170, 66);
            this.resetButton.TabIndex = 11;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetGame);
            // 
            // timerAi
            // 
            this.timerAi.Interval = 500;
            this.timerAi.Tick += new System.EventHandler(this.playAi);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.BurlyWood;
            this.label1.Font = new System.Drawing.Font("Blackadder ITC", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(862, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 60);
            this.label1.TabIndex = 12;
            this.label1.Text = "Score";
            // 
            // formTictactoe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1165, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.lblScore2);
            this.Controls.Add(this.lblScore1);
            this.Controls.Add(this.Btn9);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn1);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formTictactoe";
            this.Tag = "play";
            this.Text = "Versus Bot";
            this.Click += new System.EventHandler(this.buttonClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button Btn9;
        private System.Windows.Forms.Label lblScore1;
        private System.Windows.Forms.Label lblScore2;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Timer timerAi;
        private System.Windows.Forms.Label label1;
    }
}

