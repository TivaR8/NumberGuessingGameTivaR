using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        public frmNumberGuessing()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            // Define Variables


            // Putting in sound
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.Play();
        }
    }
}
