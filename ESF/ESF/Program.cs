using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESF
{
    class Program
    {
        static void Main(string[] args)
        {
            //A l�trehozott �j t�pussal inicializ�lunk egy objektumot
            Excercise ex = new Excercise("Polg�r J�zsef");

            //ex.Name = "Polg�r J�zsef";

            Console.WriteLine(ex.Name);


            ex.PrintName();

            Console.WriteLine(ex.getName());

            //Beolvas egy karaktert a konzolr�l
            Console.ReadKey();
        }
    }
}
