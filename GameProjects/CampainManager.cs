using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjects
{
    class CampainManager : ICampainService
    {
        public void CampainAdd(Campain campain, Games games)
        {
            Console.WriteLine("{0} özel {1} oyunundaki %{2} indirimi kaçırma!! ",campain.DiscountName,games.Name,campain.DiscountValue);
        }

        public void CampainDelete(Campain campain, Games games)
        {
            Console.WriteLine("{0} özel {1} oyunundaki %{2} indirim sona erdi. ", campain.DiscountName, games.Name, campain.DiscountValue);
        }

        public void CampainUpdate(Campain campain, Games games)
        {
            Console.WriteLine("{0} özel {1} oyunundaki %{2} yeni indirimi kaçırma!! ", campain.DiscountName, games.Name, campain.DiscountValue);
        }
    }
}
