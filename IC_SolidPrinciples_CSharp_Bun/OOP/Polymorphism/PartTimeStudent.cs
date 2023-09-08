using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IC_SolidPrinciples_CSharp_Bun.OOP.Polymorphism
{
    class PartTimeStudent :Student
    {
        public PartTimeStudent(string Nume, string Prenume, string Adresa):base(Nume, Prenume, Adresa)
        {

        }

        public override void PrintNume()
        {
            Console.WriteLine("Numele ParTimeStudentului este: " + Nume);
        }
    }
}
