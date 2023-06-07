using RacingGame.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RacingGame.Models
{
     public class Player : IPlayer
     {
          private string _name;
          Button _playerRecords = new Button();
          public Player(string name, Button playerRecords)
          {
               _name = name;
               _playerRecords = playerRecords;
          }

          public void Update(IPlayer players, int countCoins,Record record)
          {

               var playerRecords = record.NotifyPlayer(players, countCoins);

               _playerRecords.Text = "Players tables: \n";
               foreach (var player in playerRecords)
               {
                    _playerRecords.Text += $"Player ─ {player.Key.GetName()}        Score : {player.Value}\n";
               }
          }
          public string GetName()
          {
               return _name;
          }
     }
}
