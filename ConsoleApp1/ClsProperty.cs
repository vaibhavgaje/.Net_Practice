using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ClsProperty
    {
        static void Main(string[] args)
        {
            Employee8 obj1 = new Employee8();
            Console.WriteLine("Enter the employee details");
            Console.WriteLine("Enter the employee ID: ");
            obj1.PEmpid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the employee Name: ");
            obj1.PEname = Console.ReadLine();
            Console.WriteLine("Enter the employee Eaddress: ");
            obj1.PEaddress = Console.ReadLine();
            Console.WriteLine("Enter the employee Eage: ");
            obj1.PEage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Employee details");
            Console.WriteLine("Employee id: "+obj1.PEmpid);
            Console.WriteLine("Employee name: "+obj1.PEname);
            Console.WriteLine("Employee address: "+obj1.PEaddress);
            Console.WriteLine("Employee age: "+obj1.PEage);

        }
    }
}
