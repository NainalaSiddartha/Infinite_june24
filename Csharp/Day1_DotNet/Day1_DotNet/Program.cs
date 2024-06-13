using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_DotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name  ");
           string name =  Console.ReadLine();
            Console.WriteLine("Shownig your name using concatination "+name);
            Console.WriteLine("showing your name using placeholder {0}", name);
            Console.Read();

        }
    }
}
