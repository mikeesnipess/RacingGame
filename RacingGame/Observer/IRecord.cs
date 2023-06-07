using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingGame.Models
{
     public interface IRecord
     {
          void RegisterPlayer(IPlayer player);
          void RemovePlayer(IPlayer player);
          Dictionary<IPlayer,int> NotifyPlayer(IPlayer player,int coin);
     }
}
