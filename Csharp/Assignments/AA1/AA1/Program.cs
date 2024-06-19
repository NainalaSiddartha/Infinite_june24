using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AA1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Q1();
            p.Q2();
            p.Q3();
            p.Q4();
            Console.Read();
        }

        void Q2()
        {
            Console.WriteLine("Enter two numbers ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if (a == b)
            {
                Console.WriteLine(" Given two numbers are equal");
            }
            else
            {
                Console.WriteLine("Given two numbers are different");
            }
        }
        void Q1()
        {
            Console.WriteLine("User please enter name and age ");
            string name = Console.ReadLine();
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--user Details--");
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Age  : " + age);
        }
        void Q3()
        {
            Console.WriteLine("Enter a Number ");
            int a = Convert.ToInt32(Console.ReadLine());
            if(a>0)
            {
                Console.WriteLine("positive number : " + a);
            }
            else if(a<0)
            {
                Console.WriteLine("Negative number : " + a);
            }
            else
            {
                Console.WriteLine("Neither positive number nor Negative : " + a);
            }
        }
        void Q4()
        {
            Console.WriteLine("enter two integers to do calculations");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a+b = " + (a + b));
            Console.WriteLine("a-b = " + (a - b));
            Console.WriteLine("a*b = " + (a * b));
            Console.WriteLine("a/b = " + (a / b));
        }
    }
}

