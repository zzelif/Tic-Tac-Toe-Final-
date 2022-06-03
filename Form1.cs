using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalTicTacToe
{
    public partial class formTictactoe : Form
    {
        Player currentPlayer;
        int playerWins = 0;
        int computerWins = 0;
        int counter = 0;

        public formTictactoe()
        {
            InitializeComponent();
        }
        public enum Player
        {
            X,
            O
        }

        private void buttonClick(object sender, EventArgs e)
        {
            try
            {
                var button = (Button)sender;
                currentPlayer = Player.X;
                button.Text = currentPlayer.ToString();
                button.Enabled = false;
                button.BackColor = System.Drawing.Color.LightGreen;
                counter++;
                soundPlayer = new SoundPlayer("click.wav");
                Check();
                timerAi.Start();
                soundPlayer.Play();
            }
            catch { }
        }

        private void playAi(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if (x is Button && x.Text == "" && x.Enabled)
                {
                    x.Enabled = false;
                    currentPlayer = Player.O;
                    x.Text = currentPlayer.ToString();
                    x.BackColor = System.Drawing.Color.LightGoldenrodYellow;
                    soundPlayer = new SoundPlayer("click.wav");
                    counter++;
                    timerAi.Stop();
                    Check();
                    soundPlayer.Play();
                    break;
                }
                else
                {
                    timerAi.Stop();
                }
            }
        }

        private void resetGame(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {

                if (x is Button && x.Tag == "play")
                {
                    ((Button)x).Enabled = true;
                    ((Button)x).Text = "";
                    ((Button)x).BackColor = default(Color);
                }

            }
            counter = 0;
        }
    }
}
