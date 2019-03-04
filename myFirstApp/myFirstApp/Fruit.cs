using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirstApp
{
    class Fruit
    {
        public string Nev;
        public string Szarh;
        public int Menny;

               public Fruit(string aNev, string aSzhely, int aMenny )
        {
            Nev = aNev;
                Szarh = aSzhely;
                Menny = aMenny;
            Console.WriteLine("DEBUG: Fruit() konstruktor meghívás:");
        }
    }
}
