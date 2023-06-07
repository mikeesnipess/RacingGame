using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingGame.Proxy
{
    internal class StartGameProxy : IStartGame
    {
          private readonly IStartGame _startGame;
          private readonly string _username;
          private readonly string _password;
          private string _message;

          public StartGameProxy(IStartGame startGame,string username, string password)
          {
               _startGame = startGame;
               _username= username;
               _password= password;
          }
        public string GameStart()
        {
               if (_username == "mikee" && _password == "pass")
               {
                    _message = $"You are welcome {_username} developer!";
                     _startGame.GameStart();
                    return _message;
               }
               else
               {
                    _message = "Access denied. Only Admin have access";
                    return _message;
               }

          }
          
    }
}
