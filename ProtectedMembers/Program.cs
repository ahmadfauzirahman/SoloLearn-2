using System;
using System.Collections.Generic;

namespace ProtectedMembers
{
    internal class Program
    {
        class Person
        {
            protected int Age { get; set; }
            protected string Name { get; set; }
        }

        class Student:Person
        {
            public Student(string nm)
            {
                Name = nm;
            }

            public void Speak()
            {
                Console.Write("Name"+Name);
            }
        }
        
        public static void Main(string[] args)
        {
            Student s = new Student("Fauzi");
            s.Speak();
        }
    }
}