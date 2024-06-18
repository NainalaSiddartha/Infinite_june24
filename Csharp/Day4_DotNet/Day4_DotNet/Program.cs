using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_DotNet
{
    class Program

    {
        static void Main(string[] args)
        {
            Console.WriteLine(Polymorphism.Add(2, 3));
            Console.WriteLine(Polymorphism.Add(2, 3.3f));
            Console.WriteLine(Polymorphism.Add(2.3f, 3.3f));
            Console.WriteLine(Polymorphism.Add(2, 3,4));
           
            Console.WriteLine("hello");
            Console.Read();
        }

        
    }
    class Polymorphism
    {

        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        public static float Add(float a, float b)
        {
            return a + b;
        }
        public static float Add(int a,float b)
        {
            return a + b;
        }
    }
}
