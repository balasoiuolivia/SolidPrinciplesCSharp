using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IC_SolidPrinciples_CSharp_Bun.OOP.Abstract.Interfaces
{
    internal class Persoana
    {

        public string Nume { get; private set; }
        public string Prenume { get; private set; }
        public int Varsta { get; private set; }
        public string Meserie { get; private set; }

        public Persoana(string nume, string prenume, int varsta, string meserie)
        {
            Nume = nume;
            Prenume = prenume;
            Varsta = varsta;
            Meserie = meserie;
        }
    }
}
