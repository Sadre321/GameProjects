using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjects
{
    class GamerManager : IGamerService
    {
        IUsersCheckServis _usersCheckServis;

        public GamerManager(IUsersCheckServis usersCheckServis)
        {
            this._usersCheckServis = usersCheckServis;
        }

        public void Add(Gamer gamer)
        {
            if (_usersCheckServis.Check(gamer)==true)
            {
                Console.WriteLine("Kayıt olundu.");
            }
            else 
            {
                Console.WriteLine("Kayıt başarısız");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi.");
        }
    }
}
