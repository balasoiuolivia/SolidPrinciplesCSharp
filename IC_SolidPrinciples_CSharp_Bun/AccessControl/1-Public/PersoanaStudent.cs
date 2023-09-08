using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IC_SolidPrinciples_CSharp_Bun.AccessControl.Public
{
    internal class PersoanaStudent
    {
        public void PrintNumeStudent()
        {
            Persoana pers = new Persoana("Popescu", "Ion", 25, true);
            pers.PrintNume();
        }
    }
}
