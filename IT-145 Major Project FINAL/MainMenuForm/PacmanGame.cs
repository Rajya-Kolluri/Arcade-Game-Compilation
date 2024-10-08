﻿using System;
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
    /***********************************************************************
    Major Project: Arcade Classics Compilation
    Authors: Rajya Kolluri, Reeham Imam, Manish Tamang, Matthew Eagan
    Course: IT-145 - Foundation in App Development
    Professor: Barbara Bancroft
    Due Date: April 16, 2023
    ***********************************************************************/

    public partial class PacmanGame : Form
    {
        private SoundPlayer soundPlayer;
        bool godown, goleft, goright, goup, isGameOver;
 public PacmanGame()
        {
            InitializeComponent();
            resetGame();
            /*sound starts playing*/
            soundPlayer = new SoundPlayer("pacman_beginning.wav");
            soundPlayer.PlayLooping();
        }
        private void mainGameTimer(object sender, EventArgs e)
        {
            gameEndButton.Visible = false;
            txtscore.Text = "Score: " + score;
// Pacman movement
            if (goleft == true)
            {
                pacman.Left -= playerSpeed;
                pacman.Image = Properties.Resources.left;
            }
            if (goright == true)
            {
                pacman.Left += playerSpeed;
                pacman.Image = Properties.Resources.right;
            }
            if (goup == true)
            {
                pacman.Top -= playerSpeed;
                pacman.Image = Properties.Resources.Up;
            }
            if (godown == true)
            {
                pacman.Top += playerSpeed;
                pacman.Image = Properties.Resources.down;
            }
            //teleportation
            // if pacman goes off the screen on left, it shows from right and vice versa
            // if pacman goes off top the edge of form, it shows from the bottom edge of the form and vice versa
            if (pacman.Left < -10)
            {
                pacman.Left = 460;
            }
            if (pacman.Left > 460)
            {
                pacman.Left = -10;
            }
            if (pacman.Top < -10)
            {
                pacman.Top = 383;
            }
            if (pacman.Top > 383)
            {
                pacman.Top = 0;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                // if pacman touches coins, coins dissapear and increases score
                    if ((string)x.Tag == "coin" && x.Visible == true)
                    {
                        if (pacman.Bounds.IntersectsWith(x.Bounds))
                        {
                            score += 1;
                            x.Visible = false;
                            soundPlayer = new SoundPlayer("pacman_chomp.wav");
                            soundPlayer.Play();

                        }
                    }
                    //ends game if pacman touches wallks and ghosts
                    if ((string)x.Tag == "walls")
                    {
                        if (pacman.Bounds.IntersectsWith(x.Bounds))
                        {
                            soundPlayer = new SoundPlayer("pacman_death.wav");
                            soundPlayer.Play();
                            gameOver("you lose");
                            gameEndButton.Visible = true;

                        }
                        /*if (pinkGhost.Bounds.IntersectsWith(x.Bounds))
                        {
                            pinkGhostX = -pinkGhostX;
                        }*/
                    }
                    if ((string)x.Tag == "ghost")
                    {
                        if (pacman.Bounds.IntersectsWith(x.Bounds))
                        {
                            soundPlayer = new SoundPlayer("pacman_death.wav");
                            soundPlayer.Play();
                            gameOver("you lose");
                            gameEndButton.Visible = true;

                        }
                    }
                }
            }
            //moving Ghosts
            redGhost.Left += redGhostSpeed;
            // red ghost oscillates between picturebox1 and picturebox2
            if (redGhost.Bounds.IntersectsWith(pictureBox1.Bounds) || redGhost.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                redGhostSpeed = -redGhostSpeed;
            }
            yellowGhost.Left -= yellowGhostSpeed;
            // yellow ghost oscillates between picturebox1 and picturebox2
            if (yellowGhost.Bounds.IntersectsWith(pictureBox3.Bounds) || yellowGhost.Bounds.IntersectsWith(pictureBox4.Bounds))
            {
                yellowGhostSpeed = -yellowGhostSpeed;
            }
            //pink ghost moves around screen and bounces back when touches the edges of form

            pinkGhost.Left -= pinkGhostX;
            pinkGhost.Top -= pinkGhostY;
            if (pinkGhost.Top < 0 || pinkGhost.Top > 320)
            {
                pinkGhostY = -pinkGhostY;
            }
            if (pinkGhost.Left < 0 || pinkGhost.Left > 390)
            {
                pinkGhostX = -pinkGhostX;
            }
// you win if you get all the coins dissapeared
            if (score == 70)
            {
                gameOver("You Win!!!!");

            }

        }

        int score, playerSpeed, redGhostSpeed, yellowGhostSpeed, pinkGhostX, pinkGhostY;

        private void gameEndButton_Click(object sender, EventArgs e)
        {
            this.Close();
            ArcadeMainMenu main = new ArcadeMainMenu();
            main.Show();
            soundPlayer.Stop();
        }

        private void PacmanGame_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goup = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
            if (e.KeyCode == Keys.Enter && isGameOver == true)
            {
                resetGame();
            }
        }

        private void PacmanGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goup = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
        }
        private void resetGame()
        {
        //restarts game and makes sure everything is back in its position
            txtscore.Text = "Score: 0";
            score = 0;
            redGhostSpeed = 5;
            yellowGhostSpeed = 5;
            pinkGhostX = 5;
            pinkGhostY = 5;
            playerSpeed = 8;
            isGameOver = false;
            pacman.Left = 5;
            pacman.Top = 29;
            redGhost.Left = 229;
            redGhost.Top = 19;
            yellowGhost.Left = 263;
            yellowGhost.Top = 289;
            pinkGhost.Left = 365;
            pinkGhost.Top = 160;
            PacmanGameTimer.Start();

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    x.Visible = true;
                }
            }
        }
// ends game and calculates the score
            private void gameOver(string message)
            {
                isGameOver = true;
                PacmanGameTimer.Stop();
                txtscore.Text = "Score: " + score + Environment.NewLine + message;
           
        }




        }
    }
