using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IC_SolidPrinciples_CSharp_Bun.Multimi
{
    class Multimi
    {
        [Test]
        public void MultimiTest()
        {
            ArrayExemplu();
            ArrayValoareExemplu();
            ListValoare();
            DictionaryValoare();
            DictionaryColegi();
        }
        public void ArrayExemplu()
        {
            string[] arrayNume = new string[4];
            arrayNume[0] = "Nina";
            arrayNume[1] = "Alec";
            arrayNume[2] = "Bianca";
            arrayNume[3] = "Elena";

            foreach(string nume in arrayNume)
            {
                Console.WriteLine("Numele curent cu array este: "+nume);
            }
        }

        public void ArrayValoareExemplu()
        {
            string[] arrayNume = new string[4];
            arrayNume[0] = "Nina";
            arrayNume[1] = "Alec";
            arrayNume[2] = "Bianca";
            arrayNume[3] = "Elena";

            foreach (string nume in arrayNume)
            {
                if (nume.Equals("Alec"))
                {
                    Console.WriteLine("Numele curent cu array este: " + nume);
                }
                
            }
        }
        public void ListValoare()
        {
            List<string> listNume = new List<string>();
            listNume.Add("Nina");
            listNume.Add("Alec");
            listNume.Add("Bianca");
            listNume.Add("Elena");
            listNume.Add("Emil");

            foreach (string nume in listNume)
            {             
                  Console.WriteLine("Numele curent cu lista este: " + nume);                

            }
        }

        public void DictionaryValoare()
        {
            Dictionary<string, string> dictNume = new Dictionary<string, string>();
            dictNume.Add("Tester Manual", "Alex");
            dictNume.Add("Tester Automat", "Bianca");
            dictNume.Add("Tester MAnual+Automat", "Elena");
            dictNume.Add("Developer", "Emilian");
 

            foreach (var coleg in dictNume)
            {
                Console.WriteLine("Colegul cu meseria {0} are numele {1}", coleg.Key, coleg.Value);
            }
        }

        public void DictionaryColegi()
        {
            Dictionary<string, List<string>> dictNume = new Dictionary<string, List<string>>();
            List<string> listTestManual = new List<string>();
            listTestManual.Add("Alex");
            listTestManual.Add("Alexandru");
            listTestManual.Add("Alina");

            List<string> listTestAutomation = new List<string>();
            listTestAutomation.Add("Bianca");
            listTestAutomation.Add("Vlad");

            List<string> listDeveloperi = new List<string>();
            listDeveloperi.Add("Emilian");
            listDeveloperi.Add("Vlad");

            dictNume.Add("Tester Manual", listTestManual);
            dictNume.Add("Tester Automation", listTestAutomation);
            dictNume.Add("Developer", listDeveloperi);

            foreach( var key in dictNume.Keys)
            {
                List<string> list =dictNume[key];
                Console.WriteLine("Key = {0} contains {1} values",key , list.Count());
                foreach(var value in list)
                {
                    Console.WriteLine(value);
                }
            }
        }
    }
}
