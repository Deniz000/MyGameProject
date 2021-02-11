using MyGameProject.Entity_Varlik;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProject.Manager
{
     class GameManager
    {
        public void AddGame(Game game) 
        {
            Console.WriteLine(game.GameName + "Oyun eklendi");
        }

        public void DeleteGame(Game game)
        {
            Console.WriteLine(game.GameName + "Oyun silindi");

        }
        public void UpdateGame(Game game) 
        {
            Console.WriteLine(game.GameName + "Oyun güncellendi");

        }

    }
}
