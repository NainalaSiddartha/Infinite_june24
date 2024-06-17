using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_DotNet
{
    class DecisionMaking
    {
        public void CheckGrade()
        {
            char grade;
            Console.WriteLine("enter your grade : ");
            grade = Convert.ToChar(Console.ReadLine());
            if (grade == 'o' || grade == 'O')
            {
                Console.WriteLine("Outstanding...Well Done");
            }
            else if (grade == 'a' || grade == 'A')
            {
                Console.WriteLine("Excellent");
            }
            else if(grade=='b' || grade=='B')
            {
                Console.WriteLine("Good");
            }
            else
            {
                Console.WriteLine("enter valid grade..");
            }
        }
        public void CheckGradeWithSwitch()
        {
            char grade;
            Console.WriteLine("enter grade : ");
            grade = Convert.ToChar(Console.ReadLine());
            switch (grade)
            {
                case 'o':
                case 'O':
                    Console.WriteLine("outstanding..");
                    break;
                case 'a':
                case 'A':
                    Console.WriteLine("Excellent");
                    break;
                case 'b':
                case 'B':
                    Console.WriteLine("Good");
                    break;
                default:
                    Console.WriteLine("please enter valid grade");
                    break;
            }
        }
    }
    class Loops
    {


        public void WhileLoop()
        {
            int i = 0;
            while(i<5)
            {
                Console.WriteLine("iterating in while loop " + i);
                if(i==3)
                {
                    Console.WriteLine("breaking while loop as its value is 3");
                    break;
                }
                i++;
            }
        }
        public void DOWhile()
        {
            int i = 0;
            do
            {
                Console.WriteLine("iterating in doWhileloop " + i);
                i++;
            } while (i < 5);
        }

        public void ForLoop()
        {
            for(int i=0;i<5;i++)
            {
                if(i==3)
                {
                    Console.WriteLine("skipping one iteration of for loop when i value is 3");
                    continue;

                }
                Console.WriteLine("iterating in forloop " + i);
            }
        }
        public void ImplicitTypeExample()
        {
            int a;
            char c;
            string s;
            var mydata=34.5f;
            //dynamic type
            dynamic d;
            d = 5;
        }
    }
}
