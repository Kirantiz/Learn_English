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
    public partial class NumbersForm : Form
    {
        private BeginnerForm _BeginnerMenu;
        public NumbersForm()
        {
            InitializeComponent();
        }
        
        public NumbersForm(BeginnerForm BeginnerMenu)
        {
            InitializeComponent();
            _BeginnerMenu = BeginnerMenu;
            _BeginnerMenu.Hide();
        }


        Point lastPoint;
        private void NumbersForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
                _BeginnerMenu.Left = this.Left;
                _BeginnerMenu.Top = this.Top;
            }
        }

        private void NumbersForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void BackToLessonsButton_Click(object sender, EventArgs e)
        {
            NumberInText.Text = "Click on the number";
            this.Close();
            _BeginnerMenu.Show();
        }


        private void Number2_Click(object sender, EventArgs e)
        {
            NumberInText.Text = "Two";
        }

        private void Number1_Click(object sender, EventArgs e)
        {
            NumberInText.Text = "One";
        }

        private void Number3_Click(object sender, EventArgs e)
        {
            NumberInText.Text = "Three";
        }

        private void Number4_Click(object sender, EventArgs e)
        {
            NumberInText.Text = "Four";
        }

        private void Number5_Click(object sender, EventArgs e)
        {
            NumberInText.Text = "Five";
        }

        private void Number6_Click(object sender, EventArgs e)
        {
            NumberInText.Text = "Six";
        }

        private void Number7_Click(object sender, EventArgs e)
        {
            NumberInText.Text = "Seven";
        }

        private void Number8_Click(object sender, EventArgs e)
        {
            NumberInText.Text = "Eight";
        }

        private void Number9_Click(object sender, EventArgs e)
        {
            NumberInText.Text = "Nine";
        }

        private void Number10_Click(object sender, EventArgs e)
        {
            NumberInText.Text = "Ten";
        }

        private void Number11_Click(object sender, EventArgs e)
        {
            NumberInText.Text = "Eleven";
        }

        private void Number12_Click(object sender, EventArgs e)
        {
            NumberInText.Text = "Twelve";
        }

        private void Number13_Click(object sender, EventArgs e)
        {
            NumberInText.Text = "Thirteen";
        }

        private void Number14_Click(object sender, EventArgs e)
        {
            NumberInText.Text = "Fourteen";
        }

        private void Number15_Click(object sender, EventArgs e)
        {
            NumberInText.Text = "Fifteen";
        }

        private void Number16_Click(object sender, EventArgs e)
        {
            NumberInText.Text = "Sixteen";
        }

        private void Number17_Click(object sender, EventArgs e)
        {
            NumberInText.Text = "Seventeen";
        }

        private void Number18_Click(object sender, EventArgs e)
        {
            NumberInText.Text = "Eighteen";
        }

        private void Number19_Click(object sender, EventArgs e)
        {
            NumberInText.Text = "Nineteen";
        }

        private void Number20_Click(object sender, EventArgs e)
        {
            NumberInText.Text = "Twenty";
        }
    }
}
