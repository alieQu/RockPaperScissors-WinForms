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
using System.IO;
using System.Drawing.Text;

namespace WindowsFormsApp5
{

    public partial class Form1 : Form
    {


        private SoundPlayer gameSound;
        private SoundPlayer playSound;
        private SoundPlayer loseSound;
        private SoundPlayer winSound;
        private SoundPlayer gameOver;
        private SoundPlayer youWin;


        string ComputerChoice;
        string UserChoice;
        string[] options = { "rock", "paper", "scissors" };


        int flashCount = 0;
        int player1Score = 0;
        int player2Score = 0;

        Random random = new Random();

        PrivateFontCollection pixelFont = new PrivateFontCollection();

        private void Form1_Load(object sender, EventArgs e)
        {
            pixelFont.AddFontFile(Application.StartupPath + "\\PressStart2P-Regular.ttf");
            Font newFont = new Font(pixelFont.Families[0], 16f);
            Font font = new Font(pixelFont.Families[0], 72f);
            SetFontRecursive(this, newFont);

            YouWin.Font = font;
            lblGameOver.Font = font;
        }



        private void SetFontRecursive(Control parent, Font font)
        {
            parent.Font = font;
            foreach (Control c in parent.Controls)
            {
                SetFontRecursive(c, font);
            }
        }
        public Form1()
        {

            InitializeComponent();

            panelGame.Visible = false;
            panelLoser.Visible = false;
            panelWinner.Visible = false;

            Player1Scissors.Visible = false;
            Player1Paper.Visible = false;
            Player1Rotate.Visible = false;
            Player2Scissors.Visible = false;
            Player2Paper.Visible = false;
            Player2Rotate.Visible = false;


            gameSound = new SoundPlayer(Properties.Resources.game);
            playSound = new SoundPlayer(Properties.Resources.play);
            loseSound = new SoundPlayer(Properties.Resources.lose);
            winSound = new SoundPlayer(Properties.Resources.win);
            gameOver = new SoundPlayer(Properties.Resources.gameover);
            youWin = new SoundPlayer(Properties.Resources.youwin);

            axWindowsMediaPlayer1.URL = Application.StartupPath + @"\gamesong.mp3";
            axWindowsMediaPlayer1.settings.setMode("loop", true);
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.Visible = false;

        }

        private void SetButtonsEnabled(bool value)
        {
            Rock.Enabled = value;
            Paper.Enabled = value;
            Scissors.Enabled = value;
        }



        private void ResetHands()
        {

            Player1Paper.Visible = false;
            Player1Scissors.Visible = false;
            Player1Rotate.Visible = false;
            Player1Rock.Visible = false;


            Player2Paper.Visible = false;
            Player2Scissors.Visible = false;
            Player2Rotate.Visible = false;
            Player2Rock.Visible = false;

        }


        private void Timer1_Tick(object sender, EventArgs e)
        {
            Player1Rotate.Visible = !Player1Rotate.Visible;
           
            Player2Rotate.Visible = !Player2Rotate.Visible;
           
            flashCount++;
            if (flashCount >= 6)
            {
                Timer1.Stop();
                flashCount = 0;
            }

        }



        

        private async void Game()
        {
           
            int index = random.Next(options.Length);
            ComputerChoice = options[index];

            gameSound.Play();
            SetButtonsEnabled(false);

            ResetHands();

            Timer1.Start();
            await Task.Delay(3000);

           

            if (UserChoice == "rock") { Player1Rock.Visible = true; }
            else if (UserChoice == "paper") { Player1Paper.Visible = true; }
            else if (UserChoice == "scissors") { Player1Scissors.Visible = true; }

            if (ComputerChoice == "rock") { Player2Rock.Visible = true; }
            else if (ComputerChoice == "paper") { Player2Paper.Visible = true; }
            else if (ComputerChoice == "scissors") { Player2Scissors.Visible = true; }

            if (ComputerChoice == "rock" && UserChoice == "paper" ||
                ComputerChoice == "scissors" && UserChoice == "rock" ||
                ComputerChoice == "paper" && UserChoice == "scissors")

            {
                WinnerIs.Text = "Player1 Wins!";
                winSound.Play();
                player1Score++;
            }

            else if (ComputerChoice == UserChoice) { WinnerIs.Text = "It's a Draw!"; }

            else
            {
                WinnerIs.Text = "Player2 Wins!";
                loseSound.Play();
                player2Score++;
            }

            await Task.Delay(1000);
            Player1.Text = player1Score.ToString();
            Player2.Text = player2Score.ToString();
            SetButtonsEnabled(true);

            await Task.Delay(1000);
            ResetHands();
            WinnerIs.Text = " ";




            if (player1Score >= 3 || player2Score >= 3)
            {

                SetButtonsEnabled(false);


                if (player1Score > player2Score)
                {

                    await Task.Delay(100);
                    panelWinner.Visible = true;
                    youWin.Play();
                }
                else
                {
                    await Task.Delay(100);
                    panelLoser.Visible = true;
                    gameOver.Play();
                }
                panelGame.Visible = false;
                panelMenu.Visible = false;
            }

        }



        private void retry_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = true;
            panelGame.Visible = false;
            panelWinner.Visible = false;
            panelLoser.Visible = false;
            playSound.Play();
        }

        private void PlayAgain_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = true;
            panelGame.Visible = false;
            panelWinner.Visible = false;
            panelLoser.Visible = false;
            playSound.Play();

        }


        private void Rock_Click(object sender, EventArgs e)
        {
            if (player1Score < 3 && player2Score < 3)
            {
                UserChoice = "rock";
                Game();
            }
        }
        private void Paper_Click(object sender, EventArgs e)
        {
            if (player1Score < 3 && player2Score < 3)
            {
                UserChoice = "paper";
                Game();
            }

        }

        private void Scissors_Click(object sender, EventArgs e)
        {
            if (player1Score < 3 && player2Score < 3)
            {
                UserChoice = "scissors";
                Game();
            }
        }




        private void Back_Click_1(object sender, EventArgs e)
        {
            panelMenu.Visible = true;
            panelGame.Visible = false;
            playSound.Play();
        }

        private void Play_Click(object sender, EventArgs e)
        {
            player1Score = 0;
            player2Score = 0;
            Player1.Text = player1Score.ToString();
            Player2.Text = player2Score.ToString();
            SetButtonsEnabled(true); panelMenu.Visible = false;
            panelGame.Visible = true;
            playSound.Play();
            Player1Hand.Visible = true;
            Player2Hand.Visible = true;
        }
    }
}
