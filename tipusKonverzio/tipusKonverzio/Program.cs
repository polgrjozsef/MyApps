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
                Console.WriteLine((int)ch);
            }

            //Tömbök

            int[] iTomb = new int[10];
            Random r = new Random();
            int iPrev = 0;
            for (int i = 0; i < iTomb.Length; i++)
            {
                Console.WriteLine("Kérem az {0}. számot:", i);
                try
                {
                    iTomb[i] = int.Parse(Console.ReadLine());
                    iPrev = i;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Hiba!" + e.Message);
                    i = iPrev;
                }
            }

            Console.WriteLine();
            for (int i = 0; i <iTomb.Length; i++)
            {
                Console.Write(iTomb[i] + " ");
            }

            int[] iArr = new int[] { 1, 2, 3, 4 };
            string[] sArr = new string[] { "alma", "körte", "Banán", "Mangó" };

            Array.Sort(sArr);
            Array.Sort(iArr);
            for (int i = 0; i < iArr.Length; i++)
            {
                Console.Write(iArr[i] + " ");
            }

            for (int i = 0; i < sArr.Length; i++)
            {
                Console.Write(sArr[i] + " ");
            }

            //Többdimenziós tömb
            int[,] matrix = new int[,]
            {
                {12, 23, 2 },
                {13, 67, 52 },
                {45, 55, 1 }
            };


                Console.ReadKey();
        }
    }
}
