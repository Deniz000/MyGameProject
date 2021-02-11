using System;
using System.Collections.Generic;
using MyGameProject.Entity_Varlik;
using MyGameProject.Interface;
using MyGameProject.Manager;

namespace MyGameProject
{
    class Program
    {
        static void Main(string[] args) 
        {
            Gamer gamer1 = new Gamer { Id = 1, GamerTc = "12345678985",  GamerName = "Emel Çetin", GamerPassword = "*****", DateOfBirth = new DateTime(2000,10,08), GamerCreditCard = "2584 6546 2133 2556" };
            Gamer gamer2 = new Gamer();
            GamerManager gamerManager = new GamerManager();
            gamerManager.AddGamer(gamer2);

            
            GameManager gameManager = new GameManager();
            Game game0 = new Game();
            gameManager.UpdateGame(game0);

            Game game1 = new Game {Id = 2, GameName = "PUBG", GameType = "Çok Oyunculu", GamePrice = "50" };
            Game game2 = new Game {Id = 3, GameName = "Call Of Duty", GameType = "Çok Oyunculu", GamePrice = "40" };

            ICampainService specialDay = new SpecialDayCampainManager();
            ICampainService discountWeek = new DiscountWeekCampainManager();

            specialDay.DeleteCampain();
            discountWeek.UpdateCampain();

            List<ICampainService> campainServices = new List<ICampainService> {specialDay,discountWeek };
            SaleManager saleManager = new SaleManager();
            saleManager.NewSale(gamer1,game1,campainServices);
            




           


        }


        
    }
}
