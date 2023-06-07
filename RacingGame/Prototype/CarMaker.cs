using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingGame.Prototype
{
     public class CarMaker
     {
          public static EnemyCar CreateEnemyCar(int speed, PictureBox enemy1,PictureBox enemy2)
          {
               EnemyCar enemyCar = new EnemyCar(enemy1,enemy2);

               enemyCar.Speed = speed;
               //enemyCar.Position = position;

               return enemyCar;
          }

          public static EnemySpeedCar CreateEnemySpeedCar(int speed, PictureBox fastEnemy )
          {
               EnemySpeedCar enemySpeedCar = new EnemySpeedCar(fastEnemy);

               enemySpeedCar.Speed = speed;
               //enemySpeedCar.Position = position;

               return enemySpeedCar;
          }

     }
}
