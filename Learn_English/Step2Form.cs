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
    public partial class Step2Form : Form
    {
        private BeginnerForm _BeginnerMenu;

        public Step2Form()
        {
            InitializeComponent();
        }

        public Step2Form(BeginnerForm BeginnerMenu)
        {
            InitializeComponent();
            _BeginnerMenu = BeginnerMenu;
            _BeginnerMenu.Hide();
            RusWords(RandomWord());
        }

        Point lastPoint;
        private void Step2Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
                _BeginnerMenu.Left = this.Left;
                _BeginnerMenu.Top = this.Top;
            }
        }

        private void Step2Form_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void BackToLessonsButton_Click(object sender, EventArgs e)
        {
            this.Close();
            _BeginnerMenu.Show();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            //кнопка некст, обновляет ENG слово + 4 RUS слов
            //Метод который даёт рандом
            RusWords( RandomWord());
            RusWord1.BackColor = Color.LightGoldenrodYellow;
            RusWord2.BackColor = Color.LightGoldenrodYellow;
            RusWord3.BackColor = Color.LightGoldenrodYellow;
            RusWord4.BackColor = Color.LightGoldenrodYellow;

        }

        public string RandomWord()
        {
            Random randNum = new Random();
            int i;
            //массив с которого берём случайное слово
            string[] array = new string[]{"white","black","green","red","blue","yellow","pink",
                "brown","orange", "a mum","a dad", "a sister", "a brother", "a granny", "a grandad",
                "a family", "a cat", "a dog","a chicken","a horse","a cow","a rabbit","a mouse",
                "a pig","a sheep","a hamster","a duck","run","jump","swim","fly","climb","sing",
                "dance","read","write","a crocodile","an elephant","a hippo","a giraffe","a monkey",
                "a tiger","a lion","a bear","a fox","a head","a face","an ear","an eye","hair","a mouth",
                "a nose","hands","fingers","meat","sausages","a potato","bread","chocolate","icecream",
                "cheese","a lemon","an orange","a banana","an apple","a carrot","cakes","sweets","a pizza"
                ,"soup","fish","yummy","a house","a room","the floor","a door","a window","a table",
                "a bed","a chair","a carpet","a pupil","a teacher","a school","a board","a desk",
                "a book","a pen","a pencil","a rubber"};
            i = randNum.Next(0, 89);
            string word;
            word = array[i];
            // EngWord.Text = Convert.ToString( array.Length);
            EngWord.Text = word;
            return word;
        }
     

        public void RusWords(string word)
        {
            //все возможные комбинации 4-ёх слов
            Random randNum = new Random();
            int a=0, b=0, c=0, d=0,i;
            i = randNum.Next(1, 24);
            switch (i)
            {
                case 1:
                    a = 1; b = 2; c = 3; d = 4;
                    break;
                case 2:
                    a = 1; b = 2; c = 4; d = 3;
                    break;
                case 3:
                    a = 1; b = 3; c = 4; d = 2;
                    break;
                case 4:
                    a = 1; b = 3; c = 2; d = 4;
                    break;
                case 5:
                    a = 1; b = 4; c = 3; d = 2;
                    break;
                case 6:
                    a = 1; b = 4; c = 2; d = 3;
                    break;
                case 7:
                    a = 4; b = 3; c = 1; d = 2;
                    break;
                case 8:
                    a = 2; b = 1; c = 3; d = 4;
                    break;
                case 9:
                    a = 2; b = 1; c = 4; d = 3;
                    break;
                case 10:
                    a = 2; b = 3; c = 1; d = 4;
                    break;
                case 11:
                    a = 2; b = 3; c = 4; d = 1;
                    break;
                case 12:
                    a = 2; b = 4; c = 1; d = 3;
                    break;
                case 13:
                    a = 2; b = 4; c = 3; d = 1;
                    break;
                case 14:
                    a = 3; b = 1; c = 2; d = 4;
                    break;
                case 15:
                    a = 3; b = 1; c = 4; d = 2;
                    break;
                case 16:
                    a = 3; b = 2; c = 1; d = 4;
                    break;
                case 17:
                    a = 3; b = 2; c = 4; d = 1;
                    break;
                case 18:
                    a = 3; b = 4; c = 1; d = 2;
                    break;
                case 19:
                    a = 3; b = 4; c = 2; d = 1;
                    break;
                case 20:
                    a = 4; b = 1; c = 2; d = 3;
                    break;
                case 21:
                    a = 4; b = 1; c = 3; d = 2;
                    break;
                case 22:
                    a = 4; b = 2; c = 3; d = 1;
                    break;
                case 23:
                    a = 4; b = 2; c = 1; d = 3;
                    break;
                case 24:
                    a = 4; b = 3; c = 2; d = 1;
                    break;
            }
            a--;b--;c--;d--;
            //заполнение переводов (RusWords)
            string[] array1 = new string[] { "белый", "жёлтый", "кролик", "яблоко" };//     white   
            string[] array2 = new string[] { "чёрный", "серый", "волк", "стирка" };//black
            string[] array3 = new string[] { "зелёный", "сын", "линейка", "собака" };//green
            string[] array4 = new string[] { "красный", "лошадь", "яблоко", "пенал" };//red
            string[] array5 = new string[] { "синий", "небо", "бабушка", "кошка" };//blue
            string[] array6 = new string[] { "жёлтый", "цыплёнок", "большой", "белый" };//yellow"
            string[] array7 = new string[] { "розовый", "мороженое", "кошка", "сестра" };//pink
            string[] array8 = new string[] { "коричневый", "лошадь", "змея", "рюкзак" };//brown
            string[] array9 = new string[] { "оранжевый", "брат", "рыба", "стол" };//orange
            string[] array10 = new string[] { "мама", "бабушка", "семья", "пить" };//a mum
            string[] array11 = new string[] { "папа", "сок", "коричневый", "ручка" };//a dad
            string[] array12 = new string[] { "сестра", "пенал", "жёлтый", "парта" };//a sister
            string[] array13 = new string[] { "брат", "доска", "сестра", "собака" };//a brother
            string[] array14 = new string[] { "бабушка", "зелёный", "яблоко", "дедушка" };//a granny
            string[] array15 = new string[] { "дедушка", "мальчик", "папа", "картофель" };//a grandad
            string[] array16 = new string[] { "семья", "шоколад", "школа", "доска" };//a family
            string[] array17 = new string[] { "кошка", "чай", "кофе", "диван" };//a cat
            string[] array18 = new string[] { "собака", "лампа", "окно", "пол" };//a dog
            string[] array19 = new string[] { "цыплёнок", "жёлтый", "ковёр", "лимон" };//a chicken
            string[] array20 = new string[] { "лошадь", "морковка", "хлеб", "корова" };//a horse
            string[] array21 = new string[] { "корова", "лошадь", "сосиска", "ухо" };//a cow
            string[] array22 = new string[] { "кролик", "глаз", "рука", "белый" };//a rabbit
            string[] array23 = new string[] { "мышь", "чёрный", "палец", "волосы" };//a mouse
            string[] array24 = new string[] { "свинья", "курица", "овца", "попугай" };//a pig
            string[] array25 = new string[] { "овца", "рыба", "хомяк", "хлеб" };//a sheep
            string[] array26 = new string[] { "хомяк", "рука", "утка", "стирка" };//a hamster
            string[] array27 = new string[] { "утка", "лицо", "карандаш", "брат" };//a duck
            string[] array28 = new string[] { "бежать", "лезть", "петь", "плавать" };//run
            string[] array29 = new string[] { "прыгать", "джем", "жираф", "жёлтый" };//jump
            string[] array30 = new string[] { "плавать", "овца", "рыба", "конфета" };//swim
            string[] array31 = new string[] { "летать", "зеркало", "палец", "рыба" };//fly
            string[] array32 = new string[] { "лезть", "корова", "морковка", "красный" };//climb
            string[] array33 = new string[] { "петь", "играть", "писать", "овца" };//sing
            string[] array34 = new string[] { "танцевать", "утка", "волосы", "ковёр" };//dance
            string[] array35 = new string[] { "читать", "окно", "лампа", "хомяк" };//read
            string[] array36 = new string[] { "писать", "белый", "кофе", "пол" };//write
            string[] array37 = new string[] { "крокодил", "сосиски", "кресло", "дедушка" };//a crocodile
            string[] array38 = new string[] { "слон", "жираф", "обезьяна", "машина" };//an elephant
            string[] array39 = new string[] { "бегемот", "тигр", "розовый", "пенал" };//a hippo
            string[] array40 = new string[] { "жираф", "зелёный", "медведь", "пол" };//a giraffe
            string[] array41 = new string[] { "обезьяна", "лицо", "ухо", "волк" };//a monkey
            string[] array42 = new string[] { "тигр", "оранжевый", "апельсин", "чёрный" };//a tiger
            string[] array43 = new string[] { "лев", "сестра", "обезьяна", "сок" };//a lion
            string[] array44 = new string[] { "медведь", "сыр", "рот", "брат" };//a bear
            string[] array45 = new string[] { "лиса", "бабушка", "кошка", "мяч" };//a fox
            string[] array46 = new string[] { "голова", "лицо", "белый", "палец" };//a head
            string[] array47 = new string[] { "лицо", "лимон", "стул", "парта" };//a face
            string[] array48 = new string[] { "ухо", "доска", "ручка", "кровать" };//an ear
            string[] array49 = new string[] { "глаз", "розовый", "лампа", "вода" };//an eye
            string[] array50 = new string[] { "волосы", "лицо", "окно", "овца" };//hair
            string[] array51 = new string[] { "рот", "медведь", "картофель", "мышь" };//a mouth
            string[] array52 = new string[] { "нос", "ручка", "линейка", "кролик" };//a nose
            string[] array53 = new string[] { "руки", "заяц", "палец", "хлеб" };//hands
            string[] array54 = new string[] { "пальцы", "лиса", "семья", "ученик" };//fingers
            string[] array55 = new string[] { "мясо", "молоко", "обезьяна", "мышь" };//meat
            string[] array56 = new string[] { "сосиски", "хомяк", "слон", "стирка" };//sausages
            string[] array57 = new string[] { "картофель", "сосиски", "парта", "обезьяна" };//a potato
            string[] array58 = new string[] { "хлеб", "лиса", "кролик", "рисовать" };//bread
            string[] array59 = new string[] { "шоколад", "пенал", "мороженое", "палец" };//chocolate
            string[] array60 = new string[] { "мороженое", "попугай", "нос", "мясо" };//icecream
            string[] array61 = new string[] { "сыр", "пирожные", "корова", "рот" };//cheese
            string[] array62 = new string[] { "лимон", "жёлтый", "лезть", "джем" };//a lemon
            string[] array63 = new string[] { "апельсин", "лимон", "нога", "кошка" };//an orange
            string[] array64 = new string[] { "банан", "жёлтый", "суп", "линейка" };//a banana
            string[] array65 = new string[] { "яблоко", "красный", "зелёный", "семья" };//an apple
            string[] array66 = new string[] { "морковка", "оранжевый", "ухо", "лев" };//a carrot
            string[] array67 = new string[] { "пирожные", "кукла", "мороженое", "карандаш" };//cakes
            string[] array68 = new string[] { "конфеты", "пирожные", "мороженое", "кукла" };//sweets
            string[] array69 = new string[] { "пицца", "прыгать", "доска", "волк" };//a pizza
            string[] array70 = new string[] { "суп", "корова", "граз", "зелёный" };//soup
            string[] array71 = new string[] { "рыба", "палец", "папа", "лиса" };//fish
            string[] array72 = new string[] { "вкусно", "бегать", "прыгать", "рисовать" };//yummy
            string[] array73 = new string[] { "дом", "семья", "волосы", "парта" };//a house
            string[] array74 = new string[] { "комната", "этаж", "пол", "ковёр" };//a room
            string[] array75 = new string[] { "этаж", "пол", "парта", "доска" };//the floor
            string[] array76 = new string[] { "дверь", "окно", "коричневый", "бегемот" };//a door
            string[] array77 = new string[] { "окно", "пол", "белый", "мясо" };//a window
            string[] array78 = new string[] { "стол", "парта", "стул", "пол" };//a table
            string[] array79 = new string[] { "кровать", "диван", "красный", "стол" };//a bed
            string[] array80 = new string[] { "стул", "кресло", "диван", "окно" };//a chair
            string[] array81 = new string[] { "ковёр", "пол", "этаж", "парта" };//a carpet
            string[] array82 = new string[] { "ученик", "учитель", "розовый", "пенал" };//a pupil
            string[] array83 = new string[] { "учитель", "ученик", "ручка", "линейка" };//a teacher
            string[] array84 = new string[] { "школа", "семья", "парта", "рюкзак" };//a school
            string[] array85 = new string[] { "доска", "стол", "парта", "лиса" };//a board
            string[] array86 = new string[] { "парта", "стол", "стул", "этаж" };//a desk
            string[] array87 = new string[] { "книга", "рисовать", "читать", "шкаф" };//a book
            string[] array88 = new string[] { "ручка", "карандаш", "пенал", "курица" };//a pen
            string[] array89 = new string[] { "карандаш", "ручка", "пенал", "рюкзак" };//a pencil
            string[] array90 = new string[] { "стирка", "линейка", "прыгать", "школа" };//a rubber

            switch (word)
            {
                case "white":
                    RusWord1.Text = array1[a];
                    RusWord2.Text = array1[b];
                    RusWord3.Text = array1[c];
                    RusWord4.Text = array1[d];
                    break;
                case "black":
                    RusWord1.Text = array2[a];
                    RusWord2.Text = array2[b];
                    RusWord3.Text = array2[c];
                    RusWord4.Text = array2[d];
                    break;
                case "green":
                    RusWord1.Text = array3[a];
                    RusWord2.Text = array3[b];
                    RusWord3.Text = array3[c];
                    RusWord4.Text = array3[d];
                    break;
                case "red":
                    RusWord1.Text = array4[a];
                    RusWord2.Text = array4[b];
                    RusWord3.Text = array4[c];
                    RusWord4.Text = array4[d];
                    break;
                case "blue":
                    RusWord1.Text = array5[a];
                    RusWord2.Text = array5[b];
                    RusWord3.Text = array5[c];
                    RusWord4.Text = array5[d];
                    break;
                case "yellow":
                    RusWord1.Text = array6[a];
                    RusWord2.Text = array6[b];
                    RusWord3.Text = array6[c];
                    RusWord4.Text = array6[d];
                    break;
                case "pink":
                    RusWord1.Text = array7[a];
                    RusWord2.Text = array7[b];
                    RusWord3.Text = array7[c];
                    RusWord4.Text = array7[d];
                    break;
                case "brown":
                    RusWord1.Text = array8[a];
                    RusWord2.Text = array8[b];
                    RusWord3.Text = array8[c];
                    RusWord4.Text = array8[d];
                    break;
                case "orange":
                    RusWord1.Text = array9[a];
                    RusWord2.Text = array9[b];
                    RusWord3.Text = array9[c];
                    RusWord4.Text = array9[d];
                    break;
                case "a mum":
                    RusWord1.Text = array10[a];
                    RusWord2.Text = array10[b];
                    RusWord3.Text = array10[c];
                    RusWord4.Text = array10[d];
                    break;
                case "a dad":
                    RusWord1.Text = array11[a];
                    RusWord2.Text = array11[b];
                    RusWord3.Text = array11[c];
                    RusWord4.Text = array11[d];
                    break;
                case "a sister":
                    RusWord1.Text = array12[a];
                    RusWord2.Text = array12[b];
                    RusWord3.Text = array12[c];
                    RusWord4.Text = array12[d];
                    break;
                case "a brother":
                    RusWord1.Text = array13[a];
                    RusWord2.Text = array13[b];
                    RusWord3.Text = array13[c];
                    RusWord4.Text = array13[d];
                    break;
                case "a granny":
                    RusWord1.Text = array14[a];
                    RusWord2.Text = array14[b];
                    RusWord3.Text = array14[c];
                    RusWord4.Text = array14[d];
                    break;
                case "a grandad":
                    RusWord1.Text = array15[a];
                    RusWord2.Text = array15[b];
                    RusWord3.Text = array15[c];
                    RusWord4.Text = array15[d];
                    break;
                case "a family":
                    RusWord1.Text = array16[a];
                    RusWord2.Text = array16[b];
                    RusWord3.Text = array16[c];
                    RusWord4.Text = array16[d];
                    break;
                case "a cat":
                    RusWord1.Text = array17[a];
                    RusWord2.Text = array17[b];
                    RusWord3.Text = array17[c];
                    RusWord4.Text = array17[d];
                    break;
                case "a dog":
                    RusWord1.Text = array18[a];
                    RusWord2.Text = array18[b];
                    RusWord3.Text = array18[c];
                    RusWord4.Text = array18[d];
                    break;
                case "a chicken":
                    RusWord1.Text = array19[a];
                    RusWord2.Text = array19[b];
                    RusWord3.Text = array19[c];
                    RusWord4.Text = array19[d];
                    break;
                case "a horse":
                    RusWord1.Text = array20[a];
                    RusWord2.Text = array20[b];
                    RusWord3.Text = array20[c];
                    RusWord4.Text = array20[d];
                    break;
                case "a cow":
                    RusWord1.Text = array21[a];
                    RusWord2.Text = array21[b];
                    RusWord3.Text = array21[c];
                    RusWord4.Text = array21[d];
                    break;
                case "a rabbit":
                    RusWord1.Text = array22[a];
                    RusWord2.Text = array22[b];
                    RusWord3.Text = array22[c];
                    RusWord4.Text = array22[d];
                    break;
                case "a mouse":
                    RusWord1.Text = array23[a];
                    RusWord2.Text = array23[b];
                    RusWord3.Text = array23[c];
                    RusWord4.Text = array23[d];
                    break;
                case "a pig":
                    RusWord1.Text = array24[a];
                    RusWord2.Text = array24[b];
                    RusWord3.Text = array24[c];
                    RusWord4.Text = array24[d];
                    break;
                case "a sheep":
                    RusWord1.Text = array25[a];
                    RusWord2.Text = array25[b];
                    RusWord3.Text = array25[c];
                    RusWord4.Text = array25[d];
                    break;
                case "a hamster":
                    RusWord1.Text = array26[a];
                    RusWord2.Text = array26[b];
                    RusWord3.Text = array26[c];
                    RusWord4.Text = array26[d];
                    break;
                case "a duck":
                    RusWord1.Text = array27[a];
                    RusWord2.Text = array27[b];
                    RusWord3.Text = array27[c];
                    RusWord4.Text = array27[d];
                    break;
                case "run":
                    RusWord1.Text = array28[a];
                    RusWord2.Text = array28[b];
                    RusWord3.Text = array28[c];
                    RusWord4.Text = array28[d];
                    break;
                case "jump":
                    RusWord1.Text = array29[a];
                    RusWord2.Text = array29[b];
                    RusWord3.Text = array29[c];
                    RusWord4.Text = array29[d];
                    break;
                case "swim":
                    RusWord1.Text = array30[a];
                    RusWord2.Text = array30[b];
                    RusWord3.Text = array30[c];
                    RusWord4.Text = array30[d];
                    break;
                case "fly":
                    RusWord1.Text = array31[a];
                    RusWord2.Text = array31[b];
                    RusWord3.Text = array31[c];
                    RusWord4.Text = array31[d];
                    break;
                case "climb":
                    RusWord1.Text = array32[a];
                    RusWord2.Text = array32[b];
                    RusWord3.Text = array32[c];
                    RusWord4.Text = array32[d];
                    break;
                case "sing":
                    RusWord1.Text = array33[a];
                    RusWord2.Text = array33[b];
                    RusWord3.Text = array33[c];
                    RusWord4.Text = array33[d];
                    break;
                case "dance":
                    RusWord1.Text = array34[a];
                    RusWord2.Text = array34[b];
                    RusWord3.Text = array34[c];
                    RusWord4.Text = array34[d];
                    break;
                case "read":
                    RusWord1.Text = array35[a];
                    RusWord2.Text = array35[b];
                    RusWord3.Text = array35[c];
                    RusWord4.Text = array35[d];
                    break;
                case "write":
                    RusWord1.Text = array36[a];
                    RusWord2.Text = array36[b];
                    RusWord3.Text = array36[c];
                    RusWord4.Text = array36[d];
                    break;
                case "a crocodile":
                    RusWord1.Text = array37[a];
                    RusWord2.Text = array37[b];
                    RusWord3.Text = array37[c];
                    RusWord4.Text = array37[d];
                    break;
                case "an elephant":
                    RusWord1.Text = array38[a];
                    RusWord2.Text = array38[b];
                    RusWord3.Text = array38[c];
                    RusWord4.Text = array38[d];
                    break;
                case "a hippo":
                    RusWord1.Text = array39[a];
                    RusWord2.Text = array39[b];
                    RusWord3.Text = array39[c];
                    RusWord4.Text = array39[d];
                    break;
                case "a giraffe":
                    RusWord1.Text = array40[a];
                    RusWord2.Text = array40[b];
                    RusWord3.Text = array40[c];
                    RusWord4.Text = array40[d];
                    break;
                case "a monkey":
                    RusWord1.Text = array41[a];
                    RusWord2.Text = array41[b];
                    RusWord3.Text = array41[c];
                    RusWord4.Text = array41[d];
                    break;
                case "a tiger":
                    RusWord1.Text = array42[a];
                    RusWord2.Text = array42[b];
                    RusWord3.Text = array42[c];
                    RusWord4.Text = array42[d];
                    break;
                case "a lion":
                    RusWord1.Text = array43[a];
                    RusWord2.Text = array43[b];
                    RusWord3.Text = array43[c];
                    RusWord4.Text = array43[d];
                    break;
                case "a bear":
                    RusWord1.Text = array44[a];
                    RusWord2.Text = array44[b];
                    RusWord3.Text = array44[c];
                    RusWord4.Text = array44[d];
                    break;
                case "a fox":
                    RusWord1.Text = array45[a];
                    RusWord2.Text = array45[b];
                    RusWord3.Text = array45[c];
                    RusWord4.Text = array45[d];
                    break;
                case "a head":
                    RusWord1.Text = array46[a];
                    RusWord2.Text = array46[b];
                    RusWord3.Text = array46[c];
                    RusWord4.Text = array46[d];
                    break;
                case "a face":
                    RusWord1.Text = array47[a];
                    RusWord2.Text = array47[b];
                    RusWord3.Text = array47[c];
                    RusWord4.Text = array47[d];
                    break;
                case "an ear":
                    RusWord1.Text = array48[a];
                    RusWord2.Text = array48[b];
                    RusWord3.Text = array48[c];
                    RusWord4.Text = array48[d];
                    break;
                case "an eye":
                    RusWord1.Text = array49[a];
                    RusWord2.Text = array49[b];
                    RusWord3.Text = array49[c];
                    RusWord4.Text = array49[d];
                    break;
                case "hair":
                    RusWord1.Text = array50[a];
                    RusWord2.Text = array50[b];
                    RusWord3.Text = array50[c];
                    RusWord4.Text = array50[d];
                    break;
                case "a mouth":
                    RusWord1.Text = array51[a];
                    RusWord2.Text = array51[b];
                    RusWord3.Text = array51[c];
                    RusWord4.Text = array51[d];
                    break;
                case "a nose":
                    RusWord1.Text = array52[a];
                    RusWord2.Text = array52[b];
                    RusWord3.Text = array52[c];
                    RusWord4.Text = array52[d];
                    break;
                case "hands":
                    RusWord1.Text = array53[a];
                    RusWord2.Text = array53[b];
                    RusWord3.Text = array53[c];
                    RusWord4.Text = array53[d];
                    break;
                case "fingers":
                    RusWord1.Text = array54[a];
                    RusWord2.Text = array54[b];
                    RusWord3.Text = array54[c];
                    RusWord4.Text = array54[d];
                    break;
                case "meat":
                    RusWord1.Text = array55[a];
                    RusWord2.Text = array55[b];
                    RusWord3.Text = array55[c];
                    RusWord4.Text = array55[d];
                    break;
                case "sausages":
                    RusWord1.Text = array56[a];
                    RusWord2.Text = array56[b];
                    RusWord3.Text = array56[c];
                    RusWord4.Text = array56[d];
                    break;
                case "a potato":
                    RusWord1.Text = array57[a];
                    RusWord2.Text = array57[b];
                    RusWord3.Text = array57[c];
                    RusWord4.Text = array57[d];
                    break;
                case "bread":
                    RusWord1.Text = array58[a];
                    RusWord2.Text = array58[b];
                    RusWord3.Text = array58[c];
                    RusWord4.Text = array58[d];
                    break;
                case "chocolate":
                    RusWord1.Text = array59[a];
                    RusWord2.Text = array59[b];
                    RusWord3.Text = array59[c];
                    RusWord4.Text = array59[d];
                    break;
                case "icecream":
                    RusWord1.Text = array60[a];
                    RusWord2.Text = array60[b];
                    RusWord3.Text = array60[c];
                    RusWord4.Text = array60[d];
                    break;
                case "cheese":
                    RusWord1.Text = array61[a];
                    RusWord2.Text = array61[b];
                    RusWord3.Text = array61[c];
                    RusWord4.Text = array61[d];
                    break;
                case "a lemon":
                    RusWord1.Text = array62[a];
                    RusWord2.Text = array62[b];
                    RusWord3.Text = array62[c];
                    RusWord4.Text = array62[d];
                    break;
                case "an orange":
                    RusWord1.Text = array63[a];
                    RusWord2.Text = array63[b];
                    RusWord3.Text = array63[c];
                    RusWord4.Text = array63[d];
                    break;
                case "a banana":
                    RusWord1.Text = array64[a];
                    RusWord2.Text = array64[b];
                    RusWord3.Text = array64[c];
                    RusWord4.Text = array64[d];
                    break;
                case "an apple":
                    RusWord1.Text = array65[a];
                    RusWord2.Text = array65[b];
                    RusWord3.Text = array65[c];
                    RusWord4.Text = array65[d];
                    break;
                case "a carrot":
                    RusWord1.Text = array66[a];
                    RusWord2.Text = array66[b];
                    RusWord3.Text = array66[c];
                    RusWord4.Text = array66[d];
                    break;
                case "cakes":
                    RusWord1.Text = array67[a];
                    RusWord2.Text = array67[b];
                    RusWord3.Text = array67[c];
                    RusWord4.Text = array67[d];
                    break;
                case "sweets":
                    RusWord1.Text = array68[a];
                    RusWord2.Text = array68[b];
                    RusWord3.Text = array68[c];
                    RusWord4.Text = array68[d];
                    break;
                case "a pizza":
                    RusWord1.Text = array69[a];
                    RusWord2.Text = array69[b];
                    RusWord3.Text = array69[c];
                    RusWord4.Text = array69[d];
                    break;
                case "soup":
                    RusWord1.Text = array70[a];
                    RusWord2.Text = array70[b];
                    RusWord3.Text = array70[c];
                    RusWord4.Text = array70[d];
                    break;
                case "fish":
                    RusWord1.Text = array71[a];
                    RusWord2.Text = array71[b];
                    RusWord3.Text = array71[c];
                    RusWord4.Text = array71[d];
                    break;
                case "yummy":
                    RusWord1.Text = array72[a];
                    RusWord2.Text = array72[b];
                    RusWord3.Text = array72[c];
                    RusWord4.Text = array72[d];
                    break;
                case "a house":
                    RusWord1.Text = array73[a];
                    RusWord2.Text = array73[b];
                    RusWord3.Text = array73[c];
                    RusWord4.Text = array73[d];
                    break;
                case "a room":
                    RusWord1.Text = array74[a];
                    RusWord2.Text = array74[b];
                    RusWord3.Text = array74[c];
                    RusWord4.Text = array74[d];
                    break;
                case "the floor":
                    RusWord1.Text = array75[a];
                    RusWord2.Text = array75[b];
                    RusWord3.Text = array75[c];
                    RusWord4.Text = array75[d];
                    break;
                case "a door":
                    RusWord1.Text = array76[a];
                    RusWord2.Text = array76[b];
                    RusWord3.Text = array76[c];
                    RusWord4.Text = array76[d];
                    break;
                case "a window":
                    RusWord1.Text = array77[a];
                    RusWord2.Text = array77[b];
                    RusWord3.Text = array77[c];
                    RusWord4.Text = array77[d];
                    break;
                case "a table":
                    RusWord1.Text = array78[a];
                    RusWord2.Text = array78[b];
                    RusWord3.Text = array78[c];
                    RusWord4.Text = array78[d];
                    break;
                case "a bed":
                    RusWord1.Text = array79[a];
                    RusWord2.Text = array79[b];
                    RusWord3.Text = array79[c];
                    RusWord4.Text = array79[d];
                    break;
                case "a chair":
                    RusWord1.Text = array80[a];
                    RusWord2.Text = array80[b];
                    RusWord3.Text = array80[c];
                    RusWord4.Text = array80[d];
                    break;
                case "a carpet":
                    RusWord1.Text = array81[a];
                    RusWord2.Text = array81[b];
                    RusWord3.Text = array81[c];
                    RusWord4.Text = array81[d];
                    break;
                case "a pupil":
                    RusWord1.Text = array82[a];
                    RusWord2.Text = array82[b];
                    RusWord3.Text = array82[c];
                    RusWord4.Text = array82[d];
                    break;
                case "a teacher":
                    RusWord1.Text = array83[a];
                    RusWord2.Text = array83[b];
                    RusWord3.Text = array83[c];
                    RusWord4.Text = array83[d];
                    break;
                case "a school":
                    RusWord1.Text = array84[a];
                    RusWord2.Text = array84[b];
                    RusWord3.Text = array84[c];
                    RusWord4.Text = array84[d];
                    break;
                case "a board":
                    RusWord1.Text = array85[a];
                    RusWord2.Text = array85[b];
                    RusWord3.Text = array85[c];
                    RusWord4.Text = array85[d];
                    break;
                case "a desk":
                    RusWord1.Text = array86[a];
                    RusWord2.Text = array86[b];
                    RusWord3.Text = array86[c];
                    RusWord4.Text = array86[d];
                    break;
                case "a book":
                    RusWord1.Text = array87[a];
                    RusWord2.Text = array87[b];
                    RusWord3.Text = array87[c];
                    RusWord4.Text = array87[d];
                    break;
                case "a pen":
                    RusWord1.Text = array88[a];
                    RusWord2.Text = array88[b];
                    RusWord3.Text = array88[c];
                    RusWord4.Text = array88[d];
                    break;
                case "a pencil":
                    RusWord1.Text = array89[a];
                    RusWord2.Text = array89[b];
                    RusWord3.Text = array89[c];
                    RusWord4.Text = array89[d];
                    break;
                case "a rubber":
                    RusWord1.Text = array90[a];
                    RusWord2.Text = array90[b];
                    RusWord3.Text = array90[c];
                    RusWord4.Text = array90[d];
                    break;
            }
        }

        private void RusWord1_Click(object sender, EventArgs e)
        {
            Answer1();
 
        }

        private void Answer1()
        {
            switch (EngWord.Text)
            {
                case "white":
                    if (RusWord1.Text == "белый") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "black":
                    if (RusWord1.Text == "чёрный") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "green":
                    if (RusWord1.Text == "зелёный") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "red":
                    if (RusWord1.Text == "красный") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "blue":
                    if (RusWord1.Text == "синий") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "yellow":
                    if (RusWord1.Text == "жёлтый") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "pink":
                    if (RusWord1.Text == "розовый") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "brown":
                    if (RusWord1.Text == "коричневый") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "orange":
                    if (RusWord1.Text == "оранжевый") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "a mum":
                    if (RusWord1.Text == "мама") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "a dad":
                    if (RusWord1.Text == "папа") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "a sister":
                    if (RusWord1.Text == "сестра") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "a brother":
                    if (RusWord1.Text == "брат") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "a granny":
                    if (RusWord1.Text == "бабушка") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "a grandad":
                    if (RusWord1.Text == "дедушка") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "a family":
                    if (RusWord1.Text == "семья") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "a cat":
                    if (RusWord1.Text == "кошка") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "a dog":
                    if (RusWord1.Text == "собака") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "a chicken":
                    if (RusWord1.Text == "цыплёнок") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "a horse":
                    if (RusWord1.Text == "лошадь") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "a cow":
                    if (RusWord1.Text == "корова") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "a rabbit":
                    if (RusWord1.Text == "кролик") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "a mouse":
                    if (RusWord1.Text == "мышь") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "a pig":
                    if (RusWord1.Text == "свинья") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "a sheep":
                    if (RusWord1.Text == "овца") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "a hamster":
                    if (RusWord1.Text == "хомяк") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "a duck":
                    if (RusWord1.Text == "утка") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "run":
                    if (RusWord1.Text == "бежать") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "jump":
                    if (RusWord1.Text == "прыгать") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "swim":
                    if (RusWord1.Text == "плавать") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "fly":
                    if (RusWord1.Text == "летать") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "climb":
                    if (RusWord1.Text == "лезть") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "sing":
                    if (RusWord1.Text == "петь") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "dance":
                    if (RusWord1.Text == "танцевать") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "read":
                    if (RusWord1.Text == "читать") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "write":
                    if (RusWord1.Text == "писать") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "a crocodile":
                    if (RusWord1.Text == "крокодил") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "an elephant":
                    if (RusWord1.Text == "слон") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "a hippo":
                    if (RusWord1.Text == "бегемот") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "a giraffe":
                    if (RusWord1.Text == "жираф") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "a monkey":
                    if (RusWord1.Text == "обезьяна") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "a tiger":
                    if (RusWord1.Text == "тигр") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "a lion":
                    if (RusWord1.Text == "лев") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "a bear":
                    if (RusWord1.Text == "медведь") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "a fox":
                    if (RusWord1.Text == "лиса") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "a head":
                    if (RusWord1.Text == "голова") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "a face":
                    if (RusWord1.Text == "лицо") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "an ear":
                    if (RusWord1.Text == "ухо") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "an eye":
                    if (RusWord1.Text == "глаз") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "hair":
                    if (RusWord1.Text == "волосы") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "a mouth":
                    if (RusWord1.Text == "рот") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "a nose":
                    if (RusWord1.Text == "нос") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "hands":
                    if (RusWord1.Text == "руки") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "fingers":
                    if (RusWord1.Text == "пальцы") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "meat":
                    if (RusWord1.Text == "мясо") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "sausages":
                    if (RusWord1.Text == "сосиски") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "a potato":
                    if (RusWord1.Text == "картофель") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "bread":
                    if (RusWord1.Text == "хлеб") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "chocolate":
                    if (RusWord1.Text == "шоколад") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "icecream":
                    if (RusWord1.Text == "мороженое") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "cheese":
                    if (RusWord1.Text == "сыр") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "a lemon":
                    if (RusWord1.Text == "лимон") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "an orange":
                    if (RusWord1.Text == "апельсин") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "a banana":
                    if (RusWord1.Text == "банан") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "an apple":
                    if (RusWord1.Text == "яблоко") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "a carrot":
                    if (RusWord1.Text == "морковка") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "cakes":
                    if (RusWord1.Text == "пирожные") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "sweets":
                    if (RusWord1.Text == "конфеты") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "a pizza":
                    if (RusWord1.Text == "пицца") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "soup":
                    if (RusWord1.Text == "суп") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "fish":
                    if (RusWord1.Text == "рыба") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "yummy":
                    if (RusWord1.Text == "вкусно") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "a house":
                    if (RusWord1.Text == "дом") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "a room":
                    if (RusWord1.Text == "комната") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "the floor":
                    if (RusWord1.Text == "пол") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "a door":
                    if (RusWord1.Text == "дверь") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "a window":
                    if (RusWord1.Text == "окно") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "a table":
                    if (RusWord1.Text == "стол") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "a bed":
                    if (RusWord1.Text == "кровать") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "a chair":
                    if (RusWord1.Text == "стул") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "a carpet":
                    if (RusWord1.Text == "ковёр") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "a pupil":
                    if (RusWord1.Text == "ученик") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "a teacher":
                    if (RusWord1.Text == "учитель") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "a school":
                    if (RusWord1.Text == "школа") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "a board":
                    if (RusWord1.Text == "доска") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "a desk":
                    if (RusWord1.Text == "парта") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "a book":
                    if (RusWord1.Text == "книга") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "a pen":
                    if (RusWord1.Text == "ручка") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "a pencil":
                    if (RusWord1.Text == "карандаш") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
                case "a rubber":
                    if (RusWord1.Text == "стирка") RusWord1.BackColor = Color.Lime;
                    else RusWord1.BackColor = Color.Red;
                    break;
            }
        }

        private void Answer2()
        {
            switch (EngWord.Text)
            {
                case "white":
                    if (RusWord2.Text == "белый") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "black":
                    if (RusWord2.Text == "чёрный") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "green":
                    if (RusWord2.Text == "зелёный") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "red":
                    if (RusWord2.Text == "красный") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "blue":
                    if (RusWord2.Text == "синий") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "yellow":
                    if (RusWord2.Text == "жёлтый") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "pink":
                    if (RusWord2.Text == "розовый") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "brown":
                    if (RusWord2.Text == "коричневый") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "orange":
                    if (RusWord2.Text == "оранжевый") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "a mum":
                    if (RusWord2.Text == "мама") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "a dad":
                    if (RusWord2.Text == "папа") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "a sister":
                    if (RusWord2.Text == "сестра") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "a brother":
                    if (RusWord2.Text == "брат") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "a granny":
                    if (RusWord2.Text == "бабушка") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "a grandad":
                    if (RusWord2.Text == "дедушка") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "a family":
                    if (RusWord2.Text == "семья") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "a cat":
                    if (RusWord2.Text == "кошка") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "a dog":
                    if (RusWord2.Text == "собака") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "a chicken":
                    if (RusWord2.Text == "цыплёнок") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "a horse":
                    if (RusWord2.Text == "лошадь") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "a cow":
                    if (RusWord2.Text == "корова") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "a rabbit":
                    if (RusWord2.Text == "кролик") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "a mouse":
                    if (RusWord2.Text == "мышь") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "a pig":
                    if (RusWord2.Text == "свинья") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "a sheep":
                    if (RusWord2.Text == "овца") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "a hamster":
                    if (RusWord2.Text == "хомяк") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "a duck":
                    if (RusWord2.Text == "утка") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "run":
                    if (RusWord2.Text == "бежать") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "jump":
                    if (RusWord2.Text == "прыгать") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "swim":
                    if (RusWord2.Text == "плавать") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "fly":
                    if (RusWord2.Text == "летать") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "climb":
                    if (RusWord2.Text == "лезть") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "sing":
                    if (RusWord2.Text == "петь") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "dance":
                    if (RusWord2.Text == "танцевать") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "read":
                    if (RusWord2.Text == "читать") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "write":
                    if (RusWord2.Text == "писать") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "a crocodile":
                    if (RusWord2.Text == "крокодил") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "an elephant":
                    if (RusWord2.Text == "слон") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "a hippo":
                    if (RusWord2.Text == "бегемот") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "a giraffe":
                    if (RusWord2.Text == "жираф") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "a monkey":
                    if (RusWord2.Text == "обезьяна") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "a tiger":
                    if (RusWord2.Text == "тигр") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "a lion":
                    if (RusWord2.Text == "лев") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "a bear":
                    if (RusWord2.Text == "медведь") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "a fox":
                    if (RusWord2.Text == "лиса") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "a head":
                    if (RusWord2.Text == "голова") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "a face":
                    if (RusWord2.Text == "лицо") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "an ear":
                    if (RusWord2.Text == "ухо") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "an eye":
                    if (RusWord2.Text == "глаз") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "hair":
                    if (RusWord2.Text == "волосы") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "a mouth":
                    if (RusWord2.Text == "рот") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "a nose":
                    if (RusWord2.Text == "нос") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "hands":
                    if (RusWord2.Text == "руки") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "fingers":
                    if (RusWord2.Text == "пальцы") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "meat":
                    if (RusWord2.Text == "мясо") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "sausages":
                    if (RusWord2.Text == "сосиски") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "a potato":
                    if (RusWord2.Text == "картофель") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "bread":
                    if (RusWord2.Text == "хлеб") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "chocolate":
                    if (RusWord2.Text == "шоколад") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "icecream":
                    if (RusWord2.Text == "мороженое") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "cheese":
                    if (RusWord2.Text == "сыр") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "a lemon":
                    if (RusWord2.Text == "лимон") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "an orange":
                    if (RusWord2.Text == "апельсин") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "a banana":
                    if (RusWord2.Text == "банан") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "an apple":
                    if (RusWord2.Text == "яблоко") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "a carrot":
                    if (RusWord2.Text == "морковка") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "cakes":
                    if (RusWord2.Text == "пирожные") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "sweets":
                    if (RusWord2.Text == "конфеты") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "a pizza":
                    if (RusWord2.Text == "пицца") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "soup":
                    if (RusWord2.Text == "суп") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "fish":
                    if (RusWord2.Text == "рыба") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "yummy":
                    if (RusWord2.Text == "вкусно") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "a house":
                    if (RusWord2.Text == "дом") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "a room":
                    if (RusWord2.Text == "комната") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "the floor":
                    if (RusWord2.Text == "пол") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "a door":
                    if (RusWord2.Text == "дверь") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "a window":
                    if (RusWord2.Text == "окно") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "a table":
                    if (RusWord2.Text == "стол") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "a bed":
                    if (RusWord2.Text == "кровать") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "a chair":
                    if (RusWord2.Text == "стул") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "a carpet":
                    if (RusWord2.Text == "ковёр") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "a pupil":
                    if (RusWord2.Text == "ученик") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "a teacher":
                    if (RusWord2.Text == "учитель") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "a school":
                    if (RusWord2.Text == "школа") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "a board":
                    if (RusWord2.Text == "доска") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "a desk":
                    if (RusWord2.Text == "парта") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "a book":
                    if (RusWord2.Text == "книга") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "a pen":
                    if (RusWord2.Text == "ручка") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "a pencil":
                    if (RusWord2.Text == "карандаш") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
                case "a rubber":
                    if (RusWord2.Text == "стирка") RusWord2.BackColor = Color.Lime;
                    else RusWord2.BackColor = Color.Red;
                    break;
            }
        }
        private void Answer3()
        {
            switch (EngWord.Text)
            {
                case "white":
                    if (RusWord3.Text == "белый") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "black":
                    if (RusWord3.Text == "чёрный") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "green":
                    if (RusWord3.Text == "зелёный") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "red":
                    if (RusWord3.Text == "красный") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "blue":
                    if (RusWord3.Text == "синий") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "yellow":
                    if (RusWord3.Text == "жёлтый") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "pink":
                    if (RusWord3.Text == "розовый") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "brown":
                    if (RusWord3.Text == "коричневый") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "orange":
                    if (RusWord3.Text == "оранжевый") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "a mum":
                    if (RusWord3.Text == "мама") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "a dad":
                    if (RusWord3.Text == "папа") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "a sister":
                    if (RusWord3.Text == "сестра") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "a brother":
                    if (RusWord3.Text == "брат") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "a granny":
                    if (RusWord3.Text == "бабушка") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "a grandad":
                    if (RusWord3.Text == "дедушка") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "a family":
                    if (RusWord3.Text == "семья") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "a cat":
                    if (RusWord3.Text == "кошка") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "a dog":
                    if (RusWord3.Text == "собака") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "a chicken":
                    if (RusWord3.Text == "цыплёнок") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "a horse":
                    if (RusWord3.Text == "лошадь") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "a cow":
                    if (RusWord3.Text == "корова") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "a rabbit":
                    if (RusWord3.Text == "кролик") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "a mouse":
                    if (RusWord3.Text == "мышь") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "a pig":
                    if (RusWord3.Text == "свинья") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "a sheep":
                    if (RusWord3.Text == "овца") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "a hamster":
                    if (RusWord3.Text == "хомяк") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "a duck":
                    if (RusWord3.Text == "утка") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "run":
                    if (RusWord3.Text == "бежать") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "jump":
                    if (RusWord3.Text == "прыгать") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "swim":
                    if (RusWord3.Text == "плавать") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "fly":
                    if (RusWord3.Text == "летать") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "climb":
                    if (RusWord3.Text == "лезть") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "sing":
                    if (RusWord3.Text == "петь") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "dance":
                    if (RusWord3.Text == "танцевать") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "read":
                    if (RusWord3.Text == "читать") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "write":
                    if (RusWord3.Text == "писать") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "a crocodile":
                    if (RusWord3.Text == "крокодил") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "an elephant":
                    if (RusWord3.Text == "слон") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "a hippo":
                    if (RusWord3.Text == "бегемот") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "a giraffe":
                    if (RusWord3.Text == "жираф") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "a monkey":
                    if (RusWord3.Text == "обезьяна") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "a tiger":
                    if (RusWord3.Text == "тигр") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "a lion":
                    if (RusWord3.Text == "лев") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "a bear":
                    if (RusWord3.Text == "медведь") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "a fox":
                    if (RusWord3.Text == "лиса") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "a head":
                    if (RusWord3.Text == "голова") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "a face":
                    if (RusWord3.Text == "лицо") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "an ear":
                    if (RusWord3.Text == "ухо") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "an eye":
                    if (RusWord3.Text == "глаз") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "hair":
                    if (RusWord3.Text == "волосы") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "a mouth":
                    if (RusWord3.Text == "рот") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "a nose":
                    if (RusWord3.Text == "нос") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "hands":
                    if (RusWord3.Text == "руки") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "fingers":
                    if (RusWord3.Text == "пальцы") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "meat":
                    if (RusWord3.Text == "мясо") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "sausages":
                    if (RusWord3.Text == "сосиски") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "a potato":
                    if (RusWord3.Text == "картофель") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "bread":
                    if (RusWord3.Text == "хлеб") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "chocolate":
                    if (RusWord3.Text == "шоколад") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "icecream":
                    if (RusWord3.Text == "мороженое") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "cheese":
                    if (RusWord3.Text == "сыр") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "a lemon":
                    if (RusWord3.Text == "лимон") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "an orange":
                    if (RusWord3.Text == "апельсин") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "a banana":
                    if (RusWord3.Text == "банан") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "an apple":
                    if (RusWord3.Text == "яблоко") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "a carrot":
                    if (RusWord3.Text == "морковка") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "cakes":
                    if (RusWord3.Text == "пирожные") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "sweets":
                    if (RusWord3.Text == "конфеты") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "a pizza":
                    if (RusWord3.Text == "пицца") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "soup":
                    if (RusWord3.Text == "суп") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "fish":
                    if (RusWord3.Text == "рыба") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "yummy":
                    if (RusWord3.Text == "вкусно") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "a house":
                    if (RusWord3.Text == "дом") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "a room":
                    if (RusWord3.Text == "комната") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "the floor":
                    if (RusWord3.Text == "пол") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "a door":
                    if (RusWord3.Text == "дверь") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "a window":
                    if (RusWord3.Text == "окно") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "a table":
                    if (RusWord3.Text == "стол") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "a bed":
                    if (RusWord3.Text == "кровать") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "a chair":
                    if (RusWord3.Text == "стул") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "a carpet":
                    if (RusWord3.Text == "ковёр") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "a pupil":
                    if (RusWord3.Text == "ученик") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "a teacher":
                    if (RusWord3.Text == "учитель") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "a school":
                    if (RusWord3.Text == "школа") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "a board":
                    if (RusWord3.Text == "доска") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "a desk":
                    if (RusWord3.Text == "парта") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "a book":
                    if (RusWord3.Text == "книга") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "a pen":
                    if (RusWord3.Text == "ручка") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "a pencil":
                    if (RusWord3.Text == "карандаш") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
                case "a rubber":
                    if (RusWord3.Text == "стирка") RusWord3.BackColor = Color.Lime;
                    else RusWord3.BackColor = Color.Red;
                    break;
            }
        }
        private void Answer4()
        {
            switch (EngWord.Text)
            {
                case "white":
                    if (RusWord4.Text == "белый") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "black":
                    if (RusWord4.Text == "чёрный") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "green":
                    if (RusWord4.Text == "зелёный") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "red":
                    if (RusWord4.Text == "красный") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "blue":
                    if (RusWord4.Text == "синий") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "yellow":
                    if (RusWord4.Text == "жёлтый") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "pink":
                    if (RusWord4.Text == "розовый") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "brown":
                    if (RusWord4.Text == "коричневый") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "orange":
                    if (RusWord4.Text == "оранжевый") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "a mum":
                    if (RusWord4.Text == "мама") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "a dad":
                    if (RusWord4.Text == "папа") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "a sister":
                    if (RusWord4.Text == "сестра") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "a brother":
                    if (RusWord4.Text == "брат") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "a granny":
                    if (RusWord4.Text == "бабушка") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "a grandad":
                    if (RusWord4.Text == "дедушка") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "a family":
                    if (RusWord4.Text == "семья") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "a cat":
                    if (RusWord4.Text == "кошка") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "a dog":
                    if (RusWord4.Text == "собака") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "a chicken":
                    if (RusWord4.Text == "цыплёнок") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "a horse":
                    if (RusWord4.Text == "лошадь") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "a cow":
                    if (RusWord4.Text == "корова") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "a rabbit":
                    if (RusWord4.Text == "кролик") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "a mouse":
                    if (RusWord4.Text == "мышь") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "a pig":
                    if (RusWord4.Text == "свинья") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "a sheep":
                    if (RusWord4.Text == "овца") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "a hamster":
                    if (RusWord4.Text == "хомяк") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "a duck":
                    if (RusWord4.Text == "утка") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "run":
                    if (RusWord4.Text == "бежать") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "jump":
                    if (RusWord4.Text == "прыгать") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "swim":
                    if (RusWord4.Text == "плавать") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "fly":
                    if (RusWord4.Text == "летать") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "climb":
                    if (RusWord4.Text == "лезть") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "sing":
                    if (RusWord4.Text == "петь") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "dance":
                    if (RusWord4.Text == "танцевать") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "read":
                    if (RusWord4.Text == "читать") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "write":
                    if (RusWord4.Text == "писать") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "a crocodile":
                    if (RusWord4.Text == "крокодил") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "an elephant":
                    if (RusWord4.Text == "слон") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "a hippo":
                    if (RusWord4.Text == "бегемот") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "a giraffe":
                    if (RusWord4.Text == "жираф") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "a monkey":
                    if (RusWord4.Text == "обезьяна") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "a tiger":
                    if (RusWord4.Text == "тигр") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "a lion":
                    if (RusWord4.Text == "лев") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "a bear":
                    if (RusWord4.Text == "медведь") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "a fox":
                    if (RusWord4.Text == "лиса") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "a head":
                    if (RusWord4.Text == "голова") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "a face":
                    if (RusWord4.Text == "лицо") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "an ear":
                    if (RusWord4.Text == "ухо") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "an eye":
                    if (RusWord4.Text == "глаз") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "hair":
                    if (RusWord4.Text == "волосы") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "a mouth":
                    if (RusWord4.Text == "рот") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "a nose":
                    if (RusWord4.Text == "нос") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "hands":
                    if (RusWord4.Text == "руки") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "fingers":
                    if (RusWord4.Text == "пальцы") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "meat":
                    if (RusWord4.Text == "мясо") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "sausages":
                    if (RusWord4.Text == "сосиски") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "a potato":
                    if (RusWord4.Text == "картофель") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "bread":
                    if (RusWord4.Text == "хлеб") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "chocolate":
                    if (RusWord4.Text == "шоколад") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "icecream":
                    if (RusWord4.Text == "мороженое") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "cheese":
                    if (RusWord4.Text == "сыр") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "a lemon":
                    if (RusWord4.Text == "лимон") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "an orange":
                    if (RusWord4.Text == "апельсин") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "a banana":
                    if (RusWord4.Text == "банан") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "an apple":
                    if (RusWord4.Text == "яблоко") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "a carrot":
                    if (RusWord4.Text == "морковка") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "cakes":
                    if (RusWord4.Text == "пирожные") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "sweets":
                    if (RusWord4.Text == "конфеты") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "a pizza":
                    if (RusWord4.Text == "пицца") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "soup":
                    if (RusWord4.Text == "суп") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "fish":
                    if (RusWord4.Text == "рыба") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "yummy":
                    if (RusWord4.Text == "вкусно") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "a house":
                    if (RusWord4.Text == "дом") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "a room":
                    if (RusWord4.Text == "комната") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "the floor":
                    if (RusWord4.Text == "пол") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "a door":
                    if (RusWord4.Text == "дверь") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "a window":
                    if (RusWord4.Text == "окно") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "a table":
                    if (RusWord4.Text == "стол") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "a bed":
                    if (RusWord4.Text == "кровать") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "a chair":
                    if (RusWord4.Text == "стул") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "a carpet":
                    if (RusWord4.Text == "ковёр") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "a pupil":
                    if (RusWord4.Text == "ученик") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "a teacher":
                    if (RusWord4.Text == "учитель") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "a school":
                    if (RusWord4.Text == "школа") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "a board":
                    if (RusWord4.Text == "доска") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "a desk":
                    if (RusWord4.Text == "парта") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "a book":
                    if (RusWord4.Text == "книга") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "a pen":
                    if (RusWord4.Text == "ручка") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "a pencil":
                    if (RusWord4.Text == "карандаш") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
                case "a rubber":
                    if (RusWord4.Text == "стирка") RusWord4.BackColor = Color.Lime;
                    else RusWord4.BackColor = Color.Red;
                    break;
            }
        }





        private void RusWord2_Click(object sender, EventArgs e)
        {
            Answer2();
        }

        private void RusWord3_Click(object sender, EventArgs e)
        {
            Answer3();
        }

        private void RusWord4_Click(object sender, EventArgs e)
        {
            Answer4();
        }
    }
}
