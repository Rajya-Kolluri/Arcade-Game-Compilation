
namespace MainMenuForm
{
    partial class FlappyDragonGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlappyDragonGame));
            this.highScoreCounter = new System.Windows.Forms.Label();
            this.soundButton = new System.Windows.Forms.CheckBox();
            this.gameOverMessage = new System.Windows.Forms.Label();
            this.howToPlay = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.dragon = new System.Windows.Forms.PictureBox();
            this.scoreCounter = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.floor = new System.Windows.Forms.PictureBox();
            this.tubeUp = new System.Windows.Forms.PictureBox();
            this.tubeDown = new System.Windows.Forms.PictureBox();
            this.clouds = new System.Windows.Forms.PictureBox();
            this.clouds3 = new System.Windows.Forms.PictureBox();
            this.clouds2 = new System.Windows.Forms.PictureBox();
            this.flappyDragonGameTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dragon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tubeUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tubeDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clouds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clouds3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clouds2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // highScoreCounter
            // 
            this.highScoreCounter.AutoSize = true;
            this.highScoreCounter.BackColor = System.Drawing.Color.Black;
            this.highScoreCounter.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScoreCounter.ForeColor = System.Drawing.Color.Transparent;
            this.highScoreCounter.Location = new System.Drawing.Point(131, 594);
            this.highScoreCounter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.highScoreCounter.Name = "highScoreCounter";
            this.highScoreCounter.Size = new System.Drawing.Size(141, 31);
            this.highScoreCounter.TabIndex = 33;
            this.highScoreCounter.Text = "HighScore: 0";
            // 
            // soundButton
            // 
            this.soundButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.soundButton.AutoSize = true;
            this.soundButton.BackColor = System.Drawing.Color.White;
            this.soundButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.soundButton.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soundButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.soundButton.Location = new System.Drawing.Point(433, 590);
            this.soundButton.Margin = new System.Windows.Forms.Padding(4);
            this.soundButton.Name = "soundButton";
            this.soundButton.Size = new System.Drawing.Size(83, 33);
            this.soundButton.TabIndex = 32;
            this.soundButton.Text = "Sound";
            this.soundButton.UseVisualStyleBackColor = false;
            this.soundButton.CheckedChanged += new System.EventHandler(this.soundButton_CheckedChanged);
            // 
            // gameOverMessage
            // 
            this.gameOverMessage.AutoSize = true;
            this.gameOverMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverMessage.Location = new System.Drawing.Point(280, 273);
            this.gameOverMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gameOverMessage.Name = "gameOverMessage";
            this.gameOverMessage.Size = new System.Drawing.Size(0, 57);
            this.gameOverMessage.TabIndex = 24;
            // 
            // howToPlay
            // 
            this.howToPlay.AutoSize = true;
            this.howToPlay.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howToPlay.Location = new System.Drawing.Point(288, 281);
            this.howToPlay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.howToPlay.Name = "howToPlay";
            this.howToPlay.Size = new System.Drawing.Size(0, 26);
            this.howToPlay.TabIndex = 31;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.White;
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ExitButton.Location = new System.Drawing.Point(534, 588);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(97, 37);
            this.ExitButton.TabIndex = 29;
            this.ExitButton.Text = "Exit Game";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // dragon
            // 
            this.dragon.BackColor = System.Drawing.Color.Transparent;
            this.dragon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dragon.Image = ((System.Drawing.Image)(resources.GetObject("dragon.Image")));
            this.dragon.Location = new System.Drawing.Point(52, 232);
            this.dragon.Margin = new System.Windows.Forms.Padding(4);
            this.dragon.Name = "dragon";
            this.dragon.Size = new System.Drawing.Size(99, 75);
            this.dragon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dragon.TabIndex = 20;
            this.dragon.TabStop = false;
            // 
            // scoreCounter
            // 
            this.scoreCounter.AutoSize = true;
            this.scoreCounter.BackColor = System.Drawing.Color.Black;
            this.scoreCounter.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreCounter.ForeColor = System.Drawing.Color.Transparent;
            this.scoreCounter.Location = new System.Drawing.Point(13, 594);
            this.scoreCounter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scoreCounter.Name = "scoreCounter";
            this.scoreCounter.Size = new System.Drawing.Size(94, 31);
            this.scoreCounter.TabIndex = 21;
            this.scoreCounter.Text = "Score: 0";
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.White;
            this.resetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.resetButton.Location = new System.Drawing.Point(647, 588);
            this.resetButton.Margin = new System.Windows.Forms.Padding(4);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(97, 37);
            this.resetButton.TabIndex = 22;
            this.resetButton.Text = "Restart";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // floor
            // 
            this.floor.Enabled = false;
            this.floor.Image = ((System.Drawing.Image)(resources.GetObject("floor.Image")));
            this.floor.Location = new System.Drawing.Point(-38, 556);
            this.floor.Margin = new System.Windows.Forms.Padding(4);
            this.floor.Name = "floor";
            this.floor.Size = new System.Drawing.Size(940, 97);
            this.floor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.floor.TabIndex = 23;
            this.floor.TabStop = false;
            // 
            // tubeUp
            // 
            this.tubeUp.BackColor = System.Drawing.Color.Transparent;
            this.tubeUp.Image = ((System.Drawing.Image)(resources.GetObject("tubeUp.Image")));
            this.tubeUp.Location = new System.Drawing.Point(565, -107);
            this.tubeUp.Margin = new System.Windows.Forms.Padding(4);
            this.tubeUp.Name = "tubeUp";
            this.tubeUp.Size = new System.Drawing.Size(109, 314);
            this.tubeUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tubeUp.TabIndex = 18;
            this.tubeUp.TabStop = false;
         
            // 
            // tubeDown
            // 
            this.tubeDown.BackColor = System.Drawing.Color.Transparent;
            this.tubeDown.Image = ((System.Drawing.Image)(resources.GetObject("tubeDown.Image")));
            this.tubeDown.Location = new System.Drawing.Point(482, 402);
            this.tubeDown.Margin = new System.Windows.Forms.Padding(4);
            this.tubeDown.Name = "tubeDown";
            this.tubeDown.Size = new System.Drawing.Size(115, 251);
            this.tubeDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tubeDown.TabIndex = 19;
            this.tubeDown.TabStop = false;
            // 
            // clouds
            // 
            this.clouds.Image = ((System.Drawing.Image)(resources.GetObject("clouds.Image")));
            this.clouds.Location = new System.Drawing.Point(158, 365);
            this.clouds.Margin = new System.Windows.Forms.Padding(4);
            this.clouds.Name = "clouds";
            this.clouds.Size = new System.Drawing.Size(257, 153);
            this.clouds.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.clouds.TabIndex = 25;
            this.clouds.TabStop = false;
            // 
            // clouds3
            // 
            this.clouds3.Image = ((System.Drawing.Image)(resources.GetObject("clouds3.Image")));
            this.clouds3.Location = new System.Drawing.Point(518, 69);
            this.clouds3.Margin = new System.Windows.Forms.Padding(4);
            this.clouds3.Name = "clouds3";
            this.clouds3.Size = new System.Drawing.Size(252, 138);
            this.clouds3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.clouds3.TabIndex = 26;
            this.clouds3.TabStop = false;
            // 
            // clouds2
            // 
            this.clouds2.Image = ((System.Drawing.Image)(resources.GetObject("clouds2.Image")));
            this.clouds2.Location = new System.Drawing.Point(158, 46);
            this.clouds2.Margin = new System.Windows.Forms.Padding(4);
            this.clouds2.Name = "clouds2";
            this.clouds2.Size = new System.Drawing.Size(228, 137);
            this.clouds2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.clouds2.TabIndex = 27;
            this.clouds2.TabStop = false;
            // 
            // flappyDragonGameTimer
            // 
            this.flappyDragonGameTimer.Enabled = true;
            this.flappyDragonGameTimer.Interval = 20;
            this.flappyDragonGameTimer.Tick += new System.EventHandler(this.flappyDragonGameTimer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(583, 336);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(433, 195);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 48);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 28;
            this.pictureBox5.TabStop = false;
            // 
            // FlappyDragonGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(750, 636);
            this.Controls.Add(this.tubeUp);
            this.Controls.Add(this.highScoreCounter);
            this.Controls.Add(this.soundButton);
            this.Controls.Add(this.gameOverMessage);
            this.Controls.Add(this.howToPlay);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.dragon);
            this.Controls.Add(this.scoreCounter);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.floor);
            this.Controls.Add(this.tubeDown);
            this.Controls.Add(this.clouds);
            this.Controls.Add(this.clouds3);
            this.Controls.Add(this.clouds2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FlappyDragonGame";
            this.Text = "FlappyDragonGame";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FlappyDragonGame_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FlappyDragonGame_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dragon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tubeUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tubeDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clouds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clouds3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clouds2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label highScoreCounter;
        private System.Windows.Forms.CheckBox soundButton;
        private System.Windows.Forms.Label gameOverMessage;
        private System.Windows.Forms.Label howToPlay;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.PictureBox dragon;
        private System.Windows.Forms.Label scoreCounter;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.PictureBox floor;
        private System.Windows.Forms.PictureBox tubeUp;
        private System.Windows.Forms.PictureBox tubeDown;
        private System.Windows.Forms.PictureBox clouds;
        private System.Windows.Forms.PictureBox clouds3;
        private System.Windows.Forms.PictureBox clouds2;
        private System.Windows.Forms.Timer flappyDragonGameTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}