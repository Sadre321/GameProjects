using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjects
{
    class UsersCheckManager : IUsersCheckServis
    {
        public bool Check(Gamer gamer)
        {
            if (gamer.Name == "Haydar" && gamer.LastName == "Mısırlı" && gamer.TcNo == 7596 && gamer.BirthDay == "2001")
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
