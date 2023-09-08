using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IC_SolidPrinciples_CSharp_Bun.OOP.Mostenire
{
    class MostenireTest
    {
        [Test]
        public void Mostenire()
        {
            Angajat angajat = new Angajat("Popescu","Ion",25,true);
            angajat.PrintVarstaAngajat();            
            Console.WriteLine(angajat.Prenume);
            angajat.PrintInfoAngajat();

            Student student = new Student("Albu", "Ana", 35, false);
            student.PrintNumeStudent();
            student.VerificStudentAngajat();
        }
    }
}
