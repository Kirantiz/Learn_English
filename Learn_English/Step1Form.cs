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

namespace Learn_English
{
    public partial class Step1Form : Form
    {
        string SqlStr = "Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\Git\\Learn_English\\Learn_English\\LearnEnglishDB.mdf;Integrated Security = True";
        private BeginnerForm _BeginnerMenu;
        public int PageNum;
        public Step1Form()
        {
            InitializeComponent();
        }

        public Step1Form(BeginnerForm BeginnerMenu)
        {
            InitializeComponent();
            _BeginnerMenu = BeginnerMenu;
            _BeginnerMenu.Hide();
        }

        Point lastPoint;
        private void Step1Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
                _BeginnerMenu.Left = this.Left;
                _BeginnerMenu.Top = this.Top;
            }
        }

        private void Step1Form_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void BackToLessonsButton_Click(object sender, EventArgs e)
        {
            this.Close();
            _BeginnerMenu.Show();
        }

        private void ArrowRight_Click(object sender, EventArgs e)
        {
            PageNum = Convert.ToInt32(NpageStep1.Text);
            PageNum++;
            if (PageNum > 10) PageNum--;
            NpageStep1.Text = Convert.ToString(PageNum);
            if (PageNum == 1) Topic1();
            if (PageNum == 2) Topic2();
            if (PageNum == 3) Topic3();
            if (PageNum == 4) Topic4();
            if (PageNum == 5) Topic5();
            if (PageNum == 6) Topic6();
            if (PageNum == 7) Topic7();
            if (PageNum == 8) Topic8();
            if (PageNum == 9) Topic9();
            if (PageNum == 10) Topic10();
        }

        private void ArrowLeft_Click(object sender, EventArgs e)
        {
            PageNum = Convert.ToInt32(NpageStep1.Text);
            PageNum--;
            if (PageNum < 1) PageNum++;
            NpageStep1.Text = Convert.ToString(PageNum);
            if (PageNum == 1) Topic1();
            if (PageNum == 2) Topic2();
            if (PageNum == 3) Topic3();
            if (PageNum == 4) Topic4();
            if (PageNum == 5) Topic5();
            if (PageNum == 6) Topic6();
            if (PageNum == 7) Topic7();
            if (PageNum == 8) Topic8();
            if (PageNum == 9) Topic9();
            if (PageNum == 10) Topic10();
        }

        public void Topic1()
        {
            TopicText.Text = "COLORS";
            EngWord1Text.Text = "white"; RusWord1Text.Text = "белый";
            EngWord2Text.Text = "black"; RusWord2Text.Text = "чёрный";
            EngWord3Text.Text = "green"; RusWord3Text.Text = "зелёный";
            EngWord4Text.Text = "red"; RusWord4Text.Text = "красный";
            EngWord5Text.Text = "blue"; RusWord5Text.Text = "синий";
            EngWord6Text.Text = "yellow"; RusWord6Text.Text = "жёлтый";
            EngWord7Text.Text = "pink"; RusWord7Text.Text = "розовый";
            EngWord8Text.Text = "brown"; RusWord8Text.Text = "коричневый";
            EngWord9Text.Text = "orange"; RusWord9Text.Text = "оранжевый";
        }


        public void Topic2()
        {
            TopicText.Text = "FAMILY";
            EngWord1Text.Text = "a mum"; RusWord1Text.Text = "мама";
            EngWord2Text.Text = "a dad"; RusWord2Text.Text = "папа";
            EngWord3Text.Text = "a sister"; RusWord3Text.Text = "сестра";
            EngWord4Text.Text = "a brother"; RusWord4Text.Text = "брат";
            EngWord5Text.Text = "a granny"; RusWord5Text.Text = "бабушка";
            EngWord6Text.Text = "a grandad"; RusWord6Text.Text = "дедушка";
            EngWord7Text.Text = "a family"; RusWord7Text.Text = "семья";
            EngWord8Text.Text = "a cat"; RusWord8Text.Text = "кошка";
            EngWord9Text.Text = "a dog"; RusWord9Text.Text = "собака";
        }

        public void Topic3()
        {
            TopicText.Text = "I LOVE ANIMALS";
            EngWord1Text.Text = "a chicken"; RusWord1Text.Text = "цыпленок";
            EngWord2Text.Text = "a horse"; RusWord2Text.Text = "лошадь";
            EngWord3Text.Text = "a cow"; RusWord3Text.Text = "корова";
            EngWord4Text.Text = "a rabbit"; RusWord4Text.Text = "кролик";
            EngWord5Text.Text = "a mouse"; RusWord5Text.Text = "мышь";
            EngWord6Text.Text = "a pig"; RusWord6Text.Text = "свинья";
            EngWord7Text.Text = "a sheep"; RusWord7Text.Text = "овца";
            EngWord8Text.Text = "a hamster"; RusWord8Text.Text = "хомяк";
            EngWord9Text.Text = "a duck"; RusWord9Text.Text = "утка";
        }

        public void Topic4()
        {
            TopicText.Text = "I CAN";
            EngWord1Text.Text = "run"; RusWord1Text.Text = "бегать";
            EngWord2Text.Text = "jump"; RusWord2Text.Text = "прыгать";
            EngWord3Text.Text = "swim"; RusWord3Text.Text = "плавать";
            EngWord4Text.Text = "fly"; RusWord4Text.Text = "летать";
            EngWord5Text.Text = "climb"; RusWord5Text.Text = "лезть";
            EngWord6Text.Text = "sing"; RusWord6Text.Text = "петь";
            EngWord7Text.Text = "dance"; RusWord7Text.Text = "танцевать";
            EngWord8Text.Text = "read"; RusWord8Text.Text = "читать";
            EngWord9Text.Text = "write"; RusWord9Text.Text = "писать";
        }

        public void Topic5()
        {
            TopicText.Text = "MY TOYS";
            EngWord1Text.Text = "a crocodile"; RusWord1Text.Text = "крокодил";
            EngWord2Text.Text = "an elephant"; RusWord2Text.Text = "слон";
            EngWord3Text.Text = "a hippo"; RusWord3Text.Text = "бегемот";
            EngWord4Text.Text = "a giraffe"; RusWord4Text.Text = "жираф";
            EngWord5Text.Text = "a monkey"; RusWord5Text.Text = "обезьяна";
            EngWord6Text.Text = "a tiger"; RusWord6Text.Text = "тигр";
            EngWord7Text.Text = "a lion"; RusWord7Text.Text = "лев";
            EngWord8Text.Text = "a bear"; RusWord8Text.Text = "медведь";
            EngWord9Text.Text = "a fox"; RusWord9Text.Text = "лиса";
        }

        public void Topic6()
        {
            TopicText.Text = "MY BODY";
            EngWord1Text.Text = "a head"; RusWord1Text.Text = "голова";
            EngWord2Text.Text = "a face"; RusWord2Text.Text = "лицо";
            EngWord3Text.Text = "an ear"; RusWord3Text.Text = "ухо";
            EngWord4Text.Text = "an eye"; RusWord4Text.Text = "глаз";
            EngWord5Text.Text = "hair"; RusWord5Text.Text = "волосы";
            EngWord6Text.Text = "a mouth"; RusWord6Text.Text = "рот";
            EngWord7Text.Text = "a nose"; RusWord7Text.Text = "нос";
            EngWord8Text.Text = "hands"; RusWord8Text.Text = "руки";
            EngWord9Text.Text = "fingers"; RusWord9Text.Text = "пальцы";
        }

        public void Topic7()
        {
            TopicText.Text = "YUMMY! PART-1";
            EngWord1Text.Text = "meat"; RusWord1Text.Text = "мясо";
            EngWord2Text.Text = "sausages"; RusWord2Text.Text = "сосиски";
            EngWord3Text.Text = "a potato"; RusWord3Text.Text = "картофель";
            EngWord4Text.Text = "bread"; RusWord4Text.Text = "хлеб";
            EngWord5Text.Text = "chocolate"; RusWord5Text.Text = "шоколад";
            EngWord6Text.Text = "icecream"; RusWord6Text.Text = "мороженое";
            EngWord7Text.Text = "cheese"; RusWord7Text.Text = "сыр";
            EngWord8Text.Text = "a lemon"; RusWord8Text.Text = "лимон";
            EngWord9Text.Text = "an orange"; RusWord9Text.Text = "апельсин";
        }

        public void Topic8()
        {
            TopicText.Text = "YUMMY! PART-2";
            EngWord1Text.Text = "a banana"; RusWord1Text.Text = "банан";
            EngWord2Text.Text = "an apple"; RusWord2Text.Text = "яблоко";
            EngWord3Text.Text = "a carrot"; RusWord3Text.Text = "морковка";
            EngWord4Text.Text = "cakes"; RusWord4Text.Text = "пирожные";
            EngWord5Text.Text = "sweets"; RusWord5Text.Text = "конфеты";
            EngWord6Text.Text = "a pizza"; RusWord6Text.Text = "пицца";
            EngWord7Text.Text = "soup"; RusWord7Text.Text = "суп";
            EngWord8Text.Text = "fish"; RusWord8Text.Text = "рыба";
            EngWord9Text.Text = "yummy"; RusWord9Text.Text = "вкусно";
        }

        public void Topic9()
        {
            TopicText.Text = "MY HOME";
            EngWord1Text.Text = "a house"; RusWord1Text.Text = "дом";
            EngWord2Text.Text = "a room"; RusWord2Text.Text = "комната";
            EngWord3Text.Text = "the floor"; RusWord3Text.Text = "этаж";
            EngWord4Text.Text = "a door"; RusWord4Text.Text = "дверь";
            EngWord5Text.Text = "a window"; RusWord5Text.Text = "окно";
            EngWord6Text.Text = "a table"; RusWord6Text.Text = "стол";
            EngWord7Text.Text = "a bed"; RusWord7Text.Text = "кровать";
            EngWord8Text.Text = "a chair"; RusWord8Text.Text = "стул";
            EngWord9Text.Text = "a carpet"; RusWord9Text.Text = "ковёр";
        }

        public void Topic10()
        {
            TopicText.Text = "I AM PUPIL";
            EngWord1Text.Text = "a pupil"; RusWord1Text.Text = "ученик";
            EngWord2Text.Text = "a teacher"; RusWord2Text.Text = "учитель";
            EngWord3Text.Text = "a school"; RusWord3Text.Text = "школа";
            EngWord4Text.Text = "a board"; RusWord4Text.Text = "доска";
            EngWord5Text.Text = "a desk"; RusWord5Text.Text = "парта";
            EngWord6Text.Text = "a book"; RusWord6Text.Text = "книга";
            EngWord7Text.Text = "a pen"; RusWord7Text.Text = "ручка";
            EngWord8Text.Text = "a pencil"; RusWord8Text.Text = "карандаш";
            EngWord9Text.Text = "a rubber"; RusWord9Text.Text = "стирка";
        }

        public string SqlWav(string IdWord)
        {
            using (var connection = new SqlConnection(SqlStr))
            {
                connection.Open();
                using (var cmd = new SqlCommand($"SELECT (Path+FileName) FROM Step1 WHERE IdWord ={IdWord}", connection))
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
        }

        private void PlayButton1_Click(object sender, EventArgs e)
        {
            string wordID="1";
            if (PageNum == 1) wordID = "1";
            if (PageNum == 2) wordID = "10";
            if (PageNum == 3) wordID = "19";
            if (PageNum == 4) wordID = "28";
            if (PageNum == 5) wordID = "37";
            if (PageNum == 6) wordID = "46";
            if (PageNum == 7) wordID = "55";
            if (PageNum == 8) wordID = "64";
            if (PageNum == 9) wordID = "73";
            if (PageNum == 10) wordID = "82";
            SoundPlayer Simple = new SoundPlayer(SqlWav(wordID));
            Simple.Play();
        }

        private void PlayButton2_Click(object sender, EventArgs e)
        {
            string wordID = "1";
            if (PageNum == 1) wordID = "2";
            if (PageNum == 2) wordID = "11";
            if (PageNum == 3) wordID = "20";
            if (PageNum == 4) wordID = "29";
            if (PageNum == 5) wordID = "38";
            if (PageNum == 6) wordID = "47";
            if (PageNum == 7) wordID = "56";
            if (PageNum == 8) wordID = "65";
            if (PageNum == 9) wordID = "74";
            if (PageNum == 10) wordID = "83";
            SoundPlayer Simple = new SoundPlayer(SqlWav(wordID));
            Simple.Play();
        }

        private void PlayButton3_Click(object sender, EventArgs e)
        {
            string wordID = "1";
            if (PageNum == 1) wordID = "3";
            if (PageNum == 2) wordID = "12";
            if (PageNum == 3) wordID = "21";
            if (PageNum == 4) wordID = "30";
            if (PageNum == 5) wordID = "39";
            if (PageNum == 6) wordID = "48";
            if (PageNum == 7) wordID = "57";
            if (PageNum == 8) wordID = "66";
            if (PageNum == 9) wordID = "75";
            if (PageNum == 10) wordID = "84";
            SoundPlayer Simple = new SoundPlayer(SqlWav(wordID));
            Simple.Play();
        }

        private void PlayButton4_Click(object sender, EventArgs e)
        {
            string wordID = "1";
            if (PageNum == 1) wordID = "4";
            if (PageNum == 2) wordID = "13";
            if (PageNum == 3) wordID = "22";
            if (PageNum == 4) wordID = "31";
            if (PageNum == 5) wordID = "40";
            if (PageNum == 6) wordID = "49";
            if (PageNum == 7) wordID = "58";
            if (PageNum == 8) wordID = "67";
            if (PageNum == 9) wordID = "76";
            if (PageNum == 10) wordID = "85";
            SoundPlayer Simple = new SoundPlayer(SqlWav(wordID));
            Simple.Play();
        }

        private void PlayButton5_Click(object sender, EventArgs e)
        {
            string wordID = "1";
            if (PageNum == 1) wordID = "5";
            if (PageNum == 2) wordID = "14";
            if (PageNum == 3) wordID = "23";
            if (PageNum == 4) wordID = "32";
            if (PageNum == 5) wordID = "41";
            if (PageNum == 6) wordID = "50";
            if (PageNum == 7) wordID = "59";
            if (PageNum == 8) wordID = "68";
            if (PageNum == 9) wordID = "77";
            if (PageNum == 10) wordID = "86";
            SoundPlayer Simple = new SoundPlayer(SqlWav(wordID));
            Simple.Play();
        }

        private void PlayButton6_Click(object sender, EventArgs e)
        {
            string wordID = "1";
            if (PageNum == 1) wordID = "6";
            if (PageNum == 2) wordID = "15";
            if (PageNum == 3) wordID = "24";
            if (PageNum == 4) wordID = "33";
            if (PageNum == 5) wordID = "42";
            if (PageNum == 6) wordID = "51";
            if (PageNum == 7) wordID = "60";
            if (PageNum == 8) wordID = "69";
            if (PageNum == 9) wordID = "78";
            if (PageNum == 10) wordID = "87";
            SoundPlayer Simple = new SoundPlayer(SqlWav(wordID));
            Simple.Play();
        }

        private void PlayButton7_Click(object sender, EventArgs e)
        {
            string wordID = "1";
            if (PageNum == 1) wordID = "7";
            if (PageNum == 2) wordID = "16";
            if (PageNum == 3) wordID = "25";
            if (PageNum == 4) wordID = "34";
            if (PageNum == 5) wordID = "43";
            if (PageNum == 6) wordID = "52";
            if (PageNum == 7) wordID = "61";
            if (PageNum == 8) wordID = "70";
            if (PageNum == 9) wordID = "79";
            if (PageNum == 10) wordID = "88";
            SoundPlayer Simple = new SoundPlayer(SqlWav(wordID));
            Simple.Play();
        }

        private void PlayButton8_Click(object sender, EventArgs e)
        {
            string wordID = "1";
            if (PageNum == 1) wordID = "8";
            if (PageNum == 2) wordID = "17";
            if (PageNum == 3) wordID = "26";
            if (PageNum == 4) wordID = "35";
            if (PageNum == 5) wordID = "44";
            if (PageNum == 6) wordID = "53";
            if (PageNum == 7) wordID = "62";
            if (PageNum == 8) wordID = "71";
            if (PageNum == 9) wordID = "80";
            if (PageNum == 10) wordID = "89";
            SoundPlayer Simple = new SoundPlayer(SqlWav(wordID));
            Simple.Play();
        }

        private void PlayButton9_Click(object sender, EventArgs e)
        {
            string wordID = "1";
            if (PageNum == 1) wordID = "9";
            if (PageNum == 2) wordID = "18";
            if (PageNum == 3) wordID = "27";
            if (PageNum == 4) wordID = "36";
            if (PageNum == 5) wordID = "45";
            if (PageNum == 6) wordID = "54";
            if (PageNum == 7) wordID = "63";
            if (PageNum == 8) wordID = "72";
            if (PageNum == 9) wordID = "81";
            if (PageNum == 10) wordID = "90";
            SoundPlayer Simple = new SoundPlayer(SqlWav(wordID));
            Simple.Play();
        }

        /*
       public void Topic11()
       {
           TopicText.Text = "";
           EngWord1Text.Text = ""; RusWord1Text.Text = "";
           EngWord2Text.Text = ""; RusWord2Text.Text = "";
           EngWord3Text.Text = ""; RusWord3Text.Text = "";
           EngWord4Text.Text = ""; RusWord4Text.Text = "";
           EngWord5Text.Text = ""; RusWord5Text.Text = "";
           EngWord6Text.Text = ""; RusWord6Text.Text = "";
           EngWord7Text.Text = ""; RusWord7Text.Text = "";
           EngWord8Text.Text = ""; RusWord8Text.Text = "";
           EngWord9Text.Text = ""; RusWord9Text.Text = "";
       }
*/


    }
}
