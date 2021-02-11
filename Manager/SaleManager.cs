using MyGameProject.Entity_Varlik;
using MyGameProject.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProject.Manager
{
    class SaleManager
    {
        public void NewSale(Gamer gamer,Game game,List<ICampainService> campain)
        {
            Console.Write("Ürün: " + game.GameName );
            Console.WriteLine("Ad Soyad: " + gamer.GamerName);
            Console.Write("Uygulanan kampanyalar: ");
            foreach (var campains in campain)
            {
                campains.ImplementedCampain();

            }
            Console.WriteLine("Tutar: ###.## Tl");
            Console.WriteLine("-İşlem Gerçekleşti-");
        }
    }
}
