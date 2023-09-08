using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IC_SolidPrinciples_CSharp_Bun.Structures
{
    
    class Structures
    {
        [Test]
        public void StructureTest()
        {
            CompareNumbers(2,3);
            CompareNumbers(6, 3);
            CompareNumbers(2, 2);
            //Write100LinesFOR();
            //Write100LinesWHILE();
            Write100LinesFOREACH();
        }

        public void CompareNumbers(int number1, int number2)
        {
            if(number1 > number2)
            {
                Console.WriteLine("Numarul 1 este mai mare decat numarul 2");
            }
            else if(number1==number2)
            {
                Console.WriteLine("Numerele sunt egale");
            }
            else
            {
                Console.WriteLine("Numarul 2 este mai mare decat numarul 1");
            }
        }

        public void Write100LinesFOR()
        {
            for(int index = 1; index <= 100; index++)
                Console.WriteLine("Numarul curent este "+index);
        }

        public void Write100LinesWHILE()
        {
            int index =1;
            while(index <= 100)
            {
                Console.WriteLine("Numarul curent este " + index);
                index++;
            }
        }

        public void Write100LinesFOREACH()
        {
            int[] numere= { 2, 3, 4 };
            foreach(int index in numere)
            {
                Console.WriteLine("Numarul curent este " + index);
            }
        }
    }
}
