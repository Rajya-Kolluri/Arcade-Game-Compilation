
namespace MainMenuForm
{
    partial class SpaceShooterGame
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
            this.SpaceGameTimer = new System.Windows.Forms.Timer(this.components);
            this.Title = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Label();
            this.Background = new System.Windows.Forms.PictureBox();
            this.scoreCounter = new System.Windows.Forms.Label();
            this.highScoreCounter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).BeginInit();
            this.SuspendLayout();
            // 
            // SpaceGameTimer
            // 
            this.SpaceGameTimer.Interval = 10;
            this.SpaceGameTimer.Tick += new System.EventHandler(this.SpaceGameTimer_Tick);
            // 
            // Title
            // 
            this.Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Bauhaus 93", 100F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Title.Location = new System.Drawing.Point(649, 841);
            this.Title.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(941, 189);
            this.Title.TabIndex = 8;
            this.Title.Text = "GAME OVER";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSize = true;
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ExitButton.Font = new System.Drawing.Font("Bauhaus 93", 49.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.DarkRed;
            this.ExitButton.Location = new System.Drawing.Point(0, 1081);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(196, 94);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.Text = "EXIT";
            this.ExitButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetButton.AutoSize = true;
            this.ResetButton.Font = new System.Drawing.Font("Bauhaus 93", 49.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.ForeColor = System.Drawing.Color.DarkRed;
            this.ResetButton.Location = new System.Drawing.Point(1450, 1016);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(356, 94);
            this.ResetButton.TabIndex = 10;
            this.ResetButton.Text = "RESTART";
            this.ResetButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // Background
            // 
            this.Background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Background.Location = new System.Drawing.Point(0, 0);
            this.Background.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(1837, 1175);
            this.Background.TabIndex = 0;
            this.Background.TabStop = false;
            // 
            // scoreCounter
            // 
            this.scoreCounter.AutoSize = true;
            this.scoreCounter.BackColor = System.Drawing.Color.Transparent;
            this.scoreCounter.Dock = System.Windows.Forms.DockStyle.Left;
            this.scoreCounter.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreCounter.ForeColor = System.Drawing.Color.White;
            this.scoreCounter.Location = new System.Drawing.Point(0, 0);
            this.scoreCounter.Name = "scoreCounter";
            this.scoreCounter.Size = new System.Drawing.Size(195, 48);
            this.scoreCounter.TabIndex = 11;
            this.scoreCounter.Text = "SCORE: 0";
            // 
            // highScoreCounter
            // 
            this.highScoreCounter.AutoSize = true;
            this.highScoreCounter.BackColor = System.Drawing.Color.Transparent;
            this.highScoreCounter.Dock = System.Windows.Forms.DockStyle.Right;
            this.highScoreCounter.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScoreCounter.ForeColor = System.Drawing.Color.White;
            this.highScoreCounter.Location = new System.Drawing.Point(1534, 0);
            this.highScoreCounter.Name = "highScoreCounter";
            this.highScoreCounter.Size = new System.Drawing.Size(303, 48);
            this.highScoreCounter.TabIndex = 12;
            this.highScoreCounter.Text = "HIGH SCORE: 0";
            // 
            // SpaceShooterGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1837, 1175);
            this.Controls.Add(this.highScoreCounter);
            this.Controls.Add(this.scoreCounter);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Background);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "SpaceShooterGame";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "SpaceShooterGame";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SpaceShooterGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SpaceShooterGame_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SpaceShooterGame_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Background;
        private System.Windows.Forms.Timer SpaceGameTimer;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label ExitButton;
        private System.Windows.Forms.Label ResetButton;
        private System.Windows.Forms.Label scoreCounter;
        private System.Windows.Forms.Label highScoreCounter;
    }
}