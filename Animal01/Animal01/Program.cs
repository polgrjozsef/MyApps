using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal01
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat myCat = new Cat("Cirmi", true);
            myCat.Sleep();
            myCat.Hunt();
            myCat.Sound();
            myCat.Born(5);
            myCat.Child();

            Dog myDog = new Dog("Gyula", false);
            myDog.Sleep();
            myDog.Hunt();
            myDog.Sound();
            myDog.Born(7);
            myDog.Child();


            Console.ReadKey();
        }
    }
}
