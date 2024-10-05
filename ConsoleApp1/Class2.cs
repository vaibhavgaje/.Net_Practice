using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            int empid = 1234;
            string name = "Vaibhav";
            string address = "Pune";
            double salary = 345458.123;
            /*            Console.WriteLine("Employee name is  : "+name);
                        Console.WriteLine("Employee id = "+empid);  
                        Console.WriteLine("Employee addresss = "+address);  
                        Console.WriteLine("Employee Salary = "+salary); */
            //Console.WriteLine("Employee name is  : " + name + "\n"+"; Employee id = " + empid + "\n" + "; Employee addresss = " + address + "\n" + "; Employee Salary = " + salary);
            Console.WriteLine($"Employee empid is :{empid}");
            Console.WriteLine($"Employee name is :{name}");
            Console.WriteLine($"Employee address is :{address}");
            Console.WriteLine($"Employee salary is :{salary}");

        }
    }
}
