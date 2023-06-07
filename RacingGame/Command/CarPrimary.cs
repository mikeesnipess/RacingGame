using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingGame.Command
{
     class CarPrimary
     {
          private Form1 _form1;
          private int _speed;
          public CarPrimary(Form1 form1,int speed)
          {
               _form1= form1;
               _speed= speed;
          }
          
          public void Left(KeyEventArgs e)
          {
               if ((e.KeyCode == Keys.Left || e.KeyCode == Keys.A) && _form1.car.Left > 10)
                    _form1.car.Left -= _speed;

          }
          public void Right(KeyEventArgs e)
          {
               if ((e.KeyCode == Keys.Right || e.KeyCode == Keys.D) && _form1.car.Left <480)
                    _form1.car.Left += _speed;

          }
     }
}
