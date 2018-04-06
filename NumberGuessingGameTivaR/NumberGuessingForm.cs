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
/*
     * Created by: Tiva Rait
     * Created on: 07-03=2018
     * Created for: ICS3U Programming
     * Daily Assignment – Day #11 - Number Guessing Game
     * This program asks the user to type in a number if the user types in the wrong number then...
     * ... It tells the user and same thing if it is correct.
    */

namespace NumberGuessingGameTivaR
{
    public partial class frmNumberGuessing : Form
    {
        // Constant that has the secret number.
        const int secretNumber = 9;

        // Sounds
        SoundPlayer correct = new SoundPlayer(NumberGuessingGameTivaR.Properties.Resources.Correct_Answer_Sound_Effect);
        SoundPlayer wrong = new SoundPlayer(NumberGuessingGameTivaR.Properties.Resources.Wrong_Buzzer_Sound_Effect);

        public frmNumberGuessing()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            // Define Variables
            int guess;

            // Get the users guess from the Text box
            guess = int.Parse(txtGuessBox.Text);

            // Compare numbers to see if the user guessed the right number.
            if (secretNumber == guess)
            {
                this.picSymbol.Image = Properties.Resources.checkmark;
                correct.Play();
            }
            else
            {
                this.picSymbol.Image = Properties.Resources.red_x;
                wrong.Play();
            }
        }
    }
}
