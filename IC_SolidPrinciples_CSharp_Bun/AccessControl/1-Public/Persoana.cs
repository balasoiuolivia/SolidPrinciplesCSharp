using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IC_SolidPrinciples_CSharp_Bun.AccessControl.Public
{
    class Persoana
    {

        public string Nume { get; private set; }
        public string Prenume { get; private set; }
        public int Varsta { get; private set; }
        public bool IsAngajat { get; private set; }

        public Persoana(string nume, string prenume, int varsta, bool isAngajat)
        {
            Nume = nume;
            Prenume = prenume;
            Varsta = varsta;
            IsAngajat = isAngajat;
        }

        public void PrintNume()
        {
            Console.WriteLine("Numele este {0}", Nume);
        }
        protected void PrintPrenume()
        {
            Console.WriteLine("Prenumele este {0}", Prenume);
        }
        private void PrintNumePrenume()
        {
            Console.WriteLine("Numele este {0}", Nume);
            Console.WriteLine("Prenumele este {0}", Prenume);
        }

        public void AcceseazaMetodaPrivata()
        {
            PrintNumePrenume();
        }
    }
}
