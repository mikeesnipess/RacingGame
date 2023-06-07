using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingGame.Prototype
{
    public abstract class Car
    {
          public int Speed { get; set; }
          //public int Position { get; set; }  
          public abstract void Enemy(int position, int position2);

          public abstract Car CarClone();
    }
}
