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
            bool moreBook = true;
            int v = 0 , iPage;
            string s, sName, sAuthor ;
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
            s = Console.ReadLine();
            Console.WriteLine("Beolvas�s konzolr�l:" + s);

            //Egy billenty� le�t�se
            //******Console.ReadKey(true).KeyChar******
            //integerr� konvert�lni a console sz�mot(string)
            // int.Parse(Console.ReadLine())  

            //T�mb�k
            //L�ter hoztunk egy int elemeket tartalmkaz� t�mb�t melynek a neve: szamok
            int[] szamok = new int[5];
            string[] szovegek = new string[10]; 

            //T�mb inicializ�l�s
            int[] iNums = new int[] { 1, 2, 3, 4, 5, 6 };

            string[] sFruit = new string[] {"alma", "k�rte", "ban�n", "narancs"};
            Console.WriteLine("iNums els� eleme: {0} sFruit els� eleme:{1} ",iNums[0], sFruit[0]);
            Console.WriteLine("iNums els� eleme: " + iNums[0] + " sFruit els� eleme: " + sFruit[0]);

            ///T�pusos list�k: List<T> 

            //Lista elem
            var Lista = new List<Book>();

            //�j elemek hozz�ad�sa a list�hoz
            //Ctrl-'.' H�vhatjuk seg�ts�g�l
            Lista.Add(new Book() { Name = "Oroszl�nk�lyk�k", Author = "Irwin Shaw", Page = 100 });
            Lista.Add(new Book() { Name = "Megkergetve", Author = "Marg� Istv�n", Page = 200 });
            Lista.Add(new Book() { Name = "Egri csillagok", Author = "G�rdonyi G�za", Page = 1200 });


            //Lista ki�rat�s
            foreach (Book book in Lista)
            {
                Console.WriteLine(book.Name + " " + book.Author + " " + book.Page);
            }
            Console.WriteLine("*********************************************************************");

            Lista.Remove(new Book() { Name = "Megkergetve", Author = "Marg� Istv�n", Page = 200 });

            foreach (Book book in Lista)
            {
                Console.WriteLine(book.Name + " " + book.Author + " " + book.Page);
            }


            Console.WriteLine("*********************************************************************");

           // Lista.Remove(Lista.Find(x => x.Name.Contains("Oroszl�nk�lyk�k")));


            //foreach (Book book in Lista)
           // {
           //     Console.WriteLine(book.Name + " " + book.Author + " " + book.Page);
           // }
            

            //Console.WriteLine("Keress�k az Oroszl�nk�lyk�k k�nyvet: " +  Lista.Find(x => x.Name.Contains("Oroszl�nk�lyk�k")).Name);



            //Eg�sz�tsuk ki ugy a programot h a felhasznalo lehetoseget kapjon interaktiv modon a konyvtar elemeinek modositasahoz a kovetkezo mododn: a progi ciklikusan megkerdezi h mit szeretne megcsinalni az egyes opciok-> u= 3 adat: szerzo ,cim, lapszam, t= Megk�rdezi mit szeretnel torolni, l= Listazas
            do
            {
                Console.WriteLine("***************************************************************************************************");
                Console.WriteLine("********************************�dv a K�nyvt�rrendszeremben!************************************");
                Console.WriteLine("***************************************************************************************************");

                Console.WriteLine("------------------------------------------------------------------------------------------------");
                Console.WriteLine(" K�rlek v�lassz -> u = �j k�nyv felv�tel , t = Valamelyik k�nyv t�rl�se, l = K�nyvt�r list�z�sa, k = Kil�p�s");
                Console.WriteLine("------------------------------------------------------------------------------------------------");
                moreBook = true;
            switch (Console.ReadKey(true).KeyChar)
            {
                case 'l':
                    foreach (Book book in Lista)
                    {
                        Console.WriteLine(book.Name + " " + book.Author + " " + book.Page);
                    }
                    break;
                case 't':
                        Console.WriteLine("Melyik k�nyvet szeretn�d t�r�lni?");
                        sName = Console.ReadLine();
                        Lista.Remove(Lista.Find(x => x.Name.Contains(sName)));
                        break;
                case 'u':
                        Console.Write("K�rem a k�nyv c�m�t: ");
                        sName = Console.ReadLine();
                        Console.Write("K�rem a k�nyv szerz�j�t: ");
                        sAuthor = Console.ReadLine();
                        Console.Write("K�rem az oldalsz�mot: ");
                        iPage = int.Parse(Console.ReadLine());
                        Lista.Add(new Book { Name = sName, Author = sAuthor, Page = iPage });
                        break;
                    case 'k':
                        moreBook = false;
                        break;

            }
            } while (moreBook);

        }
    }
}
