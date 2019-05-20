using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            //tömb létrehozása
            int[] iArray = new int[10];
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                iArray[i] = r.Next(100);
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(iArray[i]);
            }


            //Kilistázás
            Console.WriteLine("Dolgozat, 2019.05.20.");
            Console.ReadKey();
        }
    }
}
