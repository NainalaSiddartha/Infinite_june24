using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Multiplication();
            p.CheckLargest();
            p.RemoveCharacter();
            p.SwapCharacters();
            Console.Read();
        }
        void Multiplication()
        {
            Console.WriteLine("---multiplication function---");
            Console.Write("Enter a number:  ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----Dispalying MultiplicationTable---");
            for(int i=0;i<=10;i++)
            {
                Console.WriteLine("{0} * {1} = {2}", number, i, number * i);
            }
        }
        void CheckLargest()
        {
            Console.WriteLine("----In CheckLargest Function---");

            Console.WriteLine("Enter three numbers to check the largest value: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            
            if(a>=b && a>=c)
            {
                Console.WriteLine("Largest value is : "+a);
            }
            else if(b>=a && b>=c)
            {
                Console.WriteLine("Largest value is : " + b);
            }
            else
            {
                Console.WriteLine("Largest value is : " + c);
            }
        }
        void RemoveCharacter()
        {
            Console.WriteLine("----In Character Removing Function----");
            Console.Write("Enter a String : ");
            string s = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter the index of a character to be removed : ");
            int index = Convert.ToInt32(Console.ReadLine());
            string res = "";
            for(int i=0;i<s.Length;i++)
            {
                if(i!=index)
                {
                    res = res + s[i];
                }
            }
            Console.WriteLine("String after removing the charater-> {0} at position {1}  is : {2} ", s[index],index, res);
        }
        void SwapCharacters()
        {
            Console.WriteLine("----In Swap Function----");
            Console.WriteLine("enter a String :");
            StringBuilder sb = new StringBuilder(Console.ReadLine());
            char c = sb[0];
            sb[0] = sb[sb.Length - 1];
            sb[sb.Length - 1] = c;
            Console.WriteLine("String after swapping first and last characters : " + sb);
        }
    }
}
