using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace RacingGame.Background
{
     class Way
     {
          private static Way _instance;
          private static object locker = new object();

          //private static int _speed;

          public Way()
          {

          }

          public static Way GetInstance()
          {
               if (_instance == null)
               {
                    lock (locker)
                    {
                         if (_instance == null)
                         {
                              _instance = new Way();
                         }
                    }
               }
               return _instance;
          }

          public int GetSpeed(int speed)
          {
               if (speed == 1)
                    speed = 10;
               else if (speed == 2)
                    speed = 15;
               else if (speed == 3)
                    speed = 20;


               return speed;
          }

          public int GetEnemySpeed(int speed)
          {
               if (speed == 1)
                    speed = 7;
               else if (speed == 2)
                    speed = 10;
               else if(speed ==3)
                    speed = 15;

               return speed;
          }
     }
}
