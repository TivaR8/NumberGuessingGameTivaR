namespace NumberGuessingGameTivaR
{
    partial class frmNumberGuessing
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.txtGuessBox = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblGotItRight = new System.Windows.Forms.Label();
            this.lblGotItWrong = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(12, 54);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(173, 13);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Guess a number between 1 and 10";
            // 
            // txtGuessBox
            // 
            this.txtGuessBox.Location = new System.Drawing.Point(227, 54);
            this.txtGuessBox.Name = "txtGuessBox";
            this.txtGuessBox.Size = new System.Drawing.Size(100, 20);
            this.txtGuessBox.TabIndex = 1;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(43, 130);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblGotItRight
            // 
            this.lblGotItRight.AutoSize = true;
            this.lblGotItRight.Location = new System.Drawing.Point(215, 117);
            this.lblGotItRight.Name = "lblGotItRight";
            this.lblGotItRight.Size = new System.Drawing.Size(80, 13);
            this.lblGotItRight.TabIndex = 3;
            this.lblGotItRight.Text = "You Got it right!";
            // 
            // lblGotItWrong
            // 
            this.lblGotItWrong.AutoSize = true;
            this.lblGotItWrong.Location = new System.Drawing.Point(207, 117);
            this.lblGotItWrong.Name = "lblGotItWrong";
            this.lblGotItWrong.Size = new System.Drawing.Size(120, 13);
            this.lblGotItWrong.TabIndex = 4;
            this.lblGotItWrong.Text = "You got it Wrong, Sorry.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NumberGuessingGameTivaR.Properties.Resources.checkmark;
            this.pictureBox1.Location = new System.Drawing.Point(193, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmNumberGuessing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 278);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblGotItWrong);
            this.Controls.Add(this.lblGotItRight);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtGuessBox);
            this.Controls.Add(this.lblQuestion);
            this.Name = "frmNumberGuessing";
            this.Text = "Number Guessing Game By Tiva Rait";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TextBox txtGuessBox;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblGotItRight;
        private System.Windows.Forms.Label lblGotItWrong;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

