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

    /***********************************************************************
    Major Project: Arcade Classics Compilation
    Authors: Rajyah Kolluri, Reeham Imam, Manish Tamang, Matthew Eagan
    Course: IT-145 - Foundation in App Development
    Professor: Barbara Bancroft
    Due Date: April 16, 2023
    ***********************************************************************/

//Start M.T.
namespace MainMenuForm
{
    public partial class ArcadeMainMenu : Form
    {
        private SoundPlayer mainMenuMusic;
        public ArcadeMainMenu()
        {
            InitializeComponent();
            mainMenuMusic = new SoundPlayer("MainMenuMusic.wav");
            mainMenuMusic.PlayLooping();
        }
        private void mainMenuExit()
        {
            this.Hide();
            mainMenuMusic.Stop();
        }
        private void FlappyDragon_Click(object sender, EventArgs e)
        {
            //Launches the Flappy Dragon game
            FlappyDragonGame newflappydragon = new FlappyDragonGame();
            newflappydragon.Show();
            mainMenuExit();
        }

        //Start R.K.
        private void PacMan_Click(object sender, EventArgs e)
        {
            //Launches the PacMan game
            PacmanGame newPacmanGame = new PacmanGame();
            newPacmanGame.Show();
            mainMenuExit();
        }
        //End R.K.

        //Start R.I.
        private void MemoryPuzzle_Click(object sender, EventArgs e)
        {
            //Launches the Memory Puzzle Game
            MemoryPuzzleGame newMemoryPuzzleGame = new MemoryPuzzleGame();
            newMemoryPuzzleGame.Show();
            mainMenuExit();
        }
        //End R.I.

        //Start M.E.
        private void SpaceShooter_Click(object sender, EventArgs e)
        {
            //Launches the Space Shooter Game
            SpaceShooterGame newSpaceShooterGame = new SpaceShooterGame();
            newSpaceShooterGame.Show();
            mainMenuExit();
        }
        //End M.E.
    }
}
//End M.T.
