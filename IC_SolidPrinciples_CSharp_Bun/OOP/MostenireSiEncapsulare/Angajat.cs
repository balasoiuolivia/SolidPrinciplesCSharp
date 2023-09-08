using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IC_SolidPrinciples_CSharp_Bun.OOP.Mostenire
{
    class Angajat:Persoana
    {
        public Angajat(string nume, string prenume, int varsta, bool isAngajat) : base(nume, prenume, varsta, isAngajat)
        {

        }
        public void PrintVarstaAngajat()
        {
            Console.WriteLine("Varsta angajatului este: {0}",Varsta);
        }
        public void PrintInfoAngajat()
        {
            PrintInfo();
        }
    }
}
