using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainMenuForm
{

    /**
    Major Project: Arcade Classics Compilation
    Authors: Rajyah Kolluri, Reeham Imam, Manish Tamang, Matthew Eagan
    Course: IT-145 - Foundation in App Development
    Professor: Barbara Bancroft
    Due Date: April 16, 2023
    **/

    //Start M.E.
    public partial class SpaceShooterGame : Form
    {
        bool moveLeft, moveRight, moveUp, moveDown; //Allows for Player Movement
        bool playerShoot; //Controls firing of the laser
        int shipSpeed = 13, laserSpeed = 18, score = 0, hScore = 0, asteroidSpeed = 6, ufoSpeed = 10,
            spawnTime = 20, shootTime = 20, enemyLaserPosX, enemyLaserPosY; //Movement Speeds and misc. timer values
        Bitmap rotateObj;

        PictureBox PlayerShip = new PictureBox();
        Random coor = new Random();

        //Established sound effects
        SoundPlayer gameBGM = new SoundPlayer("GameBGM.wav");
        SoundPlayer playerShootSFX = new SoundPlayer("PlayerShoot.wav");
        SoundPlayer playerLoseSFX = new SoundPlayer("PlayerLose.wav");
        SoundPlayer objDestroySFX = new SoundPlayer("ObjDestroy.wav");

        private void SpaceShooterGame_Load(object sender, EventArgs e)
        {
            GameSetup();
        }

        public SpaceShooterGame()
        {
            InitializeComponent();
            Background.BackgroundImage = Properties.Resources.Background;
            PlayerShip.BackgroundImage = Properties.Resources.PlayerShip;
        }

        private void SpaceShooterGame_KeyDown(object sender, KeyEventArgs e)//Activates Boolean Operators for player movement
        {
            if (e.KeyCode == Keys.Left)
            {
                if (PlayerShip.Right <= 0)
                    PlayerShip.Left = this.ClientSize.Width;
                else
                    moveLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                if (PlayerShip.Left < this.ClientSize.Width)
                    moveRight = true;
                else
                    PlayerShip.Left = 0 - PlayerShip.Width;
            }
            if (e.KeyCode == Keys.Up)
            {
                if (PlayerShip.Top <= (0 + (PlayerShip.Height / 2)))
                    moveUp = false;
                else
                    moveUp = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                if (PlayerShip.Bottom < (this.ClientSize.Height - (PlayerShip.Height / 2)))
                    moveDown = true;
                else
                    moveDown = false;
            }
        }

        private void SpaceShooterGame_KeyUp(object sender, KeyEventArgs e)//Resets boolean controls
        {
            if (e.KeyCode == Keys.Left)
            {
                moveLeft = false;
                PlayerShip.BackgroundImage = Properties.Resources.PlayerShip;
            }
            if (e.KeyCode == Keys.Right)
            {
                moveRight = false;
                PlayerShip.BackgroundImage = Properties.Resources.PlayerShip;
            }
            if (e.KeyCode == Keys.Up)
                moveUp = false;
            if (e.KeyCode == Keys.Down)
                moveDown = false;
            if (e.KeyCode == Keys.Space && playerShoot == false)
            {
                playerShoot = true;
                Shoot("Player");
                playerShootSFX.Play();
            }
        }
        private void Shoot(string laserTag)//Creates Laser Objects
        {
            //Initializes design and location for laser objects
            PictureBox Laser = new PictureBox();
            Laser.BackgroundImage = Properties.Resources.TempLaser;
            Laser.BackColor = Color.Transparent;
            Laser.BackgroundImageLayout = ImageLayout.Stretch;
            Laser.Size = new Size(45, 60);
            Laser.Tag = laserTag;
            Laser.Left = PlayerShip.Left + PlayerShip.Width / 2;

            if ((string)Laser.Tag == "Player")//Player Lasers
            {
                Laser.Top = PlayerShip.Top - 30;
            }
            if ((string)Laser.Tag == "Enemy")//UFO Lasers
            {
                Laser.Location = new Point(enemyLaserPosX, enemyLaserPosY);
            }

            this.Controls.Add(Laser);
            Laser.BringToFront();
        }

        private void CreateObst(string obstacleTag)
        {
            int x = coor.Next(10, this.ClientSize.Width - 200);//Establishes a random x coordinate to spawn obstacles

            PictureBox Obstacle = new PictureBox();
            Obstacle.Tag = obstacleTag;//Initializes tags to define different objects under the same instance

            if (obstacleTag == "Asteroid")//Initializes design and location for asteroid obstacles
            {
                rotateObj = (Bitmap)Bitmap.FromFile("Asteroid.png");
                rotateObj.RotateFlip(RotateFlipType.Rotate90FlipX);
                Obstacle.Size = new Size(200, 200);
                Obstacle.BackgroundImage = rotateObj;
                Obstacle.BackgroundImageLayout = ImageLayout.Stretch;
                Obstacle.BackColor = Color.Transparent;
                Obstacle.Location = new Point(x, 0 - Obstacle.Height);
            }

            if (obstacleTag == "UFO")//Initializes design and location for ufo obstacles
            {
                Obstacle.Size = new Size(100, 100);
                Obstacle.BackgroundImage = Properties.Resources.UFO;
                Obstacle.BackgroundImageLayout = ImageLayout.Stretch;
                Obstacle.BackColor = Color.Transparent;
                Obstacle.Location = new Point(x, 0 - Obstacle.Width / 6);

                enemyLaserPosX = Obstacle.Left + (Obstacle.Width / 2);
                enemyLaserPosY = Obstacle.Top + 30;
            }

            this.Controls.Add(Obstacle);
            Obstacle.BringToFront();
        }

        private void SpaceGameTimer_Tick(object sender, EventArgs e)//Controls all movement of objects and object spawning
        {
            spawnTime -= 1;
            shootTime -= 1;

            //Updates score counters at top of screen
            scoreCounter.Text = "SCORE: " + score;
            if (hScore < score)
            {
                hScore = score;
                highScoreCounter.Text = "HIGH SCORE: " + hScore;
            }

            if (score >= 500)//Increases speed and difficulty of game upon reaching a score of 500
            {
                ufoSpeed = 12;
                asteroidSpeed = 8;
            }

            //Controls movement of the player ship in all directions and changes sprites for different directions
            if (moveLeft)
            {
                PlayerShip.Left -= shipSpeed;
                PlayerShip.BackgroundImage = Properties.Resources.PlayerShip_Left;
            }
            if (moveRight)
            {
                PlayerShip.Left += shipSpeed;
                PlayerShip.BackgroundImage = Properties.Resources.PlayerShip_Right;
            }
            if (moveUp)
                PlayerShip.Top -= shipSpeed;
            if (moveDown)
                PlayerShip.Top += shipSpeed;
            //End player movement

            if (spawnTime < 1)//Spawns new enemies in given intervals
            {
                CreateObst("Asteroid");
                CreateObst("UFO");

                if (score >= 500)
                {
                    spawnTime = 50;
                }
                else
                {
                    spawnTime = 65;
                }
            }

            if (shootTime < 1)//Allows the ufo objects to fire lasers at the player
            {
                Shoot("Enemy");
                shootTime = 110;
            }

            foreach (Control Laser in this.Controls)//Controls the movement of laser objects
            {
                if (Laser is PictureBox && (string)Laser.Tag == "Player")
                {
                    Laser.Top -= laserSpeed;
                    playerShoot = false;

                    //Removes object if off screen to save memory
                    if (Laser.Top < 5)
                        this.Controls.Remove(Laser);
                }

                if (Laser is PictureBox && (string)Laser.Tag == "Enemy")
                {
                    Laser.Top += laserSpeed;

                    //Ends the game if the player intersects an enemy laser
                    if (Laser.Bounds.IntersectsWith(PlayerShip.Bounds))
                    {
                        this.Controls.Remove(Laser);
                        this.Controls.Remove(PlayerShip);
                        playerLoseSFX.Play();
                        GameEnd();
                    }
                }
            }

            foreach (Control Obstacle in this.Controls)
            {
                //Instances of Obstacle (asteroid) defined by its tag
                if (Obstacle is PictureBox && (string)Obstacle.Tag == "Asteroid")
                {
                    Obstacle.Top += asteroidSpeed;
                    if (Obstacle.Top > Background.Bottom)
                        this.Controls.Remove(Obstacle);

                    //Ends the game if the player ship intersects with an obstacle
                    if (Obstacle.Bounds.IntersectsWith(PlayerShip.Bounds))
                    {
                        this.Controls.Remove(Obstacle);
                        this.Controls.Remove(PlayerShip);
                        playerLoseSFX.Play();
                        GameEnd();
                    }

                    //Removes the object if a laser intersects with it
                    foreach (Control Laser in this.Controls)
                    {
                        if (Laser is PictureBox && (string)Laser.Tag == "Player")
                        {
                            if (Laser.Bounds.IntersectsWith(Obstacle.Bounds))
                            {
                                this.Controls.Remove(Laser);
                                this.Controls.Remove(Obstacle);
                                objDestroySFX.Play();
                                score += 10;
                            }
                        }
                    }
                }

                //Instances of Obstacle (ufo) defined by its tag
                if (Obstacle is PictureBox && (string)Obstacle.Tag == "UFO")
                {
                    //Allows objects with the 'UFO' tag to 'chase' the player on the screen
                    enemyLaserPosX = Obstacle.Top;
                    Obstacle.Top += ufoSpeed;
                    if (moveLeft)
                        Obstacle.Left += ufoSpeed;
                    if (moveRight)
                        Obstacle.Left -= ufoSpeed;
                    if (Obstacle.Top > Background.Bottom)
                        this.Controls.Remove(Obstacle);

                    //Ends the game if the player ship intersects with an obstacle
                    if (Obstacle.Bounds.IntersectsWith(PlayerShip.Bounds))
                    {
                        this.Controls.Remove(Obstacle);
                        this.Controls.Remove(PlayerShip);
                        playerLoseSFX.Play();
                        GameEnd();
                    }

                    //Removes the object if a laser intersects with it
                    foreach (Control Laser in this.Controls)
                    {
                        if (Laser is PictureBox && (string)Laser.Tag == "Player")
                        {
                            if (Laser.Bounds.IntersectsWith(Obstacle.Bounds))
                            {
                                this.Controls.Remove(Laser);
                                this.Controls.Remove(Obstacle);
                                score += 25;
                            }
                        }
                    }
                }
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            //Resets the game
            GameSetup();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //Returns to main arcade menu
            playerLoseSFX.Play();
            this.Close();

            //Start M.T.
            ArcadeMainMenu main = new ArcadeMainMenu();
            main.Show();
            //End M.T.
        }

        private void GameEnd()//Is Called if the player loses
        {
            SoundPlayer menuBGM = new SoundPlayer("MenuBGM.wav");
            menuBGM.PlayLooping();
            SpaceGameTimer.Stop();

            //Removes all PictureObject Items from screen
            for (int i = this.Controls.Count - 1; i >= 0; i--)
            {
                Control element = this.Controls[i];
                if (element != Background)
                {
                    //Removes elements by their tags
                    if ((string)element.Tag == "UFO" || (string)element.Tag == "Asteroid" || (string)element.Tag == "Player" || (string)element.Tag == "Enemy")
                    {
                        this.Controls.RemoveAt(i);
                    }
                }

                //Displays menu graphics
                ExitButton.Visible = true;
                ResetButton.Visible = true;
                Title.Visible = true;
            }
        }

        private void GameSetup()//Is called upon the program loading and if the user resets the game
        {
            gameBGM.PlayLooping();

            //Establishes the layout of the menu elements
            Title.Location = new Point((this.ClientSize.Width / 2) - (Title.Width / 2), this.ClientSize.Height / 2);
            ResetButton.Left = this.ClientSize.Width - ResetButton.Width;
            ExitButton.Visible = false;
            ResetButton.Visible = false;
            Title.Visible = false;

            //Declares the PlayerShip model through code to allow for resetting & to avoid porting issues
            this.Controls.Add(PlayerShip);
            PlayerShip.Size = new Size(120, 90);
            PlayerShip.BackgroundImage = Properties.Resources.PlayerShip;
            PlayerShip.BackgroundImageLayout = ImageLayout.Stretch;
            PlayerShip.Location = new Point(this.ClientSize.Width / 2, this.ClientSize.Height - PlayerShip.Height);
            PlayerShip.BringToFront();

            //Resets speed of obstacles
            asteroidSpeed = 6;
            ufoSpeed = 10;

            playerShoot = false;
            score = 0;
            SpaceGameTimer.Start();
        }
    }
}
//End M.E.
