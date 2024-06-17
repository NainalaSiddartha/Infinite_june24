using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_DontNet
{
    class ReadOnly_Constant
    {
        //readonly variables
        public readonly int Myvar1=10; // readonly member 
        public readonly string Myname;
        public const float pi = 3.14f;   // constant member
        public int a; //non static member;
        static int b; // static member
        public ReadOnly_Constant()
        {
            Myname = "siddartha read only name";
            Myvar1 = 20;// takes priority over asigning at declartion
        }
 

    }
}
