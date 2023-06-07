using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingGame.Command
{
     class RightCommand : Command
    {
          private readonly CarPrimary _carPrimary;


          public RightCommand(CarPrimary carPrimary)
          {
               _carPrimary = carPrimary;

          }

          public override void Execute(KeyEventArgs e)
          {
               _carPrimary.Right(e);
          }
     }
}
