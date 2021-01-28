using System;

namespace GameProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UsersCheckManager());
            gamerManager.Add(new Gamer {Name="Haydar",LastName="Mısırlı",TcNo=7596,BirthDay="2001" });


            Games game1 = new Games() {Price=169,Name="Gta 5",Score=91.8 };
            Games game2 = new Games() {Price=200,Name="Battlefield 1",Score=82.6 };


            GameManager gameManager = new GameManager();
            gameManager.GameAdd(game1);

            Campain campain1 = new Campain() {DiscountName="Oyuncular Günü",DiscountValue=10 };
            Campain campain2 = new Campain() {DiscountName="Babalar Günü",DiscountValue=7 };

            CampainManager campainManager = new CampainManager();
            campainManager.CampainAdd(campain2,game2);
                       
        }
    }
}
