using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingGame.Command
{
     class LeftCommand : Command
     {
          private readonly CarPrimary _carPrimary;


          public LeftCommand(CarPrimary carPrimary)
          {
               _carPrimary = carPrimary;

          }

          public override void Execute(KeyEventArgs e)
          {
               _carPrimary.Left(e);
          }
     }
}
