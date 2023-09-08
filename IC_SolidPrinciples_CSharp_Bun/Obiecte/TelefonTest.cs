using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IC_SolidPrinciples_CSharp_Bun.Obiecte
{
    class TelefonTest
    {
        [Test]
        public void MetodaTest()
        {
            Telefon samsung = new Telefon("Samsung", "S20", "negru", true);
            Telefon huawei = new Telefon("Huawei", "P50", "albastru", true);
            Telefon iphone = new Telefon("Iphone", "13", "alb", true);
            Telefon nokia = new Telefon("Nokia", "A10", "gri");
            //samsung.PrintInfo();
            //iphone.PrintCamera();
            //nokia.PrintCamera();
            huawei.PrintInfo();
            huawei.GetCuloare();
            
            Console.WriteLine(huawei.GetCuloare());
            huawei.SetCuloare("negru");

            huawei.PrintInfo();
            Console.WriteLine(huawei.Model);
        }
    }
}
