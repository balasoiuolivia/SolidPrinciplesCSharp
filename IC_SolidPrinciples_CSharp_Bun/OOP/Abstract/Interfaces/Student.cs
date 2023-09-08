using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IC_SolidPrinciples_CSharp_Bun.OOP.Abstract.Interfaces
{
    internal class Student: Persoana, IStudent
    {
        public Student(string Nume, string Prenume, int Varsta, string Meseria) : base(Nume, Prenume, Varsta, Meseria)
        {
        }

        public void DetaliiStudent()
        {
            Console.WriteLine("Se angajeaza QA automation");
        }

        public void Invata()
        {
            Console.WriteLine("Invata C#");
        }
    }
}
