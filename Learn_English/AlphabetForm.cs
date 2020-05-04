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
    public partial class AlphabetForm : Form
    {
        //private StartMenu _startMenu;
        private BeginnerForm _BeginnerMenu;

        public AlphabetForm()
        {
            InitializeComponent();
        }


        public AlphabetForm(BeginnerForm BeginnerMenu)
        {
            InitializeComponent();
            _BeginnerMenu = BeginnerMenu;
            _BeginnerMenu.Hide();
        }

        Point lastPoint;
        private void AlphabetForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
                _BeginnerMenu.Left = this.Left;
                _BeginnerMenu.Top = this.Top;
            }
        }

        private void AlphabetForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void BackToLessonsButton_Click(object sender, EventArgs e)
        {
            this.Close();
            _BeginnerMenu.Show();
            
        }
    }
}
