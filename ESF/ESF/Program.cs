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
            string s;
            //A létrehozott új típussal inicializálunk egy objektumot
            Excercise ex = new Excercise("Polgár József");

            //ex.Name = "Polgár József";

            Console.WriteLine(ex.Name);


            ex.PrintName();

            Console.WriteLine(ex.getName());

            ///Ciklusok 

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("CIklus:<változóhivaztkozás I.>" + i);
                Console.WriteLine("CIklus:<változóhivaztkozás II.> {0}", 1);
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

            //ELágazások
            v = 2;
            if (v == 2)
            {
                Console.WriteLine("A v értéke egyenlõ 2vel");
            }
            else if (v == 3)
            {
                Console.WriteLine("A v értéke egyenlõ 3al");
            }
            else
            {
                Console.WriteLine("V nem 2 és nem 3, hanem:");
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

            //Beolvas egy karaktert a konzolról
            s = Console.ReadLine();
            Console.WriteLine("Beolvasás konzolról:" + s);

            //Egy billentyû leütése
            //******Console.ReadKey(true).KeyChar******
            //integerré konvertálni a console számot(string)
            // int.Parse(Console.ReadLine())  

            //Tömbök
            //Léter hoztunk egy int elemeket tartalmkazó tömböt melynek a neve: szamok
            int[] szamok = new int[5];
            string[] szovegek = new string[10]; 

            //TÖmb inicializálás
            int[] iNums = new int[] { 1, 2, 3, 4, 5, 6 };

            string[] sFruit = new string[] {"alma", "körte", "banán", "narancs"};
            Console.WriteLine("iNums elsõ eleme: {0} sFruit elsõ eleme:{1} ",iNums[0], sFruit[0]);
            Console.WriteLine("iNums elsõ eleme: " + iNums[0] + " sFruit elsõ eleme: " + sFruit[0]);

            ///Típusos listák: List<T> 

            //Lista elem
            var Lista = new List<Book>();

            //Új elemek hozzáadása a listához
            //Ctrl-'.' Hívhatjuk segítségül
            Lista.Add(new Book() { Name = "Oroszlánkölykök", Author = "Irwin Shaw", Page = 100 });
            Lista.Add(new Book() { Name = "Megkergetve", Author = "Margó István", Page = 200 });
            Lista.Add(new Book() { Name = "Egri csillagok", Author = "Gárdonyi Géza", Page = 1200 });


            //Lista kiíratás
            foreach (Book book in Lista)
            {
                Console.WriteLine(book.Name + " " + book.Author + " " + book.Page);
            }
            Console.WriteLine("*********************************************************************");

            Lista.Remove(new Book() { Name = "Megkergetve", Author = "Margó István", Page = 200 });

            foreach (Book book in Lista)
            {
                Console.WriteLine(book.Name + " " + book.Author + " " + book.Page);
            }


            Console.WriteLine("*********************************************************************");

            Lista.Remove(Lista.Find(x => x.Name.Contains("Oroszlánkölykök")));


            foreach (Book book in Lista)
            {
                Console.WriteLine(book.Name + " " + book.Author + " " + book.Page);
            }


            //Console.WriteLine("Keressük az Oroszlánkölykök könyvet: " +  Lista.Find(x => x.Name.Contains("Oroszlánkölykök")).Name);


            Console.ReadKey();
        }
    }
}
