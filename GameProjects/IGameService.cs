using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjects
{
    interface IGameService
    {
        void GameAdd(Games game);
        void GameUpdate(Games game);
        void GameDelete(Games game);

    }
}
