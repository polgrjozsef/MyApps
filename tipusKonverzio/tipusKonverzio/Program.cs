using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tipusKonverzio
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 10;

            switch (x is int)
            {
                case true:
                    Console.WriteLine("Az x típusa int");
                    break;
                case false:
                    Console.WriteLine("Az x típusa nem int");
                    break;

            }

            object a = "123";
            object b = "Hello";
            object c = 10;

            string aa = a as string;
            //expr ? v1 : v2
            Console.WriteLine(aa == null ? "NULL" : aa); // 123 

            string bb = b as string;
            Console.WriteLine(bb == null ? "NULL" : bb); // Hello 

            string cc = c as string;
            Console.WriteLine(cc == null ? "NULL" : cc); // NULL 


            for (char ch = 'a'; ch <= 'z'; ++ch)
            {
                Console.Write((int)ch);
            }

            Console.ReadKey();
        }
    }
}
