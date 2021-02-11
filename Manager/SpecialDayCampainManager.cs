using MyGameProject.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProject.Manager
{
    class SpecialDayCampainManager : ICampainService
    {
        public void SaveCampain()
        {
            Console.WriteLine("..." + " Günü İndirimi Eklendi");
        }
        public void DeleteCampain()
        {
            Console.WriteLine("..." + " Günü İndirimi Silindi");
        }
        public void UpdateCampain()
        {
           Console.WriteLine("..." + " Günü İndirimi Güncellendi");
        }
        public void ImplementedCampain()
        {
            Console.WriteLine("..." + "Günü indirimi uygulandı");
        }
    }
}
