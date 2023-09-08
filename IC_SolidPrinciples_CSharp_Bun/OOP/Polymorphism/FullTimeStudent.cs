using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IC_SolidPrinciples_CSharp_Bun.OOP.Polymorphism
{
    internal class FullTimeStudent : Student
    {
        public FullTimeStudent(string Nume, string Prenume, string Adresa) : base(Nume, Prenume, Adresa)
        {

        }

        public override void PrintNume()
        {
            Console.WriteLine("Numele FullTimeStudentului este: " + Nume);
        }

        //polimorfismul static = overloading
        public void PrintNote(int nota1, int nota2)
        {
            Console.WriteLine("Nota1 " + nota1);
            Console.WriteLine("Nota2 " + nota2);
        }

        public void PrintNote(int nota1, int nota2,int nota3)
        {
            Console.WriteLine("Nota1 " + nota1);
            Console.WriteLine("Nota2 " + nota2);
            Console.WriteLine("Nota3 " + nota3);
        }

        public void PrintNote(double nota1, double nota2)
        {
            Console.WriteLine("Nota1 " + nota1);
            Console.WriteLine("Nota2 " + nota2);
        }

        public int PrintNote(int nota1)
        {
            Console.WriteLine("Nota1 " + nota1);

            return 1;
        }
    }
}
