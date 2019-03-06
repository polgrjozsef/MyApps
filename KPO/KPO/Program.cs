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

            Random r = new Random();

            string compChoice = "";
            string playerChoice = "";

            int compScore = 0;
            int playerScore = 0;

            bool moreGame = true;
            do
            {
                Console.WriteLine("Ön mit választ? Kő(k),Papír(p),Olló(o)");
                switch (Console.ReadKey(true).KeyChar)
                {
                    case 'k':
                        playerChoice = "Kő";
                        break;
                    case 'p':
                        playerChoice = "Papír";
                        break;
                    case 'o':
                        playerChoice = "Olló";
                        break;


                }

                Console.Write("Akarsz még játszani? i/n");
                if (Console.ReadKey(true).KeyChar == 'n')


                {
                    moreGame = false;
                }
            } while (moreGame);

            
        }
    }
}
