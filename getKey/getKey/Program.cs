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
                    Console.WriteLine("�rjon be egy sz�mot vagy egy bet�t: ");
                    switch (Console.ReadKey(true).KeyChar)
                    {
                        case '0':
                            Console.WriteLine("Sz�m");
                            break;
                        case '1':
                            Console.WriteLine("Sz�m");
                            break;
                        case '2':
                            Console.WriteLine("Sz�m");
                            break;
                        case '3':
                            Console.WriteLine("Sz�m");
                            break;
                        case '4':
                            Console.WriteLine("Sz�m");
                            break;
                        case '5':
                            Console.WriteLine("Sz�m");
                            break;
                        case '6':
                            Console.WriteLine("Sz�m");
                            break;
                        case '7':
                            Console.WriteLine("Sz�m");
                            break;
                        case '8':
                            Console.WriteLine("Sz�m");
                            break;
                        case '9':
                            Console.WriteLine("Sz�m");
                            break;
                        default:
                            Console.WriteLine("Egy�b");
                        break;



                        }


                } while (true) ;


        }
    }
}
