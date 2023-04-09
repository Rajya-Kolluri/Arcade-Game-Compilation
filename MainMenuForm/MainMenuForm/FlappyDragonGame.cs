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
namespace MainMenuForm
{
    public partial class FlappyDragonGame : Form
    {
        int tubeSpeed = 10;//initial speed of the tubes
        int gravity = 10;//initial gravity
        int score = 0;
        int maxScore = 0;
        private SoundPlayer FlappyDragonMusic;
        public FlappyDragonGame()
        {
            InitializeComponent();
            FlappyDragonMusic = new SoundPlayer("FlappyDragonMusic.wav");
            FlappyDragonMusic.PlayLooping();
        }

      
        private void flappyDragonGameTimer_Tick(object sender, EventArgs e)
        {
            dragon.Top += gravity;

            tubeDown.Left -= tubeSpeed;//moves the bottom tube to the left at tubeSpeet
            tubeUp.Left -= tubeSpeed;//moves the top tube to the left at tubeSpeed
            scoreCounter.Text = "Score: " + score; 
            resetButton.Enabled = false;//disables the restart button 
            ExitButton.Enabled = false;//disables the exit button 
            soundButton.Enabled = false;//disables the sound button when the gamestarts
            soundButton.Checked = true;//starts the game with sound on

            //If statement that moves the tubes back to the right after it's off screen
            if (tubeDown.Left < -150)
            {
                tubeDown.Left = 750;

            }
            if (tubeUp.Left < -180)
            {
                tubeUp.Left = 655;
                score++;
            }



            //If the dragon picture box touches the tubes or the floor the game ends.
            if (dragon.Bounds.IntersectsWith(tubeUp.Bounds) || dragon.Bounds.IntersectsWith(tubeDown.Bounds) || dragon.Bounds.IntersectsWith(floor.Bounds))
            {
                endgame();
            }



            //if statements that increases the speed of tubes as the score gets higher
            if (score >= 3)
            {
                tubeSpeed = 15;

            }
            else if (score > 4)
            {
                tubeSpeed = 50;

            }
            else if (score > 5)
            {
                tubeSpeed = 100;

            }
            else if (score >= 10)
            {
                tubeSpeed = 200;
            }
            else if (score > 20)
            {
                tubeSpeed = 300;
            }


            //If the dragon picturebox top hitbox touches the top of the screen the game ends.
            if (dragon.Top < -25)
            {
                endgame();
            }

            if (score < 1)
            {
                howToPlay.Text = "Press SpaceBar!";
            }
            else
            {
                howToPlay.Text = " ";
            }

        }

        private void FlappyDragonGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -10;

            }
        }

        private void FlappyDragonGame_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
        }
        private void endgame()
        {
            flappyDragonGameTimer.Stop();//stops the timer so the game stops

            //enables all the buttons
            resetButton.Enabled = true;
            ExitButton.Enabled = true;
            soundButton.Enabled = true;

            gameOverMessage.Text = "Game Over!!";

            //sets the new highscore if the score is bigger than the highscore
            if (maxScore <= score)
            {
                maxScore = score;
                highScoreCounter.Text = "HighScore: " + maxScore;
            }
        }

        private void soundButton_CheckedChanged(object sender, EventArgs e)
        {
            if (soundButton.Checked)
            {
                FlappyDragonMusic.PlayLooping();
            }
            else
            {
                FlappyDragonMusic.Stop();
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            flappyDragonGameTimer.Start();
            resetButton.Enabled = false;
            ExitButton.Enabled = false;
            soundButton.Enabled = false;
            score = 0;
            dragon.Location = new Point(50, 170);
            gameOverMessage.Text = "";
            tubeSpeed = 10;
            tubeDown.Left = 750;
            tubeUp.Left = 600;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            FlappyDragonMusic.Stop();
            ArcadeMainMenu main = new ArcadeMainMenu();
            main.Show();
            
        }
    }
}
