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
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("enter your age");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("the user name is " + name + " his age is " + age);//using concatination
            Console.WriteLine("the user name is {0}  and his age is {1}", name, age);//using palceholders
            //handsOn();
            Program program = new Program();
            Console.WriteLine(program.ternaryFunction());
            //NullableExample();
            //Type_Conversions();
            //Boxing_UnBoxing();
            Console.Read();


        }
        static void handsOn()
        {
            Console.WriteLine("Please enter your Name ");
            string uname = Console.ReadLine();
            Console.WriteLine("Please enter yout age ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("THe user name is {0} and his age is {1} !", uname, age);
            
            Console.Read();
        }
        bool ternaryFunction()
        {
            int num = 10;
            bool b;
            /* if(num==10)
             {
                 b = true;
             }
             else
             {
                 b = false;
             }*/
            b = num == 10 ? true : false;
            return b;
        }
        static void NullableExample()
        {
            int data1 = 10;
            int? data2 = null;
            if(data2==null)
            {
                data2 = data1;
            }
            else
            {
                data2
            }

        }
        static void Type_Conversions()
        {
            int i = 10;
            float j;
            j = i;       // implicit Type Conversion
            j = (float)i;    // explicit Type Conversion

            Console.WriteLine(i + "  " + j);
            //Type Conversion using Parse and Try Parse

            String s = "100";
            int num;
            num = int.Parse(s);// if the Given string is not numeric then Parse will raise an exception
            Console.WriteLine(num);
            string str = "100g";
            int result = 0;
            bool b = int.TryParse(str, out result); 
            //TryParse will not rise an exception if the string is not a numeric one
            if(b)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine("NOt a numeric String to parse ");
            }


        }
        static void Boxing_UnBoxing()
        {  // value to reference Type --Boxing
            int x = 10;
            Object obj;
            obj = x;
            Console.WriteLine(x + "  " + obj);
            // same type
            String s = "aaa";
            obj = s;

            Console.WriteLine(obj);
            //refernce to value type-- Unboxing

            float salary;
            Console.WriteLine("Enter salary ");
            salary = float.Parse(Console.ReadLine());
            Console.WriteLine(salary);

        }
    }
}
