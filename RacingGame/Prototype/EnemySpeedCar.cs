using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingGame.Prototype
{
     public class EnemySpeedCar : Car
     {
          private PictureBox _fastEnemy;

          public EnemySpeedCar(PictureBox fastEnemy)
          {
               _fastEnemy= fastEnemy;
          }

          public override Car CarClone()
          {
               EnemySpeedCar enemySpeedCar = new EnemySpeedCar(_fastEnemy);

               enemySpeedCar.Speed = this.Speed;
               //enemySpeedCar.Position= this.Position;

               return enemySpeedCar;


          }

          public override void Enemy(int position,int position2)
          {
               _fastEnemy.Top += this.Speed;

               if (_fastEnemy.Top >= 560)
               {
                    _fastEnemy.Top = -170;
                    _fastEnemy.Left = position;
               }
               if (_fastEnemy.Top >= 560)
               {
                    _fastEnemy.Top = -550;
                    _fastEnemy.Left = position2;
               }
          }
     }
}
