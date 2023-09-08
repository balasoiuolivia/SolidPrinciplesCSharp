using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IC_SolidPrinciples_CSharp_Bun.OOP.Polymorphism
{
    class Student
    {
        public string Nume { get; private set; }
        public string Prenume { get; private set; }
        public string Adresa { get; private set; }

        public Student(string Nume, string Prenume, string Adresa)
        {
            this.Nume = Nume;
            this.Prenume = Prenume;
            this.Adresa = Adresa;
        }

        //polimorfism dinamic Overiding
        public virtual void PrintNume()
        {
            Console.WriteLine("Numele Studentului este: "+Nume);
        }
    }
}
