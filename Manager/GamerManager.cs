using System;
using System.Collections.Generic;
using System.Text;
using MyGameProject.Entity_Varlik;
using MyGameProject.Interface;

namespace MyGameProject.Manager
{
    class GamerManager 
    {
        public void AddGamer(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Eklendi.");
        }

        public void DeleteGamer(Gamer gamer)
        {
            Console.WriteLine("Oyuncu bilgileri Silindi");
        }

        public void UpdateGamerİnfo(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Bilgileri Güncellendi");
        }
    }
}
