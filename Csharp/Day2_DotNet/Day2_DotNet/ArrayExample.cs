using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_DotNet
{
    class ArrayExample
    {
        public static void ArrayInitialize()
        {
            int[] array = new int[] { 5,3,4,2,1 };
            Console.WriteLine(array.Length);
            Console.WriteLine(array.Rank);
            Console.WriteLine("---array before sorting-----");
            foreach(int data in array)
            {
                Console.WriteLine(data);
            }
            Console.WriteLine("---array after sorting-----");

            Array.Sort(array);
            foreach (int data in array)
            {
                Console.WriteLine(data);
            }
            Array.Reverse(array);
            Console.WriteLine("reversing the array");
            foreach (int data in array)
            {
                Console.WriteLine(data);
            }
        }
    }
}
