using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IC_SolidPrinciples_CSharp_Bun.Obiecte
{
    class Telefon
    {
        private string Marca;
        // proprietate, pt ca are get si ste automate
        public string Model { get; private set; }
        //variabila globala sau field, pt ca trebuie get si set manual facute
        private string Culoare;
        private bool Camera;

        private double _dimensiune;
        public double Dimensiune => _dimensiune;

        public Telefon(string Marca, string Model, string Culoare, bool Camera)
        {
            this.Marca = Marca;
            this.Model = Model;
            this.Culoare = Culoare;
            this.Camera = Camera;
        }

        public Telefon(string Marca, string Model, string Culoare)
        {
            this.Marca = Marca;
            this.Model = Model;
            this.Culoare = Culoare;
        }

        public string GetMarca()
        {
            return Marca;
        }


        public string GetCuloare()
        {
            return Culoare;
        }

        public bool GetCamera()
        {
            return Camera;
        }

        public void SetCuloare(string culoare)
        {
            Culoare = culoare;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Marca este {0}",Marca);
            Console.WriteLine("Culoarea este {0}", Culoare);
        }

        public void PrintCamera()
        {
            Console.WriteLine("Telefonul are sau nu camera {0}", Camera);
        }
    }
}
