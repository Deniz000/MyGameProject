using MyGameProject.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProject.Manager
{
    class DiscountWeekCampainManager : ICampainService
    {
        public void SaveCampain()
        {
            Console.WriteLine(" İndirim Haftası indirimleri eklendi.");
        }
        public void DeleteCampain()
        {
            Console.WriteLine(" İndirim Haftası indirimleri silindi.");
        }

        public void UpdateCampain()
        {
            Console.WriteLine(" İndirim Haftası indirimleri Güncellendi.");
        }
        public void ImplementedCampain()
        {
            Console.WriteLine(" İndirim Haftası indirimleri uygulandı.");
        }
    }
}
