using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

/***********************************************************************
Major Project: Arcade Classics Compilation
Authors: Rajyah Kolluri, Reeham Imam, Manish Tamang, Matthew Eagan
Course: IT-145 - Foundation in App Development
Professor: Barbara Bancroft
Due Date: April 16, 2023
***********************************************************************/


//Start R.I.
namespace MainMenuForm
{
    public partial class MemoryPuzzleGame : Form
    {
        Point EmptyPoint; // Represents a Point that has X and Y values set to zero
        ArrayList images = new ArrayList();
        public MemoryPuzzleGame()
        {
            EmptyPoint.X = 180; // set's X to 180
            EmptyPoint.Y = 180; // Set's Y to 180
            InitializeComponent();
        }
        // Will add cropped images to 8 boxes
        private void AddImagesToButtons(ArrayList images)
        {
            int i = 0;
            int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7 };

            arr = suffle(arr);
            // the 'Boxes' are buttons, each will get a random cropped image
            foreach (Button b in panel1.Controls)
            {
                if (i < arr.Length)
                {
                    b.Image = (Image)images[arr[i]];
                    i++;
                }
            }
        }
        // shuffle images
        private int[] suffle(int[] arr)
        {
            Random rand = new Random();
            arr = arr.OrderBy(x => rand.Next()).ToArray();
            return arr;
        }
    
        private void cropImageTomages(Image orginal, int w, int h)
        {
            Bitmap bmp = new Bitmap(w, h); //an object used to work with images defined by pixel data

            Graphics graphic = Graphics.FromImage(bmp); //provides methods for drawing objects to the display device


            graphic.DrawImage(orginal, 0, 0, w, h);

            graphic.Dispose();

            int movr = 0, movd = 0;

            for (int x = 0; x < 8; x++)
            {
                Bitmap piece = new Bitmap(90, 90); //an object used to work with images defined by pixel data

                for (int i = 0; i < 90; i++)
                    for (int j = 0; j < 90; j++)
                        piece.SetPixel(i, j,
                            bmp.GetPixel(i + movr, j + movd));

                images.Add(piece);
                movr += 90;
                if (movr == 270)
                {
                    movr = 0;
                    movd += 90;
                }
            }

        }
        // if any button is clicked it will move
        private void button1_Click(object sender, EventArgs e)
        {
            MoveButton((Button)sender);
        }
        // Helps buttons swap and move
        private void MoveButton(Button btn)
        {
            if (((btn.Location.X == EmptyPoint.X - 90 || btn.Location.X == EmptyPoint.X + 90)
                && btn.Location.Y == EmptyPoint.Y)
                || (btn.Location.Y == EmptyPoint.Y - 90 || btn.Location.Y == EmptyPoint.Y + 90)
                && btn.Location.X == EmptyPoint.X)
            {
                Point swap = btn.Location;
                btn.Location = EmptyPoint;
                EmptyPoint = swap;
            }

            if (EmptyPoint.X == 180 && EmptyPoint.Y == 180)
                CheckValid();
        }

        private void CheckValid()
        {
            int count = 0, index;
            foreach (Button btn in panel1.Controls)
            {
                index = (btn.Location.Y / 90) * 3 + btn.Location.X / 90;
                if (images[index] == btn.Image)
                    count++;
            }
            if (count == 8)
                MessageBox.Show("You win!");
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exiting...");
            //Start M.E.
            this.Close();
            ArcadeMainMenu main = new ArcadeMainMenu();
            main.Show();
            //Start M.E.
        }

        private void START_Click(object sender, EventArgs e)
        {
            foreach (Button b in panel1.Controls)
                b.Enabled = true;

            Image orginal = Image.FromFile(@"img\img.jpg");

            cropImageTomages(orginal, 270, 270);

            AddImagesToButtons(images);
        }
    }
}
//End R.I.
