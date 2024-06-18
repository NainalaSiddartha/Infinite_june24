using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_DotNet
{
    class Distance
    {
        public int dist;

        public Distance(int d)
        {
            dist = d;
        }
        public static Distance operator +(Distance d1,Distance d2)
        {
            Distance temp = new Distance(1);
            temp.dist = d1.dist + d2.dist;
            return temp;

        }
        public static Distance operator ++(Distance d)
        {
            //Distance temp= new Distance(0);
            // temp.dist=d.dist + 1;
            // return temp;
            d.dist++;
            return d;

        }
    }
    class OverloadingOperators
    {
        public static void Main()
        {
            Distance d1 = new Distance(51);
            Distance d2 = new Distance(60);
            Distance totaldistance = d1 + d2;
            Console.WriteLine("total distance = "+totaldistance.dist);
            Distance t = d1++;
            Console.WriteLine("speed Increased  to {0} ",t.dist);
            Console.Read();
        }
    }
    


}
