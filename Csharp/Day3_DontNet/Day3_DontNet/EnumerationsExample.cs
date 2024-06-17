using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_DontNet
{
    // we can manually Assigne the value/index of the constants if not they will start from 0 and increments accordingly
    enum Cities { Agra=1,Banglore=4, Chennai=2,Hyderabad=3,Kolkata=5,Mumbai };
    class EnumerationsExample
    {
        enum Days { mon,tue,wed,thur,fri,sat,sun}
        public static void EnumOperations()
        {
            foreach(int x in Enum.GetValues(typeof(Cities)))
            {
                
                    Console.WriteLine(Enum.GetName(typeof(Cities), x)+" "+x);
                
            }
        }
    }
}
