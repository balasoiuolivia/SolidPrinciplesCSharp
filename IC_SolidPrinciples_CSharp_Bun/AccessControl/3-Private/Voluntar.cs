using IC_SolidPrinciples_CSharp_Bun.AccessControl.Public;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IC_SolidPrinciples_CSharp_Bun.AccessControl._3_Private
{
    internal class Voluntar
    {
        public void InfoVoluntar()
        {
            Persoana persoana = new Persoana("Popescu", "Alexandra", 22, true);
            persoana.AcceseazaMetodaPrivata();
        }
    }
}
