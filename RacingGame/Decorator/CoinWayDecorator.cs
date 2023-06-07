using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingGame.Decorator
{
     class CoinWayDecorator : WayDecorator
     {
          PictureBox _coin = new PictureBox();
          private bool _isCoin;
          public CoinWayDecorator(IWay iWay, PictureBox coin,bool isCoin) : base(iWay)
          {
               _coin = coin;
               _isCoin = isCoin;
          }

          public override void GetLevel(int speed)
          {
               
               _coin.Top += speed;

               if (_coin.Top >= 560)
               {
                    _coin.Top = -150;
                    Random random= new Random();
                    _coin.Left = random.Next(10, 480);
               }
               else if(_isCoin == true)
               {
                    _coin.Top = -250;
                    Random random = new Random();
                    _coin.Left = random.Next(10, 480);
                    _isCoin= false;
               }
          }
     }
}
