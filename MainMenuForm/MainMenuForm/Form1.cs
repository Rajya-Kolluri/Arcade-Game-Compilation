/**



**/
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

            FlappyDragonGame newflappydragon = new FlappyDragonGame();
            newflappydragon.Show();
            mainMenuExit();
            
        }

        private void PacMan_Click(object sender, EventArgs e)
        {
            PacmanGame newPacmanGame = new PacmanGame();
            newPacmanGame.Show();
            mainMenuExit();
        }

        private void MemoryPuzzle_Click(object sender, EventArgs e)
        {
            MemoryPuzzleGame newMemoryPuzzleGame = new MemoryPuzzleGame();
            newMemoryPuzzleGame.Show();
            mainMenuExit();
        }

        private void SpaceShooter_Click(object sender, EventArgs e)
        {
            SpaceShooterGame newSpaceShooterGame = new SpaceShooterGame();
            newSpaceShooterGame.Show();
            mainMenuExit();
        }
    }
}
