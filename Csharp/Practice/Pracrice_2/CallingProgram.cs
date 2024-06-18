

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice;
namespace Pracrice_2
{
    public class CallingProgram
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.print());
            Console.WriteLine("hello iam referencing another project ");
            
            Console.Read();
        }
    }
}
