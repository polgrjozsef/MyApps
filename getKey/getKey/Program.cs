using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getKey
{
    class Program
    {
        static void Main(string[] args)
        {

                do
                {
                    Console.WriteLine("Írjon be egy számot vagy egy betût: ");
                    switch (Console.ReadKey(true).KeyChar)
                    {
                        case '0':
                            Console.WriteLine("Szám");
                            break;
                        case '1':
                            Console.WriteLine("Szám");
                            break;
                        case '2':
                            Console.WriteLine("Szám");
                            break;
                        case '3':
                            Console.WriteLine("Szám");
                            break;
                        case '4':
                            Console.WriteLine("Szám");
                            break;
                        case '5':
                            Console.WriteLine("Szám");
                            break;
                        case '6':
                            Console.WriteLine("Szám");
                            break;
                        case '7':
                            Console.WriteLine("Szám");
                            break;
                        case '8':
                            Console.WriteLine("Szám");
                            break;
                        case '9':
                            Console.WriteLine("Szám");
                            break;
                        default:
                            Console.WriteLine("Egyéb");
                        break;



                        }


                } while (true) ;


        }
    }
}
