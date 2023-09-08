using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IC_SolidPrinciples_CSharp_Bun.OOP.Abstract.Interfaces
{
    internal class Angajat :Persoana,IAngajat
    {
        public Angajat(string Nume, string Prenume, int Varsta, string Meseria): base(Nume, Prenume, Varsta, Meseria) 
        {
        }

        public void DetaliiAngajat()
        {
            Console.WriteLine("Lucreaza QA automation");
        }

        public void Munceste()
        {
            Console.WriteLine("Scrie teste");
        }
    }
}
