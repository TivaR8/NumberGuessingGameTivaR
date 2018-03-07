using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            // Definign Variables


            //Putting in sound
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.Play();
        }
    }
}
