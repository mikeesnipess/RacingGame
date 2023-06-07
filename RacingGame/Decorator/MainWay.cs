using RacingGame.Background;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingGame.Decorator
{
     class MainWay : IWay
     {

          private PictureBox _bg1 = new PictureBox();
          private PictureBox _bg2 = new PictureBox();
          private int _coin;


          public MainWay(PictureBox bg1, PictureBox bg2, int coin)
          {
               _bg1 = bg1;
               _bg2 = bg2;
               _coin = coin;
          }
          public void GetLevel(int speed)
          {


               if (_coin <= 3)
               {
                    _bg1.Top += speed;
                    _bg2.Top += speed;
                    if (_bg1.Top >= 560)
                    {
                         _bg1.Top = 0;
                         _bg2.Top = -560;
                    }
               }
               else
               {
                    _bg1.Top += speed-3;
                    _bg2.Top += speed-3;
                   
                         if (_bg1.Top == 650)
                         {
                              _bg1.Top = 560;
                              _bg2.Top = 560;
                         }
               }

          }
     }
}
