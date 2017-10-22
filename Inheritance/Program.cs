using System;
using System.Collections.Generic;

namespace Inheritance
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Dog d = new Dog();
            Console.WriteLine(d.Legs);
            d.Bark();
        }

        class Animal
        {
            public int Legs { get; set; }
            public int Age { get; set; }
        }

        class Dog:Animal
        {
            public Dog()
            {
                Legs = 4;
            }

            public void Bark()
            {
                Console.Write("Woof");
            }
        }
    }
}