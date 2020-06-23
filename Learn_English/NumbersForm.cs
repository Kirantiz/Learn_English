using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Data.SqlClient;


namespace Learn_English
{
    public partial class NumbersForm : Form
    {
      //  string SqlStr = "Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\Git\\Learn_English\\Learn_English\\LearnEnglishDB.mdf;Integrated Security = True";
        private BeginnerForm _BeginnerMenu;
        public NumbersForm()
        {
            InitializeComponent();

        }


        string path = Environment.CurrentDirectory + "/Numbers/";

        public string SqlWav(string num)
        {

            num = path + num + ".wav";

            return num;
            /*
            using (var connection = new SqlConnection(SqlStr))
            {
                connection.Open();
                using (var cmd = new SqlCommand($"SELECT (Path+FileName) FROM Numbers WHERE Number ={num} ", connection))
                {
                    using (var rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            return rd.GetValue(0).ToString();
                        }
                        else return " ";
                    }
                }
            }*/
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
            SoundPlayer Simple = new SoundPlayer(SqlWav("2"));
            Simple.Play();
        }

        private void Number1_Click(object sender, EventArgs e)
        {
            NumberInText.Text = "One";
            SoundPlayer Simple = new SoundPlayer(SqlWav("1"));
            Simple.Play();
        }

        private void Number3_Click(object sender, EventArgs e)
        {
            NumberInText.Text = "Three";
            SoundPlayer Simple = new SoundPlayer(SqlWav("3"));
            Simple.Play();
        }

        private void Number4_Click(object sender, EventArgs e)
        {
            NumberInText.Text = "Four";
            SoundPlayer Simple = new SoundPlayer(SqlWav("4"));
            Simple.Play();
        }

        private void Number5_Click(object sender, EventArgs e)
        {
            NumberInText.Text = "Five";
            SoundPlayer Simple = new SoundPlayer(SqlWav("5"));
            Simple.Play();
        }

        private void Number6_Click(object sender, EventArgs e)
        {
            NumberInText.Text = "Six";
            SoundPlayer Simple = new SoundPlayer(SqlWav("6"));
            Simple.Play();
        }

        private void Number7_Click(object sender, EventArgs e)
        {
            NumberInText.Text = "Seven";
            SoundPlayer Simple = new SoundPlayer(SqlWav("7"));
            Simple.Play();
        }

        private void Number8_Click(object sender, EventArgs e)
        {
            NumberInText.Text = "Eight";
            SoundPlayer Simple = new SoundPlayer(SqlWav("8"));
            Simple.Play();
        }

        private void Number9_Click(object sender, EventArgs e)
        {
            NumberInText.Text = "Nine";
            SoundPlayer Simple = new SoundPlayer(SqlWav("9"));
            Simple.Play();
        }

        private void Number10_Click(object sender, EventArgs e)
        {
            NumberInText.Text = "Ten";
            SoundPlayer Simple = new SoundPlayer(SqlWav("10"));
            Simple.Play();
        }

        private void Number11_Click(object sender, EventArgs e)
        {
            NumberInText.Text = "Eleven";
            SoundPlayer Simple = new SoundPlayer(SqlWav("11"));
            Simple.Play();
        }

        private void Number12_Click(object sender, EventArgs e)
        {
            NumberInText.Text = "Twelve";
            SoundPlayer Simple = new SoundPlayer(SqlWav("12"));
            Simple.Play();
        }

        private void Number13_Click(object sender, EventArgs e)
        {
            NumberInText.Text = "Thirteen";
            SoundPlayer Simple = new SoundPlayer(SqlWav("13"));
            Simple.Play();
        }

        private void Number14_Click(object sender, EventArgs e)
        {
            NumberInText.Text = "Fourteen";
            SoundPlayer Simple = new SoundPlayer(SqlWav("14"));
            Simple.Play();
        }

        private void Number15_Click(object sender, EventArgs e)
        {
            NumberInText.Text = "Fifteen";
            SoundPlayer Simple = new SoundPlayer(SqlWav("15"));
            Simple.Play();
        }

        private void Number16_Click(object sender, EventArgs e)
        {
            NumberInText.Text = "Sixteen";
            SoundPlayer Simple = new SoundPlayer(SqlWav("16"));
            Simple.Play();
        }

        private void Number17_Click(object sender, EventArgs e)
        {
            NumberInText.Text = "Seventeen";
            SoundPlayer Simple = new SoundPlayer(SqlWav("17"));
            Simple.Play();
        }

        private void Number18_Click(object sender, EventArgs e)
        {
            NumberInText.Text = "Eighteen";
            SoundPlayer Simple = new SoundPlayer(SqlWav("18"));
            Simple.Play();
        }

        private void Number19_Click(object sender, EventArgs e)
        {
            NumberInText.Text = "Nineteen";
            SoundPlayer Simple = new SoundPlayer(SqlWav("19"));
            Simple.Play();
        }

        private void Number20_Click(object sender, EventArgs e)
        {
            NumberInText.Text = "Twenty";
            SoundPlayer Simple = new SoundPlayer(SqlWav("20"));
            Simple.Play();
        }
       
    }
}
