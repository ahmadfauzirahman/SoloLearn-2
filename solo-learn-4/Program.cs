using System;
using System.Collections.Generic;

namespace solo_learn_4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double d = 1.0;
            double[] arr = {3.0, 0.5, 2.0, 1.5};
            for (int i = 0; i < arr.Length; i++)
            {
                d *= arr[i];
            }
            Console.WriteLine(d);
            
            Console.WriteLine("--------------");
            int x = 10;
            do
            {
                x *= 2;
            } while (x <= 5);
            Console.WriteLine(x);
            Console.WriteLine("--------------");
            int s = 1;
            int[] darr = {9, 4, 5};
            foreach (int i in darr)
            {
                if (i % 2 == 0)
                {
                    x /= s;
                }
                else
                {
                    s *= i;
                }
            }
            Console.WriteLine(s);
            Console.WriteLine("--------------");

            int k = 0;
            for (int h = 0; h < 9; h++)
            {
                k++;
                h++;
            }
            Console.WriteLine(k);
            Console.WriteLine("--------------");

            Dictionary<string,int> dictionary = new Dictionary<string, int>();
            dictionary.Add("wood",1500);
            dictionary.Add("food",3000);
            dictionary.Add("iron",4500);
            if (dictionary.ContainsKey("gold"))
            {
                Console.WriteLine(6000);
            }
            else
            {
                int value = dictionary["iron"];
                Console.WriteLine(value);
            }
            Console.WriteLine("--------------");
            int[] n = new int[5];
            int w;
            for (w = 0; w < 5 ; w++)
            {
                Console.Write(n[w]);
            }
        }
    }
}