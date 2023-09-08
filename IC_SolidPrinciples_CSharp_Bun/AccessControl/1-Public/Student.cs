using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IC_SolidPrinciples_CSharp_Bun.AccessControl.Public
{
    class Student
    {
        public void PrintInfoStudent()
        {
            Persoana persoana = new Persoana("Popescu", "Alexandra",22, true);
            persoana.PrintNume();
            //persoana.PrintPrenume();
            //persoana.PrintNumePrenume();
        }
    }
}
