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
            //A létrehozott új típussal inicializálunk egy objektumot
            Excercise ex = new Excercise("Polgár József");

            //ex.Name = "Polgár József";

            Console.WriteLine(ex.Name);


            ex.PrintName();

            Console.WriteLine(ex.getName());

            //Beolvas egy karaktert a konzolról
            Console.ReadKey();
        }
    }
}
