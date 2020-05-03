namespace Learn_English
{
    partial class StartMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartMenu));
            this.beginnerButton = new System.Windows.Forms.Button();
            this.elemantaryButton = new System.Windows.Forms.Button();
            this.optionsButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // beginnerButton
            // 
            this.beginnerButton.BackColor = System.Drawing.Color.LimeGreen;
            this.beginnerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.beginnerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.beginnerButton.FlatAppearance.BorderSize = 0;
            this.beginnerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.beginnerButton.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beginnerButton.Location = new System.Drawing.Point(79, 183);
            this.beginnerButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.beginnerButton.Name = "beginnerButton";
            this.beginnerButton.Size = new System.Drawing.Size(246, 43);
            this.beginnerButton.TabIndex = 0;
            this.beginnerButton.Text = "BEGINNER";
            this.beginnerButton.UseVisualStyleBackColor = false;
            this.beginnerButton.Click += new System.EventHandler(this.beginnerButton_Click);
            // 
            // elemantaryButton
            // 
            this.elemantaryButton.BackColor = System.Drawing.Color.Yellow;
            this.elemantaryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.elemantaryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.elemantaryButton.FlatAppearance.BorderSize = 0;
            this.elemantaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.elemantaryButton.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elemantaryButton.Location = new System.Drawing.Point(79, 256);
            this.elemantaryButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.elemantaryButton.Name = "elemantaryButton";
            this.elemantaryButton.Size = new System.Drawing.Size(246, 43);
            this.elemantaryButton.TabIndex = 1;
            this.elemantaryButton.Text = "ELEMANTARY";
            this.elemantaryButton.UseVisualStyleBackColor = false;
            this.elemantaryButton.Click += new System.EventHandler(this.elemantaryButton_Click);
            // 
            // optionsButton
            // 
            this.optionsButton.BackColor = System.Drawing.Color.Orange;
            this.optionsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.optionsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.optionsButton.FlatAppearance.BorderSize = 0;
            this.optionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optionsButton.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsButton.Location = new System.Drawing.Point(79, 547);
            this.optionsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.optionsButton.Name = "optionsButton";
            this.optionsButton.Size = new System.Drawing.Size(246, 43);
            this.optionsButton.TabIndex = 2;
            this.optionsButton.Text = "OPTIONS";
            this.optionsButton.UseVisualStyleBackColor = false;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Plum;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(79, 608);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(246, 43);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Learn_English.Properties.Resources.Fon3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(407, 658);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.optionsButton);
            this.Controls.Add(this.elemantaryButton);
            this.Controls.Add(this.beginnerButton);
            this.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "StartMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LEARN ENGLISH";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StartMenu_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.StartMenu_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button beginnerButton;
        private System.Windows.Forms.Button elemantaryButton;
        private System.Windows.Forms.Button optionsButton;
        private System.Windows.Forms.Button exitButton;
    }
}