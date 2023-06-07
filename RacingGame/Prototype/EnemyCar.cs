using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingGame.Prototype
{
     public class EnemyCar : Car
     {
          private PictureBox _enemy1;
          private PictureBox _enemy2;
          public EnemyCar(PictureBox enemy1, PictureBox enemy2)
          {
               _enemy1 = enemy1;
               _enemy2 = enemy2;
          }
          public override Car CarClone()
          {
               EnemyCar enemyCar = new EnemyCar(_enemy1, _enemy2);

               enemyCar.Speed = this.Speed;
               //enemyCar.Position = this.Position;

               return enemyCar;

          }

          public override void Enemy( int position,int position2)
          {

               _enemy1.Top += this.Speed;
               _enemy2.Top += this.Speed;

               if (_enemy1.Top >= 560)
               {
                    _enemy1.Top = -130;
                    _enemy1.Left = position;
               }
               if (_enemy2.Top >= 560)
               {
                    _enemy2.Top = -400;
                    _enemy2.Left = position2;
               }

          }
     }
}
