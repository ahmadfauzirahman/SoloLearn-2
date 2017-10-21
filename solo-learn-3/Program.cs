using System;
using System.Collections.Generic;

namespace solo_learn_3
{
    internal class Program
    {
        static int inc(int arg)
        {
            return arg += 1;
        }

        static int Fibonaci(int x)
        {
            if (x <= 1)
            {
                return 1;
            }
            else
            {
                return Fibonaci(x - 1) + Fibonaci(x - 2);
            }
        }

        static int Func(int d = 3, int e = 7, int f = 6)
        {
            return d + e * f;
        }
        public static void Main(string[] args)
        {

            int d = 4;
            int e = 5;
            int f = 2;
            Console.WriteLine(Func(f,e));
            
            Console.WriteLine("------");
            Console.WriteLine("------");
            Console.WriteLine("------");
            
            int a = 0;
            a++;
            var res = inc(a++);
            Console.WriteLine(res++);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            int result = Fibonaci(4);
            Console.WriteLine(result);
            Console.WriteLine();
            Console.WriteLine();

            string x = "";
            string y = "SolorLearn";
            x += y.Substring(4, 1);
            x += y.Substring(3, 1);
            x += y.Substring(7, 1);
            x += y.Substring(5, 1);
            x += y.Substring(8, 1);
            Console.Write(x);
            
            Console.WriteLine();
            Console.WriteLine();

            int s = 10;
            do
            {
                s *= 2;
            } while (s <= 5);
            Console.WriteLine(s);

            Console.WriteLine();
            Console.WriteLine();
            int u = 12;
            u = u << 2;
            Console.WriteLine(u);

        }
    }
}