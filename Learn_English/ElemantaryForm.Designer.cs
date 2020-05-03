namespace Learn_English
{
    partial class ElemantaryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElemantaryForm));
            this.label1 = new System.Windows.Forms.Label();
            this.BacktoMenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "COMING SOON \r\nIN NEW VERSION";
            // 
            // BacktoMenuButton
            // 
            this.BacktoMenuButton.BackColor = System.Drawing.Color.Plum;
            this.BacktoMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BacktoMenuButton.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BacktoMenuButton.Location = new System.Drawing.Point(79, 602);
            this.BacktoMenuButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BacktoMenuButton.Name = "BacktoMenuButton";
            this.BacktoMenuButton.Size = new System.Drawing.Size(263, 43);
            this.BacktoMenuButton.TabIndex = 1;
            this.BacktoMenuButton.Text = "BACK TO MAIN MENU";
            this.BacktoMenuButton.UseVisualStyleBackColor = false;
            this.BacktoMenuButton.Click += new System.EventHandler(this.BacktoMenuButton_Click);
            // 
            // ElemantaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Learn_English.Properties.Resources.Fon3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(407, 658);
            this.Controls.Add(this.BacktoMenuButton);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "ElemantaryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ElemantaryForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ElemantaryForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ElemantaryForm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BacktoMenuButton;
    }
}