namespace C__Project
{
    partial class GuessingGame
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
            this.txt_Enternumber = new System.Windows.Forms.TextBox();
            this.lblGuessed = new System.Windows.Forms.Label();
            this.Check = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Proxy 6", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(268, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a number between 1 and 100";
            // 
            // txt_Enternumber
            // 
            this.txt_Enternumber.AccessibleName = "txt_Enternumber";
            this.txt_Enternumber.BackColor = System.Drawing.Color.PeachPuff;
            this.txt_Enternumber.Location = new System.Drawing.Point(353, 190);
            this.txt_Enternumber.Name = "txt_Enternumber";
            this.txt_Enternumber.Size = new System.Drawing.Size(280, 22);
            this.txt_Enternumber.TabIndex = 1;
            // 
            // lblGuessed
            // 
            this.lblGuessed.AccessibleName = "lblGuessed";
            this.lblGuessed.AutoSize = true;
            this.lblGuessed.BackColor = System.Drawing.Color.RosyBrown;
            this.lblGuessed.Font = new System.Drawing.Font("MS PGothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuessed.ForeColor = System.Drawing.Color.Black;
            this.lblGuessed.Location = new System.Drawing.Point(411, 274);
            this.lblGuessed.Name = "lblGuessed";
            this.lblGuessed.Size = new System.Drawing.Size(24, 17);
            this.lblGuessed.TabIndex = 2;
            this.lblGuessed.Text = "~~";
            // 
            // Check
            // 
            this.Check.AccessibleName = "Check";
            this.Check.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Check.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Check.Location = new System.Drawing.Point(263, 352);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(149, 60);
            this.Check.TabIndex = 3;
            this.Check.Text = "Check";
            this.Check.UseVisualStyleBackColor = false;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // Exit
            // 
            this.Exit.AccessibleName = "Exit";
            this.Exit.BackColor = System.Drawing.Color.Tan;
            this.Exit.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(575, 352);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(149, 60);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // GuessingGame
            // 
            this.AccessibleName = "GuessingGame";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.BackgroundImage = global::C__Project.Properties.Resources.Nature_Happy_Earth_Day_Facebook_Post__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(938, 617);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.lblGuessed);
            this.Controls.Add(this.txt_Enternumber);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "GuessingGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guessing Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Enternumber;
        private System.Windows.Forms.Label lblGuessed;
        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.Button Exit;
    }
}