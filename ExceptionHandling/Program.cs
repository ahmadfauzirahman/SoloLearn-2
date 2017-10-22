using System;
using System.Collections.Generic;

namespace ExceptionHandling
{
    internal class Program
    {
        public static void Main(string[] args)
        {
//            try
//            {
//                int[] arr = new[] {4, 5, 8};
//                Console.Write(arr[8]);
//            }
//            catch (IndexOutOfRangeException e)
//            {
//                Console.WriteLine(e.Message);
//              
//            }
            string s = "tomorrow";
            s = s.Replace("o", "");
            s = s.Replace("t", "s");
            s = s.Replace("m", "u");
            s = s.Replace("r", "m");
            s = s.Replace("w", "er");
            Console.WriteLine(s);
            
            
        Console.WriteLine();
            int den = 0;
            int result = 0;
            try
            {
                result = 7 / den;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e);

            }
            catch (Exception e)
            {
                Console.WriteLine("Error");
            }
            finally
            {
                Console.WriteLine(result);
                
            }
        }
    }
}