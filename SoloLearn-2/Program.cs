using System;
using System.Collections.Generic;

namespace SoloLearn_2
{
    internal class Program
    {
        static int Sum(int x)
        {
            if (x != 0)
            {
                return x + Sum(x - 1);
            }
            else
            {
                return x;
            }
        }
        
        public static void Main(string[] args)
        {
            int x = 6;
            x = Sum(x);
            Console.WriteLine(x);
            Console.WriteLine(++x);
            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            
            Item n1 = new Item(5);
            Item n2 = new Item(4);
            Item n3 = n1 + n2;
            Console.WriteLine(n3.Number);
        }
    }
}