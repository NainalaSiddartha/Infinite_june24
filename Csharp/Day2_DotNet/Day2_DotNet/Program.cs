using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_DotNet
{
    class Program
    {
        static void Main(string[] args)
        {

           // int x = 10;
            //Console.WriteLine("x value at the begining: {0}", x);

            //CallByValue(x); //caling a function by value
            //Console.WriteLine("x value after calling  call by value function : {0}", x);
            //Program program = new Program();
            //program.CallByReference(ref x);
            //Console.WriteLine("x value after calling call by refernce function :{0}", x);
            //Console.WriteLine("---------Out parameters----------");
            //int div, total, dif, prod;
            //Console.WriteLine("enter a, b value to do calculations ");
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //div = Calculator(a, b, out total, out prod, out dif);
            //Console.WriteLine($"sum is : {total}  difference is : {dif}  product is : {prod} div value is : {div}");


            //DecisionMaking decisionmaking = new DecisionMaking();

            // decisionmaking.CheckGrade();

            // decisionmaking.CheckGrade();

            //Loops loops = new Loops();
           // loops.WhileLoop();
            //loops.DOWhile();
           // loops.ForLoop();
            ArrayExample.ArrayInitialize();
            Console.Read();
        }
        public static void CallByValue(int j)
        {
            j = 100;
            Console.WriteLine("j is {0}", j);

        }
        public void CallByReference(ref int j)
        {
            j = 100;
            Console.WriteLine("j is {0}", j);
        }

        //Example of output parameters
        public static int Calculator(int a,int b,out int sum,out int product,out int subtraction)
        {
            sum = a + b;
            subtraction = a - b;
            product = a * b;
            return a / b;
        }
    }
}
