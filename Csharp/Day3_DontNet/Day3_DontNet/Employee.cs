using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_DontNet
{
    class Employee
    {
        //class fields
        int EmpId;
        String EmpName;
        DateTime doj;
        float salary;

        // Constructor  without any parameters
       
        public Employee()
        {
            EmpId = 10;
            EmpName = "Infinite Ltd.";
            doj = Convert.ToDateTime("3/6/24");
            salary = 300;
        }
        //Parameterized Constructer
        public Employee(int eid,string name,float salary)
        {
            EmpId = eid;
            EmpName = name;
            this.salary = salary;//this refers to current object we can avoid name conflict
            doj = Convert.ToDateTime("1/2/3");
        }
        //class methods
        public  void GetEmployeeDetails()
        {
            Console.WriteLine("enter Employee id, Name ,Date of Joining ,salary :");
            EmpId = Convert.ToInt32(Console.ReadLine());
            EmpName = Console.ReadLine();
            doj = Convert.ToDateTime(Console.ReadLine());
            salary = Convert.ToSingle(Console.ReadLine());
        }
        public void ShowEmpDetails()
        {
            Console.WriteLine("---Displaying employee Details--- ");
            Console.WriteLine($"Employee Name {EmpName} ,Employee Id {EmpId},Date of Joining {doj} ,salary {salary}");
        }
    }
}
