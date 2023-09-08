using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IC_SolidPrinciples_CSharp_Bun.OOP.Mostenire
{
    class Student : Persoana
    {
        public Student(string nume, string prenume, int varsta, bool isAngajat):base(nume, prenume,varsta,isAngajat)
        {

        }
        public void PrintNumeStudent()
        {
            Console.WriteLine("Numele studentului este: {0}", Nume);
        }

        public void VerificStudentAngajat()
        {
            Console.WriteLine("Studentul este angajat? {0}",IsAngajat);
        }
    }
}
