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
            int v = 0;
            //A l�trehozott �j t�pussal inicializ�lunk egy objektumot
            Excercise ex = new Excercise("Polg�r J�zsef");

            //ex.Name = "Polg�r J�zsef";

            Console.WriteLine(ex.Name);


            ex.PrintName();

            Console.WriteLine(ex.getName());

            ///Ciklusok 

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("CIklus:<v�ltoz�hivaztkoz�s I.>" + i);
                Console.WriteLine("CIklus:<v�ltoz�hivaztkoz�s II.> {0}", 1);
            }
            v = 2;
            while (v>0)
            {
                Console.WriteLine("while ciklus");
                v--;
            }
            v = 2;
            do
            {
                Console.WriteLine("do while ciklus");
                v--;
            } while (v>0);

            //EL�gaz�sok
            v = 2;
            if (v == 2)
            {
                Console.WriteLine("A v �rt�ke egyenl� 2vel");
            }
            else if (v == 3)
            {
                Console.WriteLine("A v �rt�ke egyenl� 3al");
            }
            else
            {
                Console.WriteLine("V nem 2 �s nem 3, hanem:");
            }

            //switch
            v = 6;
            switch (v)
            {
                case 0:
                    Console.WriteLine("Switch: " + v);

                    break;
                case 5:
                    Console.WriteLine("Switch: " + v);
                    break;
                default:
                    Console.WriteLine("Switch default: " + v);
                break;


            }

            //Beolvas egy karaktert a konzolr�l
            Console.ReadKey();
        }
    }
}
