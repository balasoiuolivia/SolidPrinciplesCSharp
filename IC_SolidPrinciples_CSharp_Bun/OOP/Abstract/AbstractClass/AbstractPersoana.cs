using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IC_SolidPrinciples_CSharp_Bun.OOP.Abstract.AbstractClass
{
    abstract class AbstractPersoana
    {
        public abstract void Munceste();
        public abstract void Invata();
        public void DetaliiPersoana()
        {
            Console.WriteLine("Detaliile despre persoana sunt");
        }
    }
}
