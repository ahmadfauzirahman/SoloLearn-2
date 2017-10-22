using System;
using System.Collections.Generic;

namespace solo_learn_6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.name = "Gosho";
            Console.Write(p1.name[2]);
            Console.Write(p1.country[4]);
            Console.WriteLine();
            
            double Pi = 3.14159;
            Console.WriteLine(Math.Round(Math.PI,1));
            
            
        }
        class Person
        {
            public string name;
            public string country;

            public Person()
            {
                name = "Petar";
                country = "Bulgaria";
            }
        }
    }
}