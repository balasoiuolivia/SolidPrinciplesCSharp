using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IC_SolidPrinciples_CSharp_Bun.OOP.Polymorphism
{
    internal class PolimorfismTest
    {
        [Test]
        public void PolimorfismeTest()
        {
            PartTimeStudent studentPart = new PartTimeStudent("Alexandra", "Popescu", "Bucuresti");
            studentPart.PrintNume();
            //studentPart.Prenume = "Ana";

            FullTimeStudent fullTimeStudent = new FullTimeStudent("Alexandra", "Popescu", "Bucuresti");
            fullTimeStudent.PrintNume();
            fullTimeStudent.PrintNote(4,4);
            fullTimeStudent.PrintNote(9.5, 4.5);
            fullTimeStudent.PrintNote(2, 4,5);
            fullTimeStudent.PrintNote(10);
        }
    }
}
