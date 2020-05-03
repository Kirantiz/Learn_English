using System;
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
    public partial class AboutProgrammButton : Form
    {
        private StartMenu _startMenu;
        public AboutProgrammButton(StartMenu startMenu)
        {
            InitializeComponent();
            _startMenu = startMenu;
            _startMenu.Hide();
        }

        Point lastPoint;
        private void AboutProgrammButton_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
                _startMenu.Left = this.Left;
                _startMenu.Top = this.Top;
            }
        }

        private void AboutProgrammButton_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void BackToMainMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
            _startMenu.Show();
        }

    }
}
