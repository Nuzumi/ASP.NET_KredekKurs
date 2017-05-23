using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MichalSewerniakZadDom1
{
    public partial class FormMemeoScrean : Form
    {
        private string login;
        private string password;
        private bool circleIsOn = false;
        private int trueAnswers;
        private int falseAnswers;
        private int repeetCounter;
        private int bigRepeetCounter;
        private int minimumNumber;
        private int maximumNumber;
        private List<int> numbersList = new List<int>();

        public FormMemeoScrean()
        {
            InitializeComponent();
        }

        /// <summary>
        /// konstruktor przyjmujacy login i haslo
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        public FormMemeoScrean(string login,string password)
        {
            InitializeComponent();
            this.login = login;
            this.password = password;
        }

        /// <summary>
        /// wyswietla witaj + login
        /// ukrywa textboxPlayfield
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMemeoScrean_Load(object sender, EventArgs e)
        {
            labelWelcome.Text = "Witaj " + login;
            textBoxPlayField.Visible = false;
            labelPassword.Visible = false;
            textBoxPassword.Visible = false;
            buttonPassword.Visible = false;
            OnOffAnswers(false);
        }

        /// <summary>
        /// ukrywa niepotzrebne cosie
        /// pokazuje textboxPlayField
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonWelcome_Click(object sender, EventArgs e)
        {
            textBoxRules.Visible = false;
            labelWelcome.Visible = false;
            buttonStartGame.Visible = false;
            textBoxPlayField.Visible = true;
            OnOffAnswers(false);
            timerStartGame.Start();
        }

        /// <summary>
        /// zarzadza czasem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerStartGame_Tick(object sender, EventArgs e)
        {
            if (repeetCounter < 5)
            {
                if (circleIsOn)
                {
                    textBoxPlayField.Invalidate();
                    circleIsOn = false;
                }
                else
                {
                    repeetCounter++;
                    Random random = new Random();
                    int randomNumber = random.Next(-50, 50);
                    int positionX = random.Next(30, textBoxPlayField.Width - 30);
                    int positionY = random.Next(30, textBoxPlayField.Height - 30);
                    numbersList.Add(randomNumber);
                    DrowCircle(positionX, positionY);
                    DrawNumber(randomNumber, positionX, positionY);
                }
            }
            else
            {
                textBoxPlayField.Invalidate();
                circleIsOn = false;
                timerStartGame.Stop();
                numbersList.Sort();
                minimumNumber = numbersList[0];
                maximumNumber = numbersList[numbersList.Count - 1];
                MessageBox.Show("uzupelnij puste pola");
                OnOffAnswers(true);
                timerAnswerTime.Start();
            }
        }


        /// <summary>
        /// rysuje kulka na wyznaczonej pozycji
        /// </summary>
        /// <param name="positionX"></param>
        /// <param name="positionY"></param>
        private void DrowCircle(int positionX,int positionY)
        {
            Pen myPen = new Pen(Color.Green);
            Graphics textBoxGraphicd;
            textBoxGraphicd = textBoxPlayField.CreateGraphics();
            textBoxGraphicd.DrawEllipse(myPen, new Rectangle(positionX-30, positionY-30, 60, 60));
            myPen.Dispose();
            textBoxGraphicd.Dispose();
            circleIsOn = true;
        }


        /// <summary>
        /// wyswietla podany numer na podanej pozycji
        /// </summary>
        /// <param name="number"></param>
        /// <param name="positionX"></param>
        /// <param name="positionY"></param>
        private void DrawNumber(int number,int positionX,int positionY)
        {
            Graphics texBoxGrapgics = textBoxPlayField.CreateGraphics();
            Font myFont = new Font("ComicSans", 16);
            SolidBrush myBrush = new SolidBrush(Color.Black);
            StringFormat drawFormat = new StringFormat();
            texBoxGrapgics.DrawString(number.ToString(), myFont, myBrush, new Point(positionX-15, positionY-12));
            myBrush.Dispose();
            myFont.Dispose();
            texBoxGrapgics.Dispose();
        }

        /// <summary>
        /// wlacza/wylacza label textbox button do odpowiedzi
        /// </summary>
        /// <param name="On"></param>
        void OnOffAnswers(bool on)
        {
            labelMinimum.Visible = on;
            labelMaximum.Visible = on;
            textBoxMaximumNumber.Visible = on;
            textBoxMinimumNumber.Visible = on;
            buttonOkMinimum.Visible = on;
            buttonOkMaximum.Visible = on;
        }

        /// <summary>
        /// sprawdza poprawnosc odpowiedzi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOkMinimum_Click(object sender, EventArgs e)
        {
            textBoxMinimumNumber.ReadOnly = true;
            if(textBoxMinimumNumber.Text == minimumNumber.ToString())
            {
                textBoxMinimumNumber.BackColor = Color.Green;
                trueAnswers++;
            }
            else
            {
                textBoxMinimumNumber.BackColor = Color.Red;
                falseAnswers++;
            }
        }

        /// <summary>
        /// sprawdza popawnosc odpowiedzi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOkMaximum_Click(object sender, EventArgs e)
        {
            textBoxMaximumNumber.ReadOnly = true;
            if(textBoxMaximumNumber.Text == maximumNumber.ToString())
            {
                textBoxMaximumNumber.BackColor = Color.Green;
                trueAnswers++;
            }
            else
            {
                textBoxMaximumNumber.BackColor = Color.Red;
                falseAnswers++;
            }
        }

        /// <summary>
        /// resetuje button i textbox od odpowiedzi
        /// </summary>
        void Reset()
        {
            repeetCounter = 0;
            if(textBoxMinimumNumber.Text == "")
            {
                falseAnswers++;
            }
            if(textBoxMaximumNumber.Text == "")
            {
                falseAnswers++;
            }
            textBoxMaximumNumber.ReadOnly = false;
            textBoxMaximumNumber.Text = "";
            textBoxMaximumNumber.BackColor = Color.White;
            textBoxMinimumNumber.ReadOnly = false;
            textBoxMinimumNumber.Text = "";
            textBoxMinimumNumber.BackColor = Color.White;
        }

        /// <summary>
        /// resetuje liste wylosowanych numerow
        /// wyswietla komentarz
        /// sprawdza powtorzenia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerAnswerTime_Tick(object sender, EventArgs e)
        {
            Reset();
            OnOffAnswers(false);
            numbersList.Clear();
            CommentsDisplayer();
            timerAnswerTime.Stop();
            if (bigRepeetCounter <= 4)
            {
                bigRepeetCounter++;
                timerStartGame.Start();
            }
            else
            {
                OnOffAnswers(false);
                textBoxPassword.Visible = true;
                labelPassword.Visible = true;
                buttonPassword.Visible = true;
            }
        }

        /// <summary>
        /// usatla komentarz i go wyswie
        /// </summary>
        private void CommentsDisplayer()
        {
            string comment = "";
            if (trueAnswers > falseAnswers)
            {
                comment += "idzie ci calkiem dobrze";
                if (trueAnswers - falseAnswers> 4)
                {
                    comment = "jest prawie idealnie";
                }
            }
            else
            {
                comment += "mozesz sie bardziej posatrac";
                if (trueAnswers <= 2)
                {
                    comment += " bo idzie ci strasznie";
                }
            }

            MessageBox.Show(comment);
        }

        /// <summary>
        /// sprawdza czy pamietasz haslo
        /// i jak nie to sie z ciebie smieje
        /// a jak tak to podaje twoj wynik
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPassword_Click(object sender, EventArgs e)
        {
            if(textBoxPassword.Text == password)
            {
                MessageBox.Show("dziekuje za udzial w grze, miales " + trueAnswers + " poprawnych odpowiedzi,oraz " + falseAnswers + " zlych odpowiedzi");
            }
            else
            {
                MessageBox.Show("no jak mozna bylo nie pamietac hasla \"wstydz się\"");
            }
            Close();
        }
    }
}
