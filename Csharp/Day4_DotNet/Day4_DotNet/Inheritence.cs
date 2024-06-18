using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_DotNet
{
    class Parent
    {
        int i;
        public Parent()
        {
            Console.WriteLine("parent class Constructer");
        }
        public Parent(int data)
        {
            i = data;
            Console.WriteLine("called parent constructer with parameter");
        }
    }
    class Child : Parent
    {
        int i;
        public Child(int a, int b) : base(b)
        {
            i = a;
            Console.WriteLine("child Constructer  called");
        }
    }
    class Inheritence
    {
        public static void Main()
        {
            Child c1 = new Child(1, 2);
            Console.Read();
        }
    }
    //class Circle
    //{
    //    float r;
    //    public Circle(float r)
    //    {
    //        this.r = r;
    //    }
    //    public float Area()
    //    {
    //        return r * 3.14f;
    //    }
    //}
}
