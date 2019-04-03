using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookClass
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Book mybook1 = new Book();
             Book mesemKonyv = new Book();
             mesemKonyv.name = "Harry Gotter";
             mesemKonyv.pages = 25;
             mesemKonyv.Author = "Polgár József";
             Console.Write("A kedvenc könyvem a: ");
             Console.WriteLine(mesemKonyv.name + " Szerzője: " + mesemKonyv.Author + " Oldalszám:" + mesemKonyv.pages );
             Console.ReadKey();
             */

            Book[] myBooks = new Book[5];
            string cim, iro;
            int lapszam, konyvszam;

            Console.Write("Kérem a könyvek számát: ");
            konyvszam = int.Parse(Console.ReadLine());

            for (int i = 0; i < konyvszam; i++)
            {
                Console.Write("Kérem a(z) {0}. könyv címét: ", i + 1);
                cim = Console.ReadLine();

                Console.Write("Kérem a(z) {0}. könyv íróját: ", i + 1);
                iro = Console.ReadLine();

                Console.Write("Kérem a(z) {0}. könyv lapainak számát: ", i + 1);
                lapszam = int.Parse(Console.ReadLine());




                myBooks[i] = new Book();
                myBooks[i].name = cim;
                myBooks[i].Author = iro;
                myBooks[i].pages = lapszam;



            }
            Console.Write("A könyvtáram tartalma: ");
            for (int i = 0; i < konyvszam; i++)
            { 
                Console.WriteLine(myBooks[i].name);




            }
            Console.ReadKey();

        }
    }
}
