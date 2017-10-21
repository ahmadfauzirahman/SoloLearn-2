using System;
using System.Collections.Generic;

namespace solo_learn_5
{
    internal class Program
    {
        class Fields
        {
            public int x = 5;
            public int y = 5;
            public int z = 3;
        }
        
        public static void Main(string[] args)
        {
            Fields f  = new Fields();
            int x = 6;
            int y = 9;
            int z = 7;

            x = f.x;
            f.y = y;
            z = f.z;
            Console.WriteLine(f.x + f.y*z);
            
            
            
            int value;
            value = Convert.ToInt32(!("Gari" == "Kai"));
            Console.WriteLine(value);
        }
    }
}