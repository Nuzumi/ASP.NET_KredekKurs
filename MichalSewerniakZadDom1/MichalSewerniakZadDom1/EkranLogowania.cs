using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MichalSewerniakZadDom1
{
    public partial class FormLoginWindow : Form
    {
        private int minimumCharCountOfPassword = 5;
        private bool passwordHasSomething = false;
        private bool passwordHasMinimum5 = false;
        private bool passwordHasLowerCase = false;
        private bool passwrdHasUpperCase = false;


        public FormLoginWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// metoda sprawdzajaca poprawnosc hasla i loginu 
        /// umozliwia zalogowanie
        /// otwiera nowe okno po zalogowaniu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if(textBoxLogin.Text !="" && textBoxPassword.Text != "")
            {
                if (textBoxPassword.Text.Length >= minimumCharCountOfPassword)
                {
                    string lowerCasePasswoed = textBoxPassword.Text.ToLower();
                    string upperCasePassword = textBoxPassword.Text.ToUpper();
                    if(textBoxPassword.Text !=lowerCasePasswoed && textBoxPassword.Text != upperCasePassword)
                    {
                        FormMemeoScrean formMemeoScrean = new FormMemeoScrean(textBoxLogin.Text,textBoxPassword.Text);
                        Visible = false;
                        formMemeoScrean.ShowDialog();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("haslo musi zawierac przynajmniej jedna duza i mala litere");
                    }
                }
                else
                {
                    MessageBox.Show("haslo ma za malo znakow (min 5)");
                }
            }
            else
            {
                MessageBox.Show("Uzupelnij puste pola");
            }
        }

        /// <summary>
        /// sprawdza haslo i przy osiagnieciu jakiegos minimalnego wymagania przesuwa sie progres bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            int progresBarrValue = progressBarForEnteringPassword.Value;

            if(textBoxPassword.Text == "")
            {
                if (passwordHasSomething)
                {
                    progressBarForEnteringPassword.Value--;
                    passwordHasSomething = false;
                }
            }
            else
            {
                if (!passwordHasSomething)
                {
                    progressBarForEnteringPassword.Value++;
                    passwordHasSomething = true;
                }
            }

            if (textBoxPassword.Text.Length < 5)
            {
                if (passwordHasMinimum5)
                {
                    progressBarForEnteringPassword.Value--;
                    passwordHasMinimum5 = false;
                }
            }
            else
            {
                if (!passwordHasMinimum5)
                {
                    progressBarForEnteringPassword.Value++;
                    passwordHasMinimum5 = true;
                }
            }

            string upperCasePassword = textBoxPassword.Text.ToUpper();
            if (upperCasePassword == textBoxPassword.Text)
            {
                if (passwordHasLowerCase)
                {
                    progressBarForEnteringPassword.Value--;
                    passwordHasLowerCase = false;
                }
            }
            else
            {
                if (!passwordHasLowerCase)
                {
                    progressBarForEnteringPassword.Value++;
                    passwordHasLowerCase = true;
                }
            }

            string lowerCasePassword = textBoxPassword.Text.ToLower();
            if (lowerCasePassword == textBoxPassword.Text)
            {
                if (passwrdHasUpperCase)
                {
                    progressBarForEnteringPassword.Value--;
                    passwrdHasUpperCase = false;
                }
            }
            else
            {
                if (!passwrdHasUpperCase)
                {
                    progressBarForEnteringPassword.Value++;
                    passwrdHasUpperCase = true;
                }
            }
        }

    }
}
