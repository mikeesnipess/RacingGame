namespace RacingGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
               this.components = new System.ComponentModel.Container();
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
               this.bg1 = new System.Windows.Forms.PictureBox();
               this.car = new System.Windows.Forms.PictureBox();
               this.WelcomeLabel = new System.Windows.Forms.Label();
               this.StartGameButton = new System.Windows.Forms.Button();
               this.TimerBackground = new System.Windows.Forms.Timer(this.components);
               this.EasyButton = new System.Windows.Forms.Button();
               this.MediumButton = new System.Windows.Forms.Button();
               this.HardButton = new System.Windows.Forms.Button();
               this.bg2 = new System.Windows.Forms.PictureBox();
               this.enemyCar1 = new System.Windows.Forms.PictureBox();
               this.enemyCar2 = new System.Windows.Forms.PictureBox();
               this.secondLevelWay = new System.Windows.Forms.PictureBox();
               this.fastEnemyCar = new System.Windows.Forms.PictureBox();
               this.loseLabel = new System.Windows.Forms.Label();
               this.restartBtn = new System.Windows.Forms.Button();
               this.mainMenuBtn = new System.Windows.Forms.Button();
               this.coin = new System.Windows.Forms.PictureBox();
               this.allCoins = new System.Windows.Forms.Button();
               this.secondLevelWay2 = new System.Windows.Forms.PictureBox();
               this.showLevel2 = new System.Windows.Forms.Label();
               this.RegisterButton = new System.Windows.Forms.Button();
               this.registerName = new System.Windows.Forms.TextBox();
               this.showScore = new System.Windows.Forms.Button();
               this.playersRecords = new System.Windows.Forms.Button();
               this.username = new System.Windows.Forms.TextBox();
               this.password = new System.Windows.Forms.TextBox();
               this.auth = new System.Windows.Forms.Label();
               this.authSucces = new System.Windows.Forms.Button();
               ((System.ComponentModel.ISupportInitialize)(this.bg1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.car)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.bg2)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.enemyCar1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.enemyCar2)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.secondLevelWay)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.fastEnemyCar)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.coin)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.secondLevelWay2)).BeginInit();
               this.SuspendLayout();
               // 
               // bg1
               // 
               this.bg1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bg1.BackgroundImage")));
               this.bg1.Location = new System.Drawing.Point(0, 0);
               this.bg1.Name = "bg1";
               this.bg1.Size = new System.Drawing.Size(560, 560);
               this.bg1.TabIndex = 0;
               this.bg1.TabStop = false;
               this.bg1.Click += new System.EventHandler(this.pictureBox1_Click);
               // 
               // car
               // 
               this.car.BackColor = System.Drawing.Color.Transparent;
               this.car.Image = ((System.Drawing.Image)(resources.GetObject("car.Image")));
               this.car.Location = new System.Drawing.Point(244, 398);
               this.car.Name = "car";
               this.car.Size = new System.Drawing.Size(71, 130);
               this.car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.car.TabIndex = 0;
               this.car.TabStop = false;
               // 
               // WelcomeLabel
               // 
               this.WelcomeLabel.AutoSize = true;
               this.WelcomeLabel.BackColor = System.Drawing.Color.SeaGreen;
               this.WelcomeLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               this.WelcomeLabel.Location = new System.Drawing.Point(48, 100);
               this.WelcomeLabel.Name = "WelcomeLabel";
               this.WelcomeLabel.Size = new System.Drawing.Size(478, 53);
               this.WelcomeLabel.TabIndex = 1;
               this.WelcomeLabel.Text = "Welcome to Racing Game";
               this.WelcomeLabel.Click += new System.EventHandler(this.WelcomeLabel_Click);
               // 
               // StartGameButton
               // 
               this.StartGameButton.BackColor = System.Drawing.SystemColors.Highlight;
               this.StartGameButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               this.StartGameButton.Location = new System.Drawing.Point(186, 211);
               this.StartGameButton.Name = "StartGameButton";
               this.StartGameButton.Size = new System.Drawing.Size(182, 52);
               this.StartGameButton.TabIndex = 2;
               this.StartGameButton.Text = "Start Game";
               this.StartGameButton.UseVisualStyleBackColor = false;
               this.StartGameButton.Click += new System.EventHandler(this.StartGameButton_Click);
               // 
               // TimerBackground
               // 
               this.TimerBackground.Enabled = true;
               this.TimerBackground.Interval = 20;
               this.TimerBackground.Tick += new System.EventHandler(this.TimerBackground_Tick);
               // 
               // EasyButton
               // 
               this.EasyButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
               this.EasyButton.Location = new System.Drawing.Point(220, 141);
               this.EasyButton.Name = "EasyButton";
               this.EasyButton.Size = new System.Drawing.Size(111, 54);
               this.EasyButton.TabIndex = 3;
               this.EasyButton.Text = "Easy";
               this.EasyButton.UseVisualStyleBackColor = false;
               this.EasyButton.Click += new System.EventHandler(this.EasyButton_Click);
               // 
               // MediumButton
               // 
               this.MediumButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
               this.MediumButton.Location = new System.Drawing.Point(220, 217);
               this.MediumButton.Name = "MediumButton";
               this.MediumButton.Size = new System.Drawing.Size(111, 54);
               this.MediumButton.TabIndex = 4;
               this.MediumButton.Text = "Medium";
               this.MediumButton.UseVisualStyleBackColor = false;
               this.MediumButton.Click += new System.EventHandler(this.MediumButton_Click);
               // 
               // HardButton
               // 
               this.HardButton.BackColor = System.Drawing.Color.SteelBlue;
               this.HardButton.Location = new System.Drawing.Point(220, 292);
               this.HardButton.Name = "HardButton";
               this.HardButton.Size = new System.Drawing.Size(111, 54);
               this.HardButton.TabIndex = 5;
               this.HardButton.Text = "Hard";
               this.HardButton.UseVisualStyleBackColor = false;
               this.HardButton.Click += new System.EventHandler(this.HardButton_Click);
               // 
               // bg2
               // 
               this.bg2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bg2.BackgroundImage")));
               this.bg2.Location = new System.Drawing.Point(0, -560);
               this.bg2.Name = "bg2";
               this.bg2.Size = new System.Drawing.Size(560, 560);
               this.bg2.TabIndex = 6;
               this.bg2.TabStop = false;
               // 
               // enemyCar1
               // 
               this.enemyCar1.BackColor = System.Drawing.Color.Transparent;
               this.enemyCar1.Image = ((System.Drawing.Image)(resources.GetObject("enemyCar1.Image")));
               this.enemyCar1.Location = new System.Drawing.Point(21, -130);
               this.enemyCar1.Name = "enemyCar1";
               this.enemyCar1.Size = new System.Drawing.Size(71, 130);
               this.enemyCar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.enemyCar1.TabIndex = 7;
               this.enemyCar1.TabStop = false;
               // 
               // enemyCar2
               // 
               this.enemyCar2.BackColor = System.Drawing.Color.Transparent;
               this.enemyCar2.Image = ((System.Drawing.Image)(resources.GetObject("enemyCar2.Image")));
               this.enemyCar2.Location = new System.Drawing.Point(455, -400);
               this.enemyCar2.Name = "enemyCar2";
               this.enemyCar2.Size = new System.Drawing.Size(71, 130);
               this.enemyCar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.enemyCar2.TabIndex = 8;
               this.enemyCar2.TabStop = false;
               // 
               // secondLevelWay
               // 
               this.secondLevelWay.Image = ((System.Drawing.Image)(resources.GetObject("secondLevelWay.Image")));
               this.secondLevelWay.Location = new System.Drawing.Point(0, 0);
               this.secondLevelWay.Name = "secondLevelWay";
               this.secondLevelWay.Size = new System.Drawing.Size(560, 560);
               this.secondLevelWay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.secondLevelWay.TabIndex = 9;
               this.secondLevelWay.TabStop = false;
               // 
               // fastEnemyCar
               // 
               this.fastEnemyCar.BackColor = System.Drawing.Color.Transparent;
               this.fastEnemyCar.Image = ((System.Drawing.Image)(resources.GetObject("fastEnemyCar.Image")));
               this.fastEnemyCar.Location = new System.Drawing.Point(244, -550);
               this.fastEnemyCar.Name = "fastEnemyCar";
               this.fastEnemyCar.Size = new System.Drawing.Size(71, 130);
               this.fastEnemyCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.fastEnemyCar.TabIndex = 10;
               this.fastEnemyCar.TabStop = false;
               // 
               // loseLabel
               // 
               this.loseLabel.AutoSize = true;
               this.loseLabel.BackColor = System.Drawing.Color.Red;
               this.loseLabel.Font = new System.Drawing.Font("SimSun-ExtB", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               this.loseLabel.ForeColor = System.Drawing.SystemColors.Menu;
               this.loseLabel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
               this.loseLabel.Location = new System.Drawing.Point(170, 151);
               this.loseLabel.Name = "loseLabel";
               this.loseLabel.Size = new System.Drawing.Size(217, 43);
               this.loseLabel.TabIndex = 11;
               this.loseLabel.Text = "You lose!";
               // 
               // restartBtn
               // 
               this.restartBtn.BackColor = System.Drawing.Color.Red;
               this.restartBtn.Font = new System.Drawing.Font("Segoe UI Emoji", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
               this.restartBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
               this.restartBtn.Location = new System.Drawing.Point(199, 217);
               this.restartBtn.Name = "restartBtn";
               this.restartBtn.Size = new System.Drawing.Size(159, 46);
               this.restartBtn.TabIndex = 12;
               this.restartBtn.Text = "RESTART";
               this.restartBtn.UseVisualStyleBackColor = false;
               this.restartBtn.Click += new System.EventHandler(this.restartBtn_Click);
               // 
               // mainMenuBtn
               // 
               this.mainMenuBtn.BackColor = System.Drawing.Color.PowderBlue;
               this.mainMenuBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               this.mainMenuBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
               this.mainMenuBtn.Location = new System.Drawing.Point(186, 477);
               this.mainMenuBtn.Name = "mainMenuBtn";
               this.mainMenuBtn.Size = new System.Drawing.Size(201, 60);
               this.mainMenuBtn.TabIndex = 13;
               this.mainMenuBtn.Text = "Main Menu";
               this.mainMenuBtn.UseVisualStyleBackColor = false;
               this.mainMenuBtn.Click += new System.EventHandler(this.mainMenuBtn_Click);
               // 
               // coin
               // 
               this.coin.BackColor = System.Drawing.Color.Transparent;
               this.coin.Image = ((System.Drawing.Image)(resources.GetObject("coin.Image")));
               this.coin.Location = new System.Drawing.Point(58, -650);
               this.coin.Name = "coin";
               this.coin.Size = new System.Drawing.Size(34, 34);
               this.coin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.coin.TabIndex = 14;
               this.coin.TabStop = false;
               // 
               // allCoins
               // 
               this.allCoins.BackColor = System.Drawing.Color.Coral;
               this.allCoins.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
               this.allCoins.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
               this.allCoins.Location = new System.Drawing.Point(26, 12);
               this.allCoins.Name = "allCoins";
               this.allCoins.Size = new System.Drawing.Size(147, 39);
               this.allCoins.TabIndex = 15;
               this.allCoins.Text = "Coins: 0";
               this.allCoins.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
               this.allCoins.UseVisualStyleBackColor = false;
               // 
               // secondLevelWay2
               // 
               this.secondLevelWay2.Image = ((System.Drawing.Image)(resources.GetObject("secondLevelWay2.Image")));
               this.secondLevelWay2.Location = new System.Drawing.Point(0, -560);
               this.secondLevelWay2.Name = "secondLevelWay2";
               this.secondLevelWay2.Size = new System.Drawing.Size(560, 560);
               this.secondLevelWay2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.secondLevelWay2.TabIndex = 16;
               this.secondLevelWay2.TabStop = false;
               // 
               // showLevel2
               // 
               this.showLevel2.AutoSize = true;
               this.showLevel2.BackColor = System.Drawing.Color.DarkCyan;
               this.showLevel2.Font = new System.Drawing.Font("SimSun-ExtB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               this.showLevel2.ForeColor = System.Drawing.SystemColors.ControlText;
               this.showLevel2.ImageAlign = System.Drawing.ContentAlignment.TopRight;
               this.showLevel2.Location = new System.Drawing.Point(220, 35);
               this.showLevel2.Name = "showLevel2";
               this.showLevel2.Size = new System.Drawing.Size(110, 28);
               this.showLevel2.TabIndex = 17;
               this.showLevel2.Text = "Level 2";
               // 
               // RegisterButton
               // 
               this.RegisterButton.BackColor = System.Drawing.SystemColors.Highlight;
               this.RegisterButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               this.RegisterButton.Location = new System.Drawing.Point(162, 244);
               this.RegisterButton.Name = "RegisterButton";
               this.RegisterButton.Size = new System.Drawing.Size(225, 52);
               this.RegisterButton.TabIndex = 18;
               this.RegisterButton.Text = "Enter Player Name";
               this.RegisterButton.UseVisualStyleBackColor = false;
               this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
               // 
               // registerName
               // 
               this.registerName.BackColor = System.Drawing.SystemColors.Info;
               this.registerName.Location = new System.Drawing.Point(186, 211);
               this.registerName.Name = "registerName";
               this.registerName.Size = new System.Drawing.Size(182, 27);
               this.registerName.TabIndex = 19;
               this.registerName.TextChanged += new System.EventHandler(this.registerName_TextChanged);
               // 
               // showScore
               // 
               this.showScore.BackColor = System.Drawing.SystemColors.Highlight;
               this.showScore.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               this.showScore.Location = new System.Drawing.Point(186, 294);
               this.showScore.Name = "showScore";
               this.showScore.Size = new System.Drawing.Size(182, 52);
               this.showScore.TabIndex = 20;
               this.showScore.Text = "Show score";
               this.showScore.UseVisualStyleBackColor = false;
               this.showScore.Click += new System.EventHandler(this.showScore_Click);
               // 
               // playersRecords
               // 
               this.playersRecords.AutoSize = true;
               this.playersRecords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
               this.playersRecords.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               this.playersRecords.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
               this.playersRecords.Location = new System.Drawing.Point(26, 277);
               this.playersRecords.Name = "playersRecords";
               this.playersRecords.Size = new System.Drawing.Size(522, 271);
               this.playersRecords.TabIndex = 21;
               this.playersRecords.Text = "Table";
               this.playersRecords.UseVisualStyleBackColor = false;
               // 
               // username
               // 
               this.username.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
               this.username.Location = new System.Drawing.Point(186, 292);
               this.username.Name = "username";
               this.username.Size = new System.Drawing.Size(182, 27);
               this.username.TabIndex = 22;
               this.username.Text = "username";
               this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
               // 
               // password
               // 
               this.password.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
               this.password.Location = new System.Drawing.Point(186, 325);
               this.password.Name = "password";
               this.password.Size = new System.Drawing.Size(182, 27);
               this.password.TabIndex = 23;
               this.password.Text = "password";
               this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
               // 
               // auth
               // 
               this.auth.AutoSize = true;
               this.auth.BackColor = System.Drawing.Color.SeaGreen;
               this.auth.Font = new System.Drawing.Font("Segoe UI Emoji", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               this.auth.Location = new System.Drawing.Point(209, 131);
               this.auth.Name = "auth";
               this.auth.Size = new System.Drawing.Size(122, 53);
               this.auth.TabIndex = 24;
               this.auth.Text = "Login";
               // 
               // authSucces
               // 
               this.authSucces.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
               this.authSucces.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
               this.authSucces.Location = new System.Drawing.Point(26, 439);
               this.authSucces.Name = "authSucces";
               this.authSucces.Size = new System.Drawing.Size(522, 52);
               this.authSucces.TabIndex = 26;
               this.authSucces.UseVisualStyleBackColor = false;
               // 
               // Form1
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
               this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
               this.ClientSize = new System.Drawing.Size(560, 560);
               this.Controls.Add(this.authSucces);
               this.Controls.Add(this.auth);
               this.Controls.Add(this.password);
               this.Controls.Add(this.username);
               this.Controls.Add(this.playersRecords);
               this.Controls.Add(this.showScore);
               this.Controls.Add(this.registerName);
               this.Controls.Add(this.RegisterButton);
               this.Controls.Add(this.StartGameButton);
               this.Controls.Add(this.showLevel2);
               this.Controls.Add(this.loseLabel);
               this.Controls.Add(this.restartBtn);
               this.Controls.Add(this.allCoins);
               this.Controls.Add(this.coin);
               this.Controls.Add(this.mainMenuBtn);
               this.Controls.Add(this.fastEnemyCar);
               this.Controls.Add(this.HardButton);
               this.Controls.Add(this.MediumButton);
               this.Controls.Add(this.WelcomeLabel);
               this.Controls.Add(this.EasyButton);
               this.Controls.Add(this.car);
               this.Controls.Add(this.enemyCar2);
               this.Controls.Add(this.enemyCar1);
               this.Controls.Add(this.bg1);
               this.Controls.Add(this.bg2);
               this.Controls.Add(this.secondLevelWay);
               this.Controls.Add(this.secondLevelWay2);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.Name = "Form1";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "Form1";
               this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
               ((System.ComponentModel.ISupportInitialize)(this.bg1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.car)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.bg2)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.enemyCar1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.enemyCar2)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.secondLevelWay)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.fastEnemyCar)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.coin)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.secondLevelWay2)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

        }

        #endregion

        public PictureBox bg1;
        public PictureBox car;
        private Label WelcomeLabel;
        private Button StartGameButton;
        private System.Windows.Forms.Timer TimerBackground;
        private Button EasyButton;
        private Button MediumButton;
        private Button HardButton;
        public PictureBox bg2;
        public PictureBox enemyCar1;
        public PictureBox enemyCar2;
        public PictureBox secondLevelWay;
        public PictureBox fastEnemyCar;
        private Label loseLabel;
        private Button restartBtn;
        private Button mainMenuBtn;
        public PictureBox coin;
        private Button allCoins;
        public PictureBox secondLevelWay2;
        private Label showLevel2;
        private Button RegisterButton;
        public TextBox registerName;
        private Button showScore;
        public Button playersRecords;
        public TextBox username;
        public TextBox password;
        private Label auth;
        private Button authSucces;
    }
}