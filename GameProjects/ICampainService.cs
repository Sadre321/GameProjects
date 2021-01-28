using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjects
{
    interface ICampainService
    {
        void CampainAdd(Campain campain,Games games);
        void CampainUpdate(Campain campain, Games games);
        void CampainDelete(Campain campain, Games games);
    }
}
