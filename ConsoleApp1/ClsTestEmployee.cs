using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ClsTestEmployee
    {
        static void Main(string[] args)
        {
            ClsEmp obj1 = new ClsEmp(101,"vaibhav",34000,"Pune");
            Console.WriteLine("Employee Details");
            Console.WriteLine("Employee id : " + obj1[0]);
            Console.WriteLine("Employee name : " + obj1[1]);
            Console.WriteLine("Employee salary : " + obj1[2]);
            Console.WriteLine("Employee address : " + obj1[3]);
            //Console.WriteLine("Employee age : " + obj1[4]);
            obj1[1] = "Varun";
            obj1[3] = "Nagar";

            Console.WriteLine("Employee Details");
            Console.WriteLine("Employee id : " + obj1[0]);
            Console.WriteLine("Employee name : " + obj1[1]);
            Console.WriteLine("Employee salary : " + obj1[2]);
            Console.WriteLine("Employee address : " + obj1[3]);
        }
    }
}
