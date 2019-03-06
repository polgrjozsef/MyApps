using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program: Kő,papír,olló játék programozása!
            //Írta: Polgár József, 2019.03.06
            //Megoldandó feladat: 1. Ciklikus program futás mindaddig, amíg a játékos szeretne játszani!
            bool moreGame = true;
            
            Console.WriteLine("***************Kő/Papír/Olló játék***************");
            do
            {
                Console.Write("Akarsz még játszani? i/n");
                if (Console.ReadKey(true).KeyChar == 'n')

                {
                    moreGame = false;

                }
            } while (moreGame);


        }
    }
}
