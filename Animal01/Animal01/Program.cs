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
            Cat myCat = new Cat("Cirmi");
            myCat.Sleep();
            myCat.Hunt();
            myCat.Sound();
            myCat.Born(412231210);
            myCat.Child();

            Dog myDog = new Dog("Gyula");
            myDog.Sleep();
            myDog.Hunt();
            myDog.Sound();

            Console.ReadKey();
        }
    }
}
