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
    public partial class BeginnerForm : Form
    {
        private StartMenu _startMenu;

        public BeginnerForm()
        {
            InitializeComponent();
        }

        public BeginnerForm(StartMenu startMenu)
        {
            InitializeComponent();

            _startMenu = startMenu;
            _startMenu.Hide();
        }
        Point lastPoint;
        private void BeginnerForm_MouseMove(object sender, MouseEventArgs e)
        {
           
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
                _startMenu.Left = this.Left;
                _startMenu.Top = this.Top;
            }

        }

        private void BeginnerForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void button1_Click(object sender, EventArgs e) //back to main menu
        {
            this.Close();
            _startMenu.Show();

            //   StartMenu newStartMenu = new StartMenu();
            //  newStartMenu.Show();

        }

        private void AlphaBetButton_Click(object sender, EventArgs e)
        {
            AlphabetForm newAlphabetForm = new AlphabetForm(this);
            newAlphabetForm.Show();
            newAlphabetForm.Left = this.Left;
            newAlphabetForm.Top = this.Top;
        }

        private void NumbersButton_Click(object sender, EventArgs e)
        {
            NumbersForm newNumbersForm = new NumbersForm(this);
            newNumbersForm.Show();
            newNumbersForm.Left = this.Left;
            newNumbersForm.Top = this.Top;
        }

        private void Step1Button_Click(object sender, EventArgs e)
        {
            Step1Form newStep1Form = new Step1Form(this);
            newStep1Form.Show();
            newStep1Form.Left = this.Left;
            newStep1Form.Top = this.Top;
        }

        private void Step2Button_Click(object sender, EventArgs e)
        {
            Step2Form newStep2Form = new Step2Form(this);
            newStep2Form.Show();
            newStep2Form.Left = this.Left;
            newStep2Form.Top = this.Top;
        }
    }
}
