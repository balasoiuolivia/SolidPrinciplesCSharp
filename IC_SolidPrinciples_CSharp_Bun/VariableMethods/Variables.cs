using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IC_SolidPrinciples_CSharp_Bun.VariableMethods
{
    class Variables
    {
        public string Name = "";
        public int Age;
        public double Height;

        [Test]
        public void VariablesTest()
        {
            PrintVariables();
            PrintVariabileLocale();
            Console.WriteLine("Salariul este:" + GetIncome());
            PrintGeneralVariables("Emil", 33, 1.9);
            PrintGeneralVariables("George", 22, 1.85);
        }

        private void PrintVariables()
        {
            Name = "Gigel";
            Age = 23;
            Height = 1.71;
            Console.WriteLine("Numele este " + Name);
            Console.WriteLine("Varsta este "+Age);
            Console.WriteLine("Inaltimea este {0}",Height);
        }

        private void PrintVariabileLocale()
        {
            string Gender = "Male";
            Console.WriteLine("Sexul este " + Gender);
        }

        public int GetIncome()
        {
            var Income = 5000;
            return Income;
        }

        private void PrintGeneralVariables(string name, int age, double height)
        {
            Console.WriteLine("Numele este " + name);
            Console.WriteLine("Varsta este " + age);
            Console.WriteLine("Inaltimea este {0}", height);
        }
    }
}
