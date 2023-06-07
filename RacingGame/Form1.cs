
using RacingGame.Background;
using RacingGame.Command;
using RacingGame.Decorator;
using RacingGame.Models;
using RacingGame.Prototype;
using RacingGame.Proxy;

namespace RacingGame
{
     public partial class Form1 : Form
     {

          private int levelSpeed;
          private int enemySpeed;
          private int _countCoins;
          //private bool isButtonClicked = false;
          private bool _lose;
          private bool _receiveCoin = false;
          Random random = new Random();
          Record record = new Record();
          Player player;
          IStartGame startGame = new StartGame();




          public Form1()
          {
               Way.GetInstance();
               InitializeComponent();
               HideLevelButton();
               KeyPreview = true;
               WelcomeLabel.Visible = false;
               allCoins.Visible = false;
               authSucces.Visible = false;


          }

          private void pictureBox1_Click(object sender, EventArgs e)
          {

          }

          private void WelcomeLabel_Click(object sender, EventArgs e)
          {
               mainMenuBtn.Visible = false;
               StartGameButton.Visible = true;


          }

          private void StartGameButton_Click(object sender, EventArgs e)
          {
               
               
               IStartGame startGameProxy = new StartGameProxy(startGame, username.Text, password.Text);
               authSucces.Visible = true;
               authSucces.Text =  startGameProxy.GameStart();
               if (authSucces.Text == "Access denied. Only Admin have access")
               {
               }
               else
               {

                    auth.Visible = false;
                    RegisterButton.Visible = true;
                    registerName.Visible = true;
                    registerName_TextChanged(sender, e);
                    StartGameButton.Visible = false;
                    username.Visible = false;
                    password.Visible = false;
                    playersRecords.Visible= false;
                    showScore.Visible = false;
               }


          }

          private void LevelGame(object sender, EventArgs e)
          {
               WelcomeLabel.Visible = false;
               StartGameButton.Visible = false;
               allCoins.Visible = true;
               ShowLevelButton();
          }

          private void EasyButton_Click(object sender, EventArgs e)
          {
               levelSpeed = Way.GetInstance().GetSpeed(1);
               //isButtonClicked = true;
               HideLevelButton();

          }

          private void MediumButton_Click(object sender, EventArgs e)
          {
               levelSpeed = Way.GetInstance().GetSpeed(2);
               //isButtonClicked = true;
               HideLevelButton();
          }

          private void HardButton_Click(object sender, EventArgs e)
          {
               levelSpeed = Way.GetInstance().GetSpeed(3);
               //isButtonClicked = true;
               HideLevelButton();
          }

          private void TimerBackground_Tick(object sender, EventArgs e)
          {
               SelectLevel();
               CarEnemySpeedPosition();

               if (car.Bounds.IntersectsWith(enemyCar1.Bounds) ||
                    car.Bounds.IntersectsWith(enemyCar2.Bounds) ||
                    car.Bounds.IntersectsWith(fastEnemyCar.Bounds))
               {
                    _lose = true;
                    StartGameButton.Visible = false;
                    TimerBackground.Enabled = false;
                    loseLabel.Visible = true;
                    restartBtn.Visible = true;
                    mainMenuBtn.Visible = true;
               }

               if (car.Bounds.IntersectsWith(coin.Bounds))
               {
                    IntersectWithCoin();

               }
          }

          private void IntersectWithCoin()
          {
               _countCoins++;
               allCoins.Text = "Coins: " + _countCoins.ToString();
               _receiveCoin = true;
               SelectLevel();
          }

          public void Form1_KeyDown(object sender, KeyEventArgs e)
          {
               if (_lose) return;
               CarCommands(e);

          }

          private void CarCommands(KeyEventArgs e)
          {
               CarPrimary carPrimary = new CarPrimary(this, levelSpeed);
               Command.Command left = new LeftCommand(carPrimary);
               Command.Command right = new RightCommand(carPrimary);

               CarUniversal carUniversal = new CarUniversal(left, right);

               carUniversal.Right(e);
               carUniversal.Left(e);
          }

          private async void CarEnemySpeedPosition()
          {
               int fast = Way.GetInstance().GetEnemySpeed(3);
               int leftFastRide = random.Next(10, 201);
               int rightFastRide = random.Next(290, 480);
               int leftRide = random.Next(10, 201);
               int rightRide = random.Next(290, 480);

               if (_countCoins > 6)
               {
                    if (leftRide != leftFastRide && rightRide != rightFastRide)
                    {
                         EnemySpeedCar enemyCarFast = CarMaker.CreateEnemySpeedCar(fast, fastEnemyCar);
                         enemyCarFast.Enemy(leftFastRide, rightFastRide);
                    }
                    EnemyCar enemyCar = CarMaker.CreateEnemyCar(levelSpeed, enemyCar1, enemyCar2);
                    enemyCar.Enemy(leftRide, rightRide);

               }
               else
               {

                    EnemyCar enemyCar = CarMaker.CreateEnemyCar(levelSpeed, enemyCar1, enemyCar2);
                    enemyCar.Enemy(leftRide, rightRide);
               }



          }
          private void SelectLevel()
          {
               MainWay mainWay = new MainWay(bg1, bg2, _countCoins);
               CoinWayDecorator coinWayDecorator = new CoinWayDecorator(mainWay, coin, _receiveCoin);
               Level2WayDecorator level2WayDecorator = new Level2WayDecorator(mainWay, secondLevelWay, secondLevelWay2);
               if (_receiveCoin == true)
               {
                    coinWayDecorator.GetLevel(levelSpeed);
                    _receiveCoin = false;
               }
               coinWayDecorator.GetLevel(levelSpeed);
               mainWay.GetLevel(levelSpeed);

               if (_countCoins > 3)
               {
                    showLevel2.Visible = true;
                    level2WayDecorator.GetLevel(levelSpeed);
               }


          }


          private void HideLevelButton()
          {
               EasyButton.Visible = false;
               MediumButton.Visible = false;
               HardButton.Visible = false;
               loseLabel.Visible = false;
               restartBtn.Visible = false;
               mainMenuBtn.Visible = false;
               showLevel2.Visible = false;
               RegisterButton.Visible = false;
               registerName.Visible = false;
               showScore.Visible = false;
               playersRecords.Visible = false;


          }
          private void ShowLevelButton()
          {
               EasyButton.Visible = true;
               MediumButton.Visible = true;
               HardButton.Visible = true;
               fastEnemyCar.Top = -560;

          }

          private void restartBtn_Click(object sender, EventArgs e)
          {
               enemyCar1.Top = -130;
               enemyCar2.Top = -400;
               fastEnemyCar.Top = -560;
               loseLabel.Visible = false;
               restartBtn.Visible = false;
               mainMenuBtn.Visible = false;
               TimerBackground.Enabled = true;
               _lose = false;
               _countCoins = -1;
               showLevel2.Visible = false;
               IntersectWithCoin();
          }

          private void mainMenuBtn_Click(object sender, EventArgs e)
          {
               enemyCar1.Top = -130;
               enemyCar2.Top = -400;
               loseLabel.Visible = false;
               restartBtn.Visible = false;
               _lose = false;
               showScore.Visible = true;
               //mainMenuBtn.Enabled = false;
               WelcomeLabel_Click(sender, e);
          }

          private void RegisterButton_Click(object sender, EventArgs e)
          {
               authSucces.Visible = false;   
               player = new Player(registerName.Text, playersRecords);
               record.RegisterPlayer(player);
               HideLevelButton();
               LevelGame(sender, e);
               TimerBackground.Enabled = true;

          }

          private void registerName_TextChanged(object sender, EventArgs e)
          {

          }

          private void showScore_Click(object sender, EventArgs e)
          {

               StartGameButton.Visible = true;
               showScore.Visible = false;
               playersRecords.Visible = true;

               player.Update(player, _countCoins, record);

               _countCoins = 0;

          }
     }
}