﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learn_English
{
    public partial class StartMenu : Form
    {
        public StartMenu()
        {
            InitializeComponent();
        }

        Point lastPoint;
        private void StartMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void StartMenu_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this.Close();
            ExitForm newExitForm = new ExitForm();
            newExitForm.Show();
        }

        private void beginnerButton_Click(object sender, EventArgs e)
        {
            
            BeginnerForm newBeginnerForm = new BeginnerForm(this);
            newBeginnerForm.Show();
            newBeginnerForm.Left = this.Left;
            newBeginnerForm.Top = this.Top;
        }

        private void elemantaryButton_Click(object sender, EventArgs e)
        {
            ElemantaryForm newElemantaryForm = new ElemantaryForm(this);
            newElemantaryForm.Show();
            newElemantaryForm.Left = this.Left;
            newElemantaryForm.Top = this.Top;
        }

        private void optionsButton_Click(object sender, EventArgs e)
        {
            AboutProgrammButton newAboutProgrammButton = new AboutProgrammButton(this);
            newAboutProgrammButton.Show();
            newAboutProgrammButton.Left = this.Left;
            newAboutProgrammButton.Top = this.Top;
        }
    }
}
