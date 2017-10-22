using System;
using System.Collections.Generic;

namespace Interface
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            IShape c = new Circle();
            c.Draw();
        }
        
        public interface IShape
        {
            void Draw();
        }

        class Circle:IShape
        {
            public void Draw()
            {
             Console.WriteLine("Circle Draw");   
            }
        }
    }
}