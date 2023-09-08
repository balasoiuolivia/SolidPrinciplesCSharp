using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IC_SolidPrinciples_CSharp_Bun.OOP.Abstract.AbstractClass
{
    internal class AbstractTest
    {
        [Test]
        public void AbstractTests()
        {
            Student student = new Student("Pirvu", "Oana", 25, "Student");
            student.Invata();
            student.Munceste();
            student.DetaliiPersoana();


            Angajat angajat = new Angajat("Popescu", "Ion", 33, "Angajat");
            angajat.Munceste();
            angajat.Invata();
            angajat.DetaliiPersoana();


            StudentAngajat studentAngajat = new StudentAngajat("Albu", "Alina", 33, "Student si Angajat");
            studentAngajat.Invata();
            studentAngajat.Munceste();
            studentAngajat.DetaliiPersoana();
        }
    }
}
