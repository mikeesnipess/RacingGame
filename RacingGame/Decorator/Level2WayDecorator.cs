using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingGame.Decorator
{
     class Level2WayDecorator : WayDecorator
     {
          PictureBox _secondWay = new PictureBox();
          PictureBox _secondWay2 = new PictureBox();
          public Level2WayDecorator(IWay iWay,PictureBox secondWay,PictureBox secondWay2) : base(iWay)
          {
               _secondWay= secondWay;
               _secondWay2 = secondWay2;
          }
          public override void GetLevel(int speed)
          {
               _secondWay.Top += speed +5;
               _secondWay2.Top += speed +5;


               if (_secondWay.Top >= 560)
               {
                    _secondWay.Top = 0;
                    _secondWay2.Top = -560;
               }
          }
     }
}
