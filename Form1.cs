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

namespace FinalTicTacToe
{
    public partial class formTictactoe : Form
    {
        private SoundPlayer soundPlayer;
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
                    x.BackColor = System.Drawing.Color.Crimson;
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
            soundPlayer = new SoundPlayer("click.wav");
            soundPlayer.Play();
            foreach (Control x in this.Controls)
            {
                if (x is Button && (string)x.Tag == "play")
                {
                    ((Button)x).Enabled = true;
                    ((Button)x).Text = "";
                    ((Button)x).BackColor = default(Color);
                }

            }
        }

        private void Check()
        {
            if (
            Btn1.Text == "X" && Btn2.Text == "X" && Btn3.Text == "X" ||//Horizontal
            Btn4.Text == "X" && Btn5.Text == "X" && Btn6.Text == "X" ||
            Btn7.Text == "X" && Btn8.Text == "X" && Btn9.Text == "X" ||
            Btn1.Text == "X" && Btn4.Text == "X" && Btn7.Text == "X" ||//Vertical
            Btn2.Text == "X" && Btn5.Text == "X" && Btn8.Text == "X" ||
            Btn3.Text == "X" && Btn6.Text == "X" && Btn9.Text == "X" ||
            Btn1.Text == "X" && Btn5.Text == "X" && Btn9.Text == "X" ||//Diagonal
            Btn3.Text == "X" && Btn5.Text == "X" && Btn7.Text == "X")
            {
                soundPlayer = new SoundPlayer("youwin.wav");
                MessageBox.Show("Player Wins");
                playerWins++;
                WON();
                soundPlayer.Play();
                lblScore1.Text = "Player Wins- " + playerWins;
                counter = 0;
            }
            else if (
            Btn1.Text == "O" && Btn2.Text == "O" && Btn3.Text == "O" ||//Horizontal
            Btn4.Text == "O" && Btn5.Text == "O" && Btn6.Text == "O" ||
            Btn7.Text == "O" && Btn8.Text == "O" && Btn9.Text == "O" ||
            Btn1.Text == "O" && Btn4.Text == "O" && Btn7.Text == "O" ||//Vertical
            Btn2.Text == "O" && Btn5.Text == "O" && Btn8.Text == "O" ||
            Btn3.Text == "O" && Btn6.Text == "O" && Btn9.Text == "O" ||
            Btn1.Text == "O" && Btn5.Text == "O" && Btn9.Text == "O" || //Diagonal
            Btn3.Text == "O" && Btn5.Text == "O" && Btn7.Text == "O")
            {
                soundPlayer = new SoundPlayer("youlose.wav");
                MessageBox.Show("Computer Wins");
                computerWins++;
                WON();
                soundPlayer.Play();
                lblScore2.Text = "Computer Wins- " + computerWins;
                counter = 0;
            }
            counter = counter + 0;
            if (counter == 9)
            {
                soundPlayer = new SoundPlayer("draw.wav");
                MessageBox.Show("Draw");
                counter = 0;
                soundPlayer.Play();
            }
        }

        private void WON()
        {
            foreach (Control x in this.Controls)
            {

                if (x is Button && (string)x.Tag == "play")
                {
                    ((Button)x).Enabled = false;
                    ((Button)x).BackColor = default(Color);

                }

            }
        }
    }
}
