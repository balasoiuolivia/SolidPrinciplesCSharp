using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IC_SolidPrinciples_CSharp_Bun.OOP.Abstract.Interfaces
{
    internal class InterfaceTest
    {
        [Test]
        public void InterfaceTests()
        {
            Student student = new Student("Pirvu", "Oana", 25, "Student");
            student.Invata();
            student.DetaliiStudent();

            Angajat angajat = new Angajat("Popescu", "Ion", 33, "Angajat");
            angajat.Munceste();
            angajat.DetaliiAngajat();

            StudentAngajat studentAngajat = new StudentAngajat("Albu", "Alina", 33, "Student si Angajat");
            studentAngajat.Invata();
            studentAngajat.Munceste();
            studentAngajat.DetaliiAngajat();
            studentAngajat.DetaliiStudent();
        }
    }
}
