namespace C__Project
{
    partial class FlappyBird
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
            this.Scores = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.quit = new System.Windows.Forms.PictureBox();
            this.retry = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipeDown = new System.Windows.Forms.PictureBox();
            this.pipeUp = new System.Windows.Forms.PictureBox();
            this.fbird = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.quit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fbird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Scores
            // 
            this.Scores.AutoSize = true;
            this.Scores.BackColor = System.Drawing.Color.Chocolate;
            this.Scores.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scores.ForeColor = System.Drawing.Color.White;
            this.Scores.Location = new System.Drawing.Point(389, 23);
            this.Scores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Scores.Name = "Scores";
            this.Scores.Size = new System.Drawing.Size(161, 38);
            this.Scores.TabIndex = 0;
            this.Scores.Text = "SCORE : 0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(419, 226);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Press R to Retry";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(419, 321);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Press Q to Quit";
            // 
            // quit
            // 
            this.quit.BackColor = System.Drawing.Color.Transparent;
            this.quit.Image = global::C__Project.Properties.Resources.quitt_removebg_preview;
            this.quit.Location = new System.Drawing.Point(404, 268);
            this.quit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(143, 49);
            this.quit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.quit.TabIndex = 8;
            this.quit.TabStop = false;
            this.quit.Click += new System.EventHandler(this.QuitClickEvent);
            // 
            // retry
            // 
            this.retry.BackColor = System.Drawing.Color.Transparent;
            this.retry.Image = global::C__Project.Properties.Resources.btnss_removebg_preview;
            this.retry.Location = new System.Drawing.Point(412, 166);
            this.retry.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.retry.Name = "retry";
            this.retry.Size = new System.Drawing.Size(143, 57);
            this.retry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.retry.TabIndex = 7;
            this.retry.TabStop = false;
            this.retry.Click += new System.EventHandler(this.RestartClickEvent);
            // 
            // ground
            // 
            this.ground.BackColor = System.Drawing.Color.Transparent;
            this.ground.Image = global::C__Project.Properties.Resources.istockphoto_1404630832_612x612;
            this.ground.Location = new System.Drawing.Point(-23, 438);
            this.ground.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(1007, 133);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 4;
            this.ground.TabStop = false;
            // 
            // pipeDown
            // 
            this.pipeDown.BackColor = System.Drawing.Color.Transparent;
            this.pipeDown.Image = global::C__Project.Properties.Resources.logg_removebg_preview;
            this.pipeDown.Location = new System.Drawing.Point(668, 321);
            this.pipeDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pipeDown.Name = "pipeDown";
            this.pipeDown.Size = new System.Drawing.Size(113, 185);
            this.pipeDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeDown.TabIndex = 3;
            this.pipeDown.TabStop = false;
            // 
            // pipeUp
            // 
            this.pipeUp.BackColor = System.Drawing.Color.Transparent;
            this.pipeUp.Image = global::C__Project.Properties.Resources.loggg_removebg_preview;
            this.pipeUp.Location = new System.Drawing.Point(668, -14);
            this.pipeUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pipeUp.Name = "pipeUp";
            this.pipeUp.Size = new System.Drawing.Size(113, 155);
            this.pipeUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeUp.TabIndex = 2;
            this.pipeUp.TabStop = false;
            this.pipeUp.Click += new System.EventHandler(this.pipeUp_Click);
            // 
            // fbird
            // 
            this.fbird.BackColor = System.Drawing.Color.Transparent;
            this.fbird.Image = global::C__Project.Properties.Resources.owl_removebg_preview;
            this.fbird.Location = new System.Drawing.Point(95, 71);
            this.fbird.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fbird.Name = "fbird";
            this.fbird.Size = new System.Drawing.Size(80, 70);
            this.fbird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fbird.TabIndex = 1;
            this.fbird.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::C__Project.Properties.Resources.btnnss_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(344, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // FlappyBird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::C__Project.Properties.Resources.forest4;
            this.ClientSize = new System.Drawing.Size(967, 553);
            this.Controls.Add(this.Scores);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.retry);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipeDown);
            this.Controls.Add(this.pipeUp);
            this.Controls.Add(this.fbird);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FlappyBird";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form4_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form4_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.quit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fbird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Scores;
        private System.Windows.Forms.PictureBox fbird;
        private System.Windows.Forms.PictureBox pipeUp;
        private System.Windows.Forms.PictureBox pipeDown;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox retry;
        private System.Windows.Forms.PictureBox quit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}