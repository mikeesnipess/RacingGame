using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingGame.Models
{
     public class Record : IRecord
     {
          private Dictionary<IPlayer, int> _player;
          public Record()
          {
               _player = new Dictionary<IPlayer, int>();
          }
          public void RegisterPlayer(IPlayer player)
          {
               _player.Add(player, 0);
          }

          public void RemovePlayer(IPlayer player)
          {
               _player.Remove(player);
          }

          public Dictionary<IPlayer, int> NotifyPlayer(IPlayer player, int coin)
          {
               foreach (var players in _player)
               {
                    if (player == players.Key)
                    {
                         if (coin > players.Value)
                         {
                              _player[players.Key] = coin;

                         }
                    }
                    
               }

               return _player;
          }


     }
}
