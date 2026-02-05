namespace WindowsFormsApp5
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.Play = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panelLoser = new System.Windows.Forms.Panel();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.retry = new System.Windows.Forms.Button();
            this.panelWinner = new System.Windows.Forms.Panel();
            this.PlayAgain = new System.Windows.Forms.Button();
            this.YouWin = new System.Windows.Forms.Label();
            this.panelGame = new System.Windows.Forms.Panel();
            this.Player2Rock = new System.Windows.Forms.PictureBox();
            this.Player2Rotate = new System.Windows.Forms.PictureBox();
            this.Player2Paper = new System.Windows.Forms.PictureBox();
            this.Player2Scissors = new System.Windows.Forms.PictureBox();
            this.Player1Rock = new System.Windows.Forms.PictureBox();
            this.Player1Rotate = new System.Windows.Forms.PictureBox();
            this.Player1Scissors = new System.Windows.Forms.PictureBox();
            this.Player1Paper = new System.Windows.Forms.PictureBox();
            this.Scissors = new System.Windows.Forms.Button();
            this.Paper = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Rock = new System.Windows.Forms.Button();
            this.Player2 = new System.Windows.Forms.Label();
            this.Player1 = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.WinnerIs = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Player1Hand = new System.Windows.Forms.PictureBox();
            this.Player2Hand = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.panelLoser.SuspendLayout();
            this.panelWinner.SuspendLayout();
            this.panelGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player2Rock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2Rotate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2Paper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2Scissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1Rock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1Rotate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1Scissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1Paper)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player1Hand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2Hand)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelMenu.Controls.Add(this.Play);
            this.panelMenu.Controls.Add(this.axWindowsMediaPlayer1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(2160, 981);
            this.panelMenu.TabIndex = 0;
            // 
            // Play
            // 
            this.Play.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Play.BackColor = System.Drawing.Color.DarkOrange;
            this.Play.FlatAppearance.BorderColor = System.Drawing.Color.PapayaWhip;
            this.Play.FlatAppearance.BorderSize = 3;
            this.Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Play.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Play.ForeColor = System.Drawing.Color.PapayaWhip;
            this.Play.Location = new System.Drawing.Point(911, 417);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(338, 146);
            this.Play.TabIndex = 24;
            this.Play.Text = "PLAY";
            this.Play.UseVisualStyleBackColor = false;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(1279, 249);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(142, 128);
            this.axWindowsMediaPlayer1.TabIndex = 23;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // panelLoser
            // 
            this.panelLoser.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelLoser.Controls.Add(this.lblGameOver);
            this.panelLoser.Controls.Add(this.retry);
            this.panelLoser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLoser.ForeColor = System.Drawing.Color.Red;
            this.panelLoser.Location = new System.Drawing.Point(0, 0);
            this.panelLoser.Name = "panelLoser";
            this.panelLoser.Size = new System.Drawing.Size(2160, 981);
            this.panelLoser.TabIndex = 21;
            // 
            // lblGameOver
            // 
            this.lblGameOver.Font = new System.Drawing.Font("Showcard Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.Location = new System.Drawing.Point(549, 84);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(658, 464);
            this.lblGameOver.TabIndex = 5;
            this.lblGameOver.Text = "GAME \r\nOVER";
            // 
            // retry
            // 
            this.retry.BackColor = System.Drawing.Color.DarkOrange;
            this.retry.Font = new System.Drawing.Font("Rockwell", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retry.ForeColor = System.Drawing.Color.PapayaWhip;
            this.retry.Location = new System.Drawing.Point(558, 585);
            this.retry.Name = "retry";
            this.retry.Size = new System.Drawing.Size(392, 95);
            this.retry.TabIndex = 4;
            this.retry.Text = "RETRY";
            this.retry.UseVisualStyleBackColor = false;
            this.retry.Click += new System.EventHandler(this.retry_Click);
            // 
            // panelWinner
            // 
            this.panelWinner.BackColor = System.Drawing.Color.Black;
            this.panelWinner.Controls.Add(this.PlayAgain);
            this.panelWinner.Controls.Add(this.YouWin);
            this.panelWinner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWinner.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panelWinner.Location = new System.Drawing.Point(0, 0);
            this.panelWinner.Name = "panelWinner";
            this.panelWinner.Size = new System.Drawing.Size(2160, 981);
            this.panelWinner.TabIndex = 1;
            // 
            // PlayAgain
            // 
            this.PlayAgain.BackColor = System.Drawing.Color.DarkOrange;
            this.PlayAgain.Font = new System.Drawing.Font("Rockwell", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayAgain.ForeColor = System.Drawing.Color.PapayaWhip;
            this.PlayAgain.Location = new System.Drawing.Point(589, 635);
            this.PlayAgain.Name = "PlayAgain";
            this.PlayAgain.Size = new System.Drawing.Size(392, 95);
            this.PlayAgain.TabIndex = 3;
            this.PlayAgain.Text = "PLAY AGAIN";
            this.PlayAgain.UseVisualStyleBackColor = false;
            this.PlayAgain.Click += new System.EventHandler(this.PlayAgain_Click);
            // 
            // YouWin
            // 
            this.YouWin.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YouWin.Location = new System.Drawing.Point(589, 77);
            this.YouWin.Name = "YouWin";
            this.YouWin.Size = new System.Drawing.Size(466, 413);
            this.YouWin.TabIndex = 1;
            this.YouWin.Text = "YOU \r\nWİN!";
            // 
            // panelGame
            // 
            this.panelGame.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelGame.Controls.Add(this.panel1);
            this.panelGame.Controls.Add(this.Scissors);
            this.panelGame.Controls.Add(this.Paper);
            this.panelGame.Controls.Add(this.Back);
            this.panelGame.Controls.Add(this.Rock);
            this.panelGame.Controls.Add(this.Player2);
            this.panelGame.Controls.Add(this.Player1);
            this.panelGame.Controls.Add(this.Score);
            this.panelGame.Controls.Add(this.label2);
            this.panelGame.Controls.Add(this.label1);
            this.panelGame.Controls.Add(this.WinnerIs);
            this.panelGame.Controls.Add(this.panel2);
            this.panelGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGame.Location = new System.Drawing.Point(0, 0);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(2160, 981);
            this.panelGame.TabIndex = 24;
            // 
            // Player2Rock
            // 
            this.Player2Rock.Image = ((System.Drawing.Image)(resources.GetObject("Player2Rock.Image")));
            this.Player2Rock.Location = new System.Drawing.Point(89, 3);
            this.Player2Rock.Name = "Player2Rock";
            this.Player2Rock.Size = new System.Drawing.Size(505, 376);
            this.Player2Rock.TabIndex = 29;
            this.Player2Rock.TabStop = false;
            // 
            // Player2Rotate
            // 
            this.Player2Rotate.Image = ((System.Drawing.Image)(resources.GetObject("Player2Rotate.Image")));
            this.Player2Rotate.Location = new System.Drawing.Point(77, 4);
            this.Player2Rotate.Name = "Player2Rotate";
            this.Player2Rotate.Size = new System.Drawing.Size(510, 375);
            this.Player2Rotate.TabIndex = 33;
            this.Player2Rotate.TabStop = false;
            // 
            // Player2Paper
            // 
            this.Player2Paper.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Player2Paper.BackColor = System.Drawing.Color.Transparent;
            this.Player2Paper.Image = ((System.Drawing.Image)(resources.GetObject("Player2Paper.Image")));
            this.Player2Paper.Location = new System.Drawing.Point(95, 0);
            this.Player2Paper.Name = "Player2Paper";
            this.Player2Paper.Size = new System.Drawing.Size(492, 379);
            this.Player2Paper.TabIndex = 34;
            this.Player2Paper.TabStop = false;
            // 
            // Player2Scissors
            // 
            this.Player2Scissors.Image = ((System.Drawing.Image)(resources.GetObject("Player2Scissors.Image")));
            this.Player2Scissors.Location = new System.Drawing.Point(89, 0);
            this.Player2Scissors.Name = "Player2Scissors";
            this.Player2Scissors.Size = new System.Drawing.Size(505, 379);
            this.Player2Scissors.TabIndex = 31;
            this.Player2Scissors.TabStop = false;
            // 
            // Player1Rock
            // 
            this.Player1Rock.Image = ((System.Drawing.Image)(resources.GetObject("Player1Rock.Image")));
            this.Player1Rock.Location = new System.Drawing.Point(0, 3);
            this.Player1Rock.Name = "Player1Rock";
            this.Player1Rock.Size = new System.Drawing.Size(463, 353);
            this.Player1Rock.TabIndex = 43;
            this.Player1Rock.TabStop = false;
            // 
            // Player1Rotate
            // 
            this.Player1Rotate.Image = ((System.Drawing.Image)(resources.GetObject("Player1Rotate.Image")));
            this.Player1Rotate.Location = new System.Drawing.Point(-3, 0);
            this.Player1Rotate.Name = "Player1Rotate";
            this.Player1Rotate.Size = new System.Drawing.Size(463, 353);
            this.Player1Rotate.TabIndex = 42;
            this.Player1Rotate.TabStop = false;
            // 
            // Player1Scissors
            // 
            this.Player1Scissors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Player1Scissors.BackColor = System.Drawing.Color.Transparent;
            this.Player1Scissors.Image = ((System.Drawing.Image)(resources.GetObject("Player1Scissors.Image")));
            this.Player1Scissors.Location = new System.Drawing.Point(3, 0);
            this.Player1Scissors.Name = "Player1Scissors";
            this.Player1Scissors.Size = new System.Drawing.Size(457, 353);
            this.Player1Scissors.TabIndex = 41;
            this.Player1Scissors.TabStop = false;
            // 
            // Player1Paper
            // 
            this.Player1Paper.Image = ((System.Drawing.Image)(resources.GetObject("Player1Paper.Image")));
            this.Player1Paper.Location = new System.Drawing.Point(0, 0);
            this.Player1Paper.Name = "Player1Paper";
            this.Player1Paper.Size = new System.Drawing.Size(460, 353);
            this.Player1Paper.TabIndex = 40;
            this.Player1Paper.TabStop = false;
            // 
            // Scissors
            // 
            this.Scissors.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Scissors.FlatAppearance.BorderSize = 0;
            this.Scissors.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Scissors.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scissors.Image = ((System.Drawing.Image)(resources.GetObject("Scissors.Image")));
            this.Scissors.Location = new System.Drawing.Point(917, 635);
            this.Scissors.Name = "Scissors";
            this.Scissors.Size = new System.Drawing.Size(268, 243);
            this.Scissors.TabIndex = 38;
            this.Scissors.Text = "SCISSORS";
            this.Scissors.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Scissors.UseVisualStyleBackColor = false;
            this.Scissors.Click += new System.EventHandler(this.Scissors_Click);
            // 
            // Paper
            // 
            this.Paper.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Paper.FlatAppearance.BorderSize = 0;
            this.Paper.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Paper.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold);
            this.Paper.Image = ((System.Drawing.Image)(resources.GetObject("Paper.Image")));
            this.Paper.Location = new System.Drawing.Point(599, 635);
            this.Paper.Name = "Paper";
            this.Paper.Size = new System.Drawing.Size(265, 243);
            this.Paper.TabIndex = 36;
            this.Paper.Text = "PAPER";
            this.Paper.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Paper.UseVisualStyleBackColor = false;
            this.Paper.Click += new System.EventHandler(this.Paper_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.DarkOrange;
            this.Back.FlatAppearance.BorderColor = System.Drawing.Color.PapayaWhip;
            this.Back.FlatAppearance.BorderSize = 3;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("Rockwell", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.PapayaWhip;
            this.Back.Location = new System.Drawing.Point(48, 30);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(137, 70);
            this.Back.TabIndex = 24;
            this.Back.Text = "BACK";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click_1);
            // 
            // Rock
            // 
            this.Rock.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Rock.FlatAppearance.BorderColor = System.Drawing.Color.Linen;
            this.Rock.FlatAppearance.BorderSize = 10;
            this.Rock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Rock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Rock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Rock.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold);
            this.Rock.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Rock.Image = ((System.Drawing.Image)(resources.GetObject("Rock.Image")));
            this.Rock.Location = new System.Drawing.Point(274, 635);
            this.Rock.Margin = new System.Windows.Forms.Padding(0);
            this.Rock.Name = "Rock";
            this.Rock.Size = new System.Drawing.Size(265, 243);
            this.Rock.TabIndex = 21;
            this.Rock.Text = "ROCK";
            this.Rock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Rock.UseVisualStyleBackColor = false;
            this.Rock.Click += new System.EventHandler(this.Rock_Click);
            // 
            // Player2
            // 
            this.Player2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2.Location = new System.Drawing.Point(848, 84);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(87, 84);
            this.Player2.TabIndex = 20;
            // 
            // Player1
            // 
            this.Player1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1.Location = new System.Drawing.Point(622, 77);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(88, 84);
            this.Player1.TabIndex = 19;
            // 
            // Score
            // 
            this.Score.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(680, 0);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(230, 84);
            this.Score.TabIndex = 10;
            this.Score.Text = "SCORE\r\n";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(1145, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(403, 90);
            this.label2.TabIndex = 8;
            this.label2.Text = "PLAYER2";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(93, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 134);
            this.label1.TabIndex = 7;
            this.label1.Text = "PLAYER1";
            // 
            // WinnerIs
            // 
            this.WinnerIs.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F);
            this.WinnerIs.Location = new System.Drawing.Point(619, 278);
            this.WinnerIs.Name = "WinnerIs";
            this.WinnerIs.Size = new System.Drawing.Size(331, 114);
            this.WinnerIs.TabIndex = 9;
            // 
            // Timer1
            // 
            this.Timer1.Interval = 500;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Player1Paper);
            this.panel1.Controls.Add(this.Player1Rotate);
            this.panel1.Controls.Add(this.Player1Rock);
            this.panel1.Controls.Add(this.Player1Scissors);
            this.panel1.Controls.Add(this.Player1Hand);
            this.panel1.Location = new System.Drawing.Point(3, 192);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 437);
            this.panel1.TabIndex = 44;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Player2Rotate);
            this.panel2.Controls.Add(this.Player2Rock);
            this.panel2.Controls.Add(this.Player2Paper);
            this.panel2.Controls.Add(this.Player2Scissors);
            this.panel2.Controls.Add(this.Player2Hand);
            this.panel2.Location = new System.Drawing.Point(978, 202);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(587, 427);
            this.panel2.TabIndex = 45;
            // 
            // Player1Hand
            // 
            this.Player1Hand.Image = ((System.Drawing.Image)(resources.GetObject("Player1Hand.Image")));
            this.Player1Hand.Location = new System.Drawing.Point(3, 0);
            this.Player1Hand.Name = "Player1Hand";
            this.Player1Hand.Size = new System.Drawing.Size(457, 353);
            this.Player1Hand.TabIndex = 46;
            this.Player1Hand.TabStop = false;
            // 
            // Player2Hand
            // 
            this.Player2Hand.Image = ((System.Drawing.Image)(resources.GetObject("Player2Hand.Image")));
            this.Player2Hand.Location = new System.Drawing.Point(77, 0);
            this.Player2Hand.Name = "Player2Hand";
            this.Player2Hand.Size = new System.Drawing.Size(507, 379);
            this.Player2Hand.TabIndex = 46;
            this.Player2Hand.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(2160, 981);
            this.Controls.Add(this.panelGame);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelWinner);
            this.Controls.Add(this.panelLoser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.panelLoser.ResumeLayout(false);
            this.panelWinner.ResumeLayout(false);
            this.panelGame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Player2Rock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2Rotate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2Paper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2Scissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1Rock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1Rotate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1Scissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1Paper)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Player1Hand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2Hand)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLoser;
        private System.Windows.Forms.Panel panelWinner;
        private System.Windows.Forms.Label YouWin;
        private System.Windows.Forms.Button retry;
        private System.Windows.Forms.Button PlayAgain;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Panel panelGame;
        private System.Windows.Forms.Label Player2;
        private System.Windows.Forms.Label Player1;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label WinnerIs;
        private System.Windows.Forms.Button Rock;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.PictureBox Player2Scissors;
        private System.Windows.Forms.PictureBox Player2Rock;
        private System.Windows.Forms.PictureBox Player2Rotate;
        private System.Windows.Forms.PictureBox Player2Paper;
        private System.Windows.Forms.Button Paper;
        private System.Windows.Forms.Button Scissors;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.PictureBox Player1Rock;
        private System.Windows.Forms.PictureBox Player1Rotate;
        private System.Windows.Forms.PictureBox Player1Scissors;
        private System.Windows.Forms.PictureBox Player1Paper;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox Player1Hand;
        private System.Windows.Forms.PictureBox Player2Hand;
    }
}

