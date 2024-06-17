
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_DontNet
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("sum is :"+ParamArrayExample(1, 2, 3, 4));
            // Console.WriteLine("sum is :"+ParamArrayExample(1, 2, 3));
            //StringOperations();

            //Struct_vs_Class();
            // EnumerationsExample.EnumOperations();
            Employee emp = new Employee();
            Employee emp1 = new Employee(1035488, "Siddartha", 300000);
            //emp.GetEmployeeDetails();
            emp.ShowEmpDetails();
            emp1.ShowEmpDetails();
            ReadOnly_Constant r = new ReadOnly_Constant();
            Console.WriteLine($"my var= {r.Myvar1} and mydata= {r.Myname}");
            Console.Read();
        }
        public static int ParamArrayExample(params int [] arr)
        {
            int sum = 0;
            foreach(var i in arr)
            {
                sum += i;
            }
            return sum;
        }
        public static void StringOperations()
        {

            // if the string literal is not present in the string poool it creates new memory to that string.
            // else it just points to the available string addrress.
            string s = "Hello";
            Console.WriteLine($"s value first time {s}, HashCode is {s.GetHashCode()}");
            s = "Hello world";
            Console.WriteLine($"s value changing first time {s}, HashCode is {s.GetHashCode()}");
            string s3 = "Hello";
            Console.WriteLine("s3 value {0}  and HashCode {1}", s3, s3.GetHashCode());
            string s4 = s3;
            Console.WriteLine("s4 value is {0} and hashcode is {1}", s4, s4.GetHashCode());
            s4 = "hii";

            Console.WriteLine("s4 value is changed  to {0} and hashcode is {1}", s4, s4.GetHashCode());


            //creating a string builder
            //StringBuilder sb = new StringBuilder("Hello");
            //Console.WriteLine("stringbuilder holding value {0}  and HashCode {1}", sb, sb.GetHashCode());
            //sb.Append("world");
            //Console.WriteLine("stringbuilder holding value {0}  and HashCode {1}", sb, sb.GetHashCode());
        }
        public static void Struct_vs_Class(){
            Student s1 = new Student();
            s1.marks1 = 60;
            s1.marks2 = 76;
            Console.WriteLine(s1.marks2 + s1.marks1);
            Student s2=new Student();
            s2 = s1;
            Console.WriteLine(s2.marks1 + s2.marks2);
            s1.marks1 = 50;
            s1.marks2 = 50;
            Console.WriteLine("s1  and s2 after changing s1 values");
            Console.WriteLine(s1.marks2 + s1.marks1);
            Console.WriteLine(s2.marks2 + s2.marks1);



        }
        //Structure is a Value typed Vs Class is a reference type
        struct Student
        {
            public int marks1;
            public int marks2;
        }
    }
}
