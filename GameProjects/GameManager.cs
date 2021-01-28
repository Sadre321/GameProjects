using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjects
{
    class GameManager : IGameService
    {
        public void GameAdd(Games game)
        {
            Console.WriteLine("Oyun eklendi :"+game.Name);
        }

        public void GameDelete(Games game)
        {
            Console.WriteLine("Oyun silindi :" + game.Name);
        }

        public void GameUpdate(Games game)
        {
            Console.WriteLine("Oyun puanı güncellendi :" + game.Score);
        }
    }
}
