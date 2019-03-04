using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {

            // Fruit[] myFruits = new Fruit[5];

            var myFruits = new List<Fruit>();
            string nev, hely;
            int Mennyi,hany;
            int osszmenny = 0;

            Console.Write("Kérem a gyümölcsök számát: ");
            Mennyi = int.Parse(Console.ReadLine());

            for (int i = 0; i < Mennyi; i++)
            {
                Console.Write("Kérem a(z) {0}. a gyümölcsök Mennyiségét : ", i + 1);
                hany = int.Parse(Console.ReadLine());

                Console.Write("Kérem a(z) {0}. Gyümölcs nevét: ", i + 1);
                nev = Console.ReadLine();

                Console.Write("Kérem a(z) {0}. Származési helyét: ", i + 1);
                hely = Console.ReadLine();

                osszmenny += hany;


                myFruits.Add(new Fruit(nev, hely, hany));



            }
            Console.WriteLine("gyümölcsök összes mennyisége:" + osszmenny);
            Console.ReadKey();



        }
    }
}
