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
    public partial class Step3Form : Form
    {
        private BeginnerForm _BeginnerMenu;
        private char symbol;
        public Step3Form()
        {
            InitializeComponent();
        }
        
        public Step3Form(BeginnerForm BeginnerMenu)
        {
            InitializeComponent();
            _BeginnerMenu = BeginnerMenu;
            _BeginnerMenu.Hide();
            Check.Hide();
            UnCheck.Hide();
            WordLetter();
        }


        Point lastPoint;
        private void Step3Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
                _BeginnerMenu.Left = this.Left;
                _BeginnerMenu.Top = this.Top;
            }
        }

        private void Step3Form_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void BackToLessonsButton_Click(object sender, EventArgs e)
        {
            this.Close();
            _BeginnerMenu.Show();
        }

        //случайное слово из списка
        public string RandomWord()
        {
            Random randNum = new Random();
            int i;
            //массив с которого берём случайное слово
            string[] array = new string[]{"white","black","green","red","blue","yellow","pink",
                "brown","orange", "mum","dad", "sister", "brother", "granny", "grandad",
                "family", "cat", "dog","chicken","horse","cow","rabbit","mouse",
                "pig","sheep","hamster","duck","run","jump","swim","fly","climb","sing",
                "dance","read","write","crocodile","elephant","hippo","giraffe","monkey",
                "tiger","lion","bear","fox","head","face","ear","eye","hair","mouth",
                "nose","hands","fingers","meat","sausages","potato","bread","chocolate","icecream",
                "cheese","lemon","orange","banana","apple","carrot","cakes","sweets","pizza"
                ,"soup","fish","yummy","house","room","floor","door","window","table",
                "bed","chair","carpet","pupil","teacher","school","board","desk",
                "book","pen","pencil","rubber"};
            i = randNum.Next(0, 89);
            string word;
            word = array[i];
            // EngWord.Text = Convert.ToString( array.Length);
           // EngWord.Text = word;
            return word;
        }

        public void WordLetter()
        {
            Random randNum = new Random();
            int wordLenght,i;
            string engWord = RandomWord();
            wordLenght = engWord.Length;

            i = randNum.Next(1, wordLenght - 1);
            symbol = engWord[i];
            engWord = engWord.Replace(symbol, '*');
            EngWord.Text = engWord;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Check.Hide();
            UnCheck.Hide();
            EngWord.BackColor = Color.LightGoldenrodYellow;
            AnswerText.Clear();
            WordLetter();
            
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            char symbolAnswer;
            if (AnswerText.TextLength < 1) AnswerText.Text = "*";
            symbolAnswer = AnswerText.Text[0];

            if(symbolAnswer== symbol) 
            {
                Check.Show();
                EngWord.BackColor = Color.Lime;
            }
            else
            {
                UnCheck.Show();
                EngWord.BackColor = Color.Red;
            }
        }
    }
}
