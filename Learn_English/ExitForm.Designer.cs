namespace Learn_English
{
    partial class ExitForm
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
            this.sureExitText = new System.Windows.Forms.Label();
            this.yesExitButton = new System.Windows.Forms.Button();
            this.noExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sureExitText
            // 
            this.sureExitText.AutoSize = true;
            this.sureExitText.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sureExitText.Location = new System.Drawing.Point(66, 19);
            this.sureExitText.Name = "sureExitText";
            this.sureExitText.Size = new System.Drawing.Size(361, 30);
            this.sureExitText.TabIndex = 0;
            this.sureExitText.Text = "Are you sure  you want to exit?";
            // 
            // yesExitButton
            // 
            this.yesExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yesExitButton.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesExitButton.Location = new System.Drawing.Point(12, 60);
            this.yesExitButton.Name = "yesExitButton";
            this.yesExitButton.Size = new System.Drawing.Size(154, 39);
            this.yesExitButton.TabIndex = 1;
            this.yesExitButton.Text = "YES";
            this.yesExitButton.UseVisualStyleBackColor = true;
            this.yesExitButton.Click += new System.EventHandler(this.yesExitButton_Click);
            // 
            // noExitButton
            // 
            this.noExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.noExitButton.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noExitButton.Location = new System.Drawing.Point(336, 60);
            this.noExitButton.Name = "noExitButton";
            this.noExitButton.Size = new System.Drawing.Size(154, 39);
            this.noExitButton.TabIndex = 2;
            this.noExitButton.Text = "NO";
            this.noExitButton.UseVisualStyleBackColor = true;
            this.noExitButton.Click += new System.EventHandler(this.noExitButton_Click);
            // 
            // ExitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(502, 111);
            this.Controls.Add(this.noExitButton);
            this.Controls.Add(this.yesExitButton);
            this.Controls.Add(this.sureExitText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExitForm";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sureExitText;
        private System.Windows.Forms.Button yesExitButton;
        private System.Windows.Forms.Button noExitButton;
    }
}