using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IC_SolidPrinciples_CSharp_Bun.OOP.Mostenire
{
    class Persoana
    {
        public string Nume { get; private set; }
        public string Prenume { get; private set; }
        public int Varsta{ get; private set; }
        public bool IsAngajat { get; private set; }

        public Persoana(string nume, string prenume, int varsta, bool isAngajat)
        {
            Nume = nume;
            Prenume = prenume;
            Varsta = varsta;
            IsAngajat = isAngajat;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Numele este: {0}",Nume);
            Console.WriteLine("Preumele este: {0}", Prenume);
            Console.WriteLine("Varsta este: {0}", Varsta);
            Console.WriteLine("Este Angajat: {0}", IsAngajat);
        }
    }
}
