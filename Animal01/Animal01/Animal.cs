using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal01
{
    abstract class Animal
    {
        protected string Name;
        protected bool isFemale;
        abstract public void Sleep();
        abstract public void Hunt();
        abstract public void Sound();
        abstract public void Born(int i);
    }
    
    class Cat : Animal
        
    {
        private List<Cat> Kids;
        public Cat(string aName, bool aGender)
        {
            Name = aName;
            isFemale = aGender;
        }
        public override void Sleep()
        {
            Console.WriteLine(Name + " is sleeping....");
        }
        public override void Hunt()
        {
            Console.WriteLine(Name + " is hunt....");
        }
        public override void Sound()
        {
            Console.WriteLine(Name + " Nyávog....");
        }

        public override void Born(int v)
         
        {
            if (isFemale)
            {
                Kids = new List<Cat>();
                for (int i = 0; i < v; i++)
                {
                    Kids.Add(new Cat("Cica " + i.ToString(), true));
                }
            }
            else
            {
                Console.WriteLine(Name + " Nem szülhet'");
            }

        }
        internal void Child()
        {
            foreach (var item in Kids)
            {
                Console.WriteLine(Name + " 's child name: " + item.Name);
            }
        }
        public Cat()
        {
        }

    }
    class Dog : Animal
    {
        private List<Dog> Kid;
        public Dog(string aName, bool aDOG)
        {
            isFemale = aDOG;
            Name = aName;
        }
        public override void Sleep()
        {
            Console.WriteLine(Name + " is sleeping....");
        }
        public override void Hunt()
        {
            Console.WriteLine(Name + " is hunt....");
        }
        public override void Sound()
        {
            Console.WriteLine(Name + " ugat....");
        }
        public override void Born(int v)

        {
            if (isFemale)
            {
                Kid = new List<Dog>();
                for (int i = 0; i < v; i++)
                {
                    Kid.Add(new Dog("kutya " + i.ToString(), false));
                }
            }
            else
            {
                Console.WriteLine(Name + " Nem szülhet'");
            }
        }
        internal void Child()
        {
            foreach (var item in Kid)
            {
                Console.WriteLine(Name + " 's child name: " + item.Name);
            }
        }
        public Dog()
        {
            if (Kid != null)
            {
                foreach (var item in Kid)
                {
                    Console.WriteLine(Name + " 's child name : " + item.Name);
                }
            }
        }

    }






}



