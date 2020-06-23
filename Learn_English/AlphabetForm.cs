using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Media;
using System.IO;

namespace Learn_English
{
    public partial class AlphabetForm : Form
    {
       // string SqlStr = "Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\Git\\Learn_English\\Learn_English\\LearnEnglishDB.mdf;Integrated Security = True";
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
          public string SqlWav(string Letter)
          {

            Letter = path + Letter.ToLower() + ".wav";

            return Letter;


            /*  using (var connection = new SqlConnection(SqlStr))
              {
                  connection.Open();
                  using (var cmd = new SqlCommand($"SELECT (Path+FileName) FROM Alphabet WHERE [Letter] ='{Letter}'", connection))
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
              }
        */
          }
          

        string path = Environment.CurrentDirectory + "/Alphabet/";

        private void LetterA_Click(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer(SqlWav("A"));
            Simple.Play();
        }

        private void LetterB_Click(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer(SqlWav("B"));
            Simple.Play();
        }

        private void LetterC_Click(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer(SqlWav("C"));
            Simple.Play();
        }

        private void LetterD_Click(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer(SqlWav("D"));
            Simple.Play();
        }

        private void LetterE_Click(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer(SqlWav("E"));
            Simple.Play();
        }

        private void LetterF_Click(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer(SqlWav("F"));
            Simple.Play();
        }

        private void LetterG_Click(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer(SqlWav("G"));
            Simple.Play();
        }

        private void LetterH_Click(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer(SqlWav("H"));
            Simple.Play();
        }

        private void LetterI_Click(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer(SqlWav("I"));
            Simple.Play();
        }

        private void LeteerJ_Click(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer(SqlWav("J"));
            Simple.Play();
        }

        private void LetterK_Click(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer(SqlWav("K"));
            Simple.Play();
        }

        private void LetterL_Click(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer(SqlWav("L"));
            Simple.Play();
        }

        private void LetterM_Click(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer(SqlWav("M"));
            Simple.Play();
        }

        private void LetterN_Click(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer(SqlWav("N"));
            Simple.Play();
        }

        private void LetterO_Click(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer(SqlWav("O"));
            Simple.Play();
        }

        private void LetterP_Click(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer(SqlWav("P"));
            Simple.Play();
        }

        private void LetterQ_Click(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer(SqlWav("Q"));
            Simple.Play();
        }

        private void LetterR_Click(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer(SqlWav("R"));
            Simple.Play();
        }

        private void LetterS_Click(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer(SqlWav("S"));
            Simple.Play();
        }

        private void LetterT_Click(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer(SqlWav("T"));
            Simple.Play();
        }

        private void LetterU_Click(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer(SqlWav("U"));
            Simple.Play();
        }

        private void LetterV_Click(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer(SqlWav("V"));
            Simple.Play();
        }

        private void LetterW_Click(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer(SqlWav("W"));
            Simple.Play();
        }

        private void LetterX_Click(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer(SqlWav("X"));
            Simple.Play();
        }

        private void LetterY_Click(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer(SqlWav("Y"));
            Simple.Play();
        }

        private void LetterZ_Click(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer(SqlWav("Z"));
            Simple.Play();
        }
    }
}
