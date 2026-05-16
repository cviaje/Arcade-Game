namespace C__Project
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.GuessingGame = new System.Windows.Forms.Button();
            this.TicTactoe = new System.Windows.Forms.Button();
            this.Credits = new System.Windows.Forms.Button();
            this.FlappyBird1 = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.logo1 = new System.Windows.Forms.PictureBox();
            this.logo2 = new System.Windows.Forms.PictureBox();
            this.logo3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(204, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Compilation of C# Games in ITEC21";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // GuessingGame
            // 
            this.GuessingGame.AccessibleName = "GuessingGame";
            this.GuessingGame.BackColor = System.Drawing.Color.Bisque;
            this.GuessingGame.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuessingGame.ForeColor = System.Drawing.Color.OliveDrab;
            this.GuessingGame.Location = new System.Drawing.Point(324, 143);
            this.GuessingGame.Margin = new System.Windows.Forms.Padding(2);
            this.GuessingGame.Name = "GuessingGame";
            this.GuessingGame.Size = new System.Drawing.Size(165, 33);
            this.GuessingGame.TabIndex = 1;
            this.GuessingGame.Text = "Guessing Game";
            this.GuessingGame.UseVisualStyleBackColor = false;
            this.GuessingGame.Click += new System.EventHandler(this.GuessingGame_Click);
            // 
            // TicTactoe
            // 
            this.TicTactoe.AccessibleName = "";
            this.TicTactoe.BackColor = System.Drawing.Color.PeachPuff;
            this.TicTactoe.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicTactoe.ForeColor = System.Drawing.Color.IndianRed;
            this.TicTactoe.Location = new System.Drawing.Point(324, 240);
            this.TicTactoe.Margin = new System.Windows.Forms.Padding(2);
            this.TicTactoe.Name = "TicTactoe";
            this.TicTactoe.Size = new System.Drawing.Size(165, 33);
            this.TicTactoe.TabIndex = 2;
            this.TicTactoe.Text = "Tic Tac Toe";
            this.TicTactoe.UseVisualStyleBackColor = false;
            this.TicTactoe.Click += new System.EventHandler(this.TicTactoe_Click);
            // 
            // Credits
            // 
            this.Credits.AccessibleName = "Credits";
            this.Credits.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.Credits.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Credits.ForeColor = System.Drawing.Color.Olive;
            this.Credits.Location = new System.Drawing.Point(292, 317);
            this.Credits.Margin = new System.Windows.Forms.Padding(2);
            this.Credits.Name = "Credits";
            this.Credits.Size = new System.Drawing.Size(67, 35);
            this.Credits.TabIndex = 3;
            this.Credits.Text = "Credits";
            this.Credits.UseVisualStyleBackColor = false;
            this.Credits.Click += new System.EventHandler(this.Credits_Click);
            // 
            // FlappyBird1
            // 
            this.FlappyBird1.AccessibleName = "FlappyBird1";
            this.FlappyBird1.BackColor = System.Drawing.Color.Wheat;
            this.FlappyBird1.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlappyBird1.ForeColor = System.Drawing.Color.OliveDrab;
            this.FlappyBird1.Location = new System.Drawing.Point(324, 191);
            this.FlappyBird1.Margin = new System.Windows.Forms.Padding(2);
            this.FlappyBird1.Name = "FlappyBird1";
            this.FlappyBird1.Size = new System.Drawing.Size(165, 33);
            this.FlappyBird1.TabIndex = 5;
            this.FlappyBird1.Text = "Flappy Bird";
            this.FlappyBird1.UseVisualStyleBackColor = false;
            this.FlappyBird1.Click += new System.EventHandler(this.FlappyBird_Click);
            // 
            // Exit
            // 
            this.Exit.AccessibleName = "Exit";
            this.Exit.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.Exit.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.Olive;
            this.Exit.Location = new System.Drawing.Point(453, 317);
            this.Exit.Margin = new System.Windows.Forms.Padding(2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(66, 35);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(102, 453);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(584, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(318, 419);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Loading...";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timerrrr);
            // 
            // logo1
            // 
            this.logo1.BackColor = System.Drawing.Color.Transparent;
            this.logo1.Image = global::C__Project.Properties.Resources.guessing_removebg_preview1;
            this.logo1.Location = new System.Drawing.Point(264, 120);
            this.logo1.Name = "logo1";
            this.logo1.Size = new System.Drawing.Size(51, 56);
            this.logo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo1.TabIndex = 9;
            this.logo1.TabStop = false;
            // 
            // logo2
            // 
            this.logo2.BackColor = System.Drawing.Color.Transparent;
            this.logo2.Image = global::C__Project.Properties.Resources.owl_removebg_preview;
            this.logo2.Location = new System.Drawing.Point(261, 182);
            this.logo2.Name = "logo2";
            this.logo2.Size = new System.Drawing.Size(54, 42);
            this.logo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo2.TabIndex = 10;
            this.logo2.TabStop = false;
            // 
            // logo3
            // 
            this.logo3.BackColor = System.Drawing.Color.Transparent;
            this.logo3.Image = global::C__Project.Properties.Resources.il_fullxfull1;
            this.logo3.Location = new System.Drawing.Point(256, 230);
            this.logo3.Name = "logo3";
            this.logo3.Size = new System.Drawing.Size(63, 65);
            this.logo3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo3.TabIndex = 11;
            this.logo3.TabStop = false;
            // 
            // Main_Menu
            // 
            this.AccessibleName = "Main_Menu";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::C__Project.Properties.Resources.istockphoto_1333010525_612x612;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(777, 488);
            this.Controls.Add(this.logo3);
            this.Controls.Add(this.logo2);
            this.Controls.Add(this.logo1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.FlappyBird1);
            this.Controls.Add(this.Credits);
            this.Controls.Add(this.TicTactoe);
            this.Controls.Add(this.GuessingGame);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Main Menu";
            this.Load += new System.EventHandler(this.Main_Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GuessingGame;
        private System.Windows.Forms.Button TicTactoe;
        private System.Windows.Forms.Button Credits;
        private System.Windows.Forms.Button FlappyBird1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox logo1;
        private System.Windows.Forms.PictureBox logo2;
        private System.Windows.Forms.PictureBox logo3;
    }
}