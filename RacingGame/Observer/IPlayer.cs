using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingGame.Models
{
    public interface IPlayer
    {
          void Update(IPlayer player, int place,Record record);
          string GetName();
     }
}
