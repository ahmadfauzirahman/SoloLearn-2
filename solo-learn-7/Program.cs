using System;
using System.Collections.Generic;

namespace solo_learn_7
{
    internal class Program
    {
        static int sm(ref int a, ref double A)
        {
            --a;
            --A;
            if (a.GetType() == typeof(int))
                return (int) A;
            return a;
        }
        
        public static void Main(string[] args)
        {
            int A = 5;
            double a = -1.4;
            A = sm(ref A, ref a);
            Console.WriteLine(Math.Abs(Math.Ceiling(A+a)));
        }
    }
}