using IC_SolidPrinciples_CSharp_Bun.AccessControl.Public;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IC_SolidPrinciples_CSharp_Bun.AccessControl._2_Protected
{
    internal class Cursant : Persoana
    {
        public Cursant(string Nume, string Prenume, int Varsta, bool IsAngajat) : base(Nume, Prenume,Varsta, IsAngajat)
        {

        }
        public void InfoCursant()
        {
            PrintNume();
            PrintPrenume();
            //PrintNumePrenume();
        }
    }
}
