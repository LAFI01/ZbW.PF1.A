using System;
using System.Windows.Forms;

namespace MB05.A10_1
{
    public partial class A10_1_2 : Form
    {
        private int upperLimit;
        private int secretNumber;
        private int enteredNumber;
        private int enterCounter;
        private int answerIndexCode;

        private readonly string[] answers =
            { "Die von mir gedachte Zahl ist grösser!",
              "Die von mir geachte Zahl ist kleiner!",
              "Du hast die Zahl erraten! Gratuliere!!!",
              " .Versuch",
              "Ich denke mir eine Zahl zwischen 0 und "};

        public A10_1_2()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeGame();
        }

        /// <summary>
        /// Will called when the user have pressed the Enter-Key
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                enteredNumber = Convert.ToInt16(TxtValue.Text);

                CheckNumber();
            }
        }

        private void CmdRestart_Click(object sender, EventArgs e)
        {
            InitializeGame();
        }

        /// <summary>
        /// This method will be initialize all necessary things for a solid start
        /// </summary>
        private void InitializeGame()
        {
            enteredNumber = 0;
            enterCounter = 0;
            answerIndexCode = -1;
            TxtValue.Text = "";
            LblCounter.Text = "";
            CmdRestart.Visible = false;

            GenerateLimitAndSecret();

            LblText1.Text = answers[4] + upperLimit + ".";
        }

        private void GenerateLimitAndSecret()
        {
            Random r = new Random();
            upperLimit = r.Next(50, 100);
            secretNumber = r.Next(0, upperLimit);
        }
        /// <summary>
        /// Check the entered number, if it's the same than the secretNumber
        /// </summary>
        private void CheckNumber()
        {
            if (enteredNumber < 0 && enteredNumber > upperLimit)
            {
                ShowErrorMessages();
            }
            if (enteredNumber == secretNumber)
            {
                answerIndexCode = 2;
                CmdRestart.Visible = true;
            }
            else
            {
                if (enteredNumber > secretNumber)
                {
                    answerIndexCode = 1;
                }
                else
                {
                    answerIndexCode = 0;
                }
            }

            enterCounter++;
            PutTextOut();
        }

        private void PutTextOut()
        {
            LblAnswer.Text = answers[answerIndexCode];
            LblCounter.Text = enterCounter + answers[3];
        }

        private void ShowErrorMessages()
        {
            MessageBox.Show("Nur Zahlen zwischen 0 und " + upperLimit + "erlaubt");
        }
    }
}