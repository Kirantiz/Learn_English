namespace Learn_English
{
    partial class Step3Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Step3Form));
            this.BackToLessonsButton = new System.Windows.Forms.Button();
            this.QuestionText = new System.Windows.Forms.Label();
            this.EngWord = new System.Windows.Forms.Label();
            this.AnswerText = new System.Windows.Forms.TextBox();
            this.Check = new System.Windows.Forms.PictureBox();
            this.UnCheck = new System.Windows.Forms.PictureBox();
            this.OkButton = new System.Windows.Forms.PictureBox();
            this.NextButton = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Check)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OkButton)).BeginInit();
            this.SuspendLayout();
            // 
            // BackToLessonsButton
            // 
            this.BackToLessonsButton.BackColor = System.Drawing.Color.Plum;
            this.BackToLessonsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackToLessonsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackToLessonsButton.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToLessonsButton.Location = new System.Drawing.Point(79, 602);
            this.BackToLessonsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BackToLessonsButton.Name = "BackToLessonsButton";
            this.BackToLessonsButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BackToLessonsButton.Size = new System.Drawing.Size(257, 43);
            this.BackToLessonsButton.TabIndex = 0;
            this.BackToLessonsButton.Text = "BACK TO LESSONS";
            this.BackToLessonsButton.UseVisualStyleBackColor = false;
            this.BackToLessonsButton.Click += new System.EventHandler(this.BackToLessonsButton_Click);
            // 
            // QuestionText
            // 
            this.QuestionText.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.QuestionText.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionText.Location = new System.Drawing.Point(48, 23);
            this.QuestionText.Name = "QuestionText";
            this.QuestionText.Size = new System.Drawing.Size(318, 29);
            this.QuestionText.TabIndex = 2;
            this.QuestionText.Text = "Write the correct letter";
            // 
            // EngWord
            // 
            this.EngWord.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.EngWord.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EngWord.Location = new System.Drawing.Point(104, 199);
            this.EngWord.Name = "EngWord";
            this.EngWord.Size = new System.Drawing.Size(198, 29);
            this.EngWord.TabIndex = 3;
            this.EngWord.Text = "EngWord";
            this.EngWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AnswerText
            // 
            this.AnswerText.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.AnswerText.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnswerText.Location = new System.Drawing.Point(159, 275);
            this.AnswerText.MaxLength = 1;
            this.AnswerText.Name = "AnswerText";
            this.AnswerText.Size = new System.Drawing.Size(45, 35);
            this.AnswerText.TabIndex = 4;
            this.AnswerText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Check
            // 
            this.Check.BackColor = System.Drawing.Color.Transparent;
            this.Check.BackgroundImage = global::Learn_English.Properties.Resources.Check2;
            this.Check.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Check.Location = new System.Drawing.Point(308, 185);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(51, 59);
            this.Check.TabIndex = 5;
            this.Check.TabStop = false;
            // 
            // UnCheck
            // 
            this.UnCheck.BackColor = System.Drawing.Color.Transparent;
            this.UnCheck.BackgroundImage = global::Learn_English.Properties.Resources.unCheck2;
            this.UnCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UnCheck.Location = new System.Drawing.Point(308, 185);
            this.UnCheck.Name = "UnCheck";
            this.UnCheck.Size = new System.Drawing.Size(51, 59);
            this.UnCheck.TabIndex = 6;
            this.UnCheck.TabStop = false;
            // 
            // OkButton
            // 
            this.OkButton.BackColor = System.Drawing.Color.Transparent;
            this.OkButton.BackgroundImage = global::Learn_English.Properties.Resources.OK_2;
            this.OkButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OkButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OkButton.Location = new System.Drawing.Point(230, 258);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(72, 65);
            this.OkButton.TabIndex = 7;
            this.OkButton.TabStop = false;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.Color.Transparent;
            this.NextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextButton.Location = new System.Drawing.Point(147, 496);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(114, 75);
            this.NextButton.TabIndex = 9;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // Step3Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Learn_English.Properties.Resources.Fon_step2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(407, 658);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.UnCheck);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.AnswerText);
            this.Controls.Add(this.EngWord);
            this.Controls.Add(this.QuestionText);
            this.Controls.Add(this.BackToLessonsButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Step3Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Step3Form";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Step3Form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Step3Form_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.Check)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OkButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackToLessonsButton;
        private System.Windows.Forms.Label QuestionText;
        private System.Windows.Forms.Label EngWord;
        private System.Windows.Forms.TextBox AnswerText;
        private System.Windows.Forms.PictureBox Check;
        private System.Windows.Forms.PictureBox UnCheck;
        private System.Windows.Forms.PictureBox OkButton;
        private System.Windows.Forms.Label NextButton;
    }
}