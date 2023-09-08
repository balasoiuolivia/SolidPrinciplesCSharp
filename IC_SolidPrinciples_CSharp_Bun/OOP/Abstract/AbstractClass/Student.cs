using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IC_SolidPrinciples_CSharp_Bun.OOP.Abstract.AbstractClass
{
    internal class Student : AbstractPersoana
    {
        public string Nume { get; private set; }
        public string Prenume { get; private set; }
        public int Varsta { get; private set; }
        public string Meserie { get; private set; }

        public Student(string nume, string prenume, int varsta, string meserie)
        {
            Nume = nume;
            Prenume = prenume;
            Varsta = varsta;
            Meserie = meserie;
        }

        public override void Invata()
        {
            Console.WriteLine("Studentul Invata pentru examen");
        }

        public override void Munceste()
        {
            Console.WriteLine("Studentul Munceste in internship");
        }
    }
}
