namespace Learn_English
{
    partial class AlphabetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlphabetForm));
            this.BackToLessonsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackToLessonsButton
            // 
            this.BackToLessonsButton.BackColor = System.Drawing.Color.Plum;
            this.BackToLessonsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackToLessonsButton.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToLessonsButton.Location = new System.Drawing.Point(79, 602);
            this.BackToLessonsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BackToLessonsButton.Name = "BackToLessonsButton";
            this.BackToLessonsButton.Size = new System.Drawing.Size(257, 43);
            this.BackToLessonsButton.TabIndex = 0;
            this.BackToLessonsButton.Text = "BACK TO LESSONS";
            this.BackToLessonsButton.UseVisualStyleBackColor = false;
            this.BackToLessonsButton.Click += new System.EventHandler(this.BackToLessonsButton_Click);
            // 
            // AlphabetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Learn_English.Properties.Resources.Fon_is_blue_Alphabet_final;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(407, 658);
            this.Controls.Add(this.BackToLessonsButton);
            this.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "AlphabetForm";
            this.Text = "AlphabetForm";
            this.TopMost = true;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AlphabetForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AlphabetForm_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackToLessonsButton;
    }
}