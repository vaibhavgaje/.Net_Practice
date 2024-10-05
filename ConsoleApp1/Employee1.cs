using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Employee1
    {
        int Empid;
        string Ename;
        string Eaddress;
        int Eage;

        public Employee1()
        {
            Empid = 1234;
            Ename = "Vaibhav";
            Eaddress = "Pune";
            Eage = 28;

        }
        public void DisplayEmpData()
        {
            Console.WriteLine("Employee details are");
            Console.WriteLine($"Employee id: {Empid}");
            Console.WriteLine($"Employee name: {Ename}");
            Console.WriteLine($"Employee address: {Eaddress}");
            Console.WriteLine($"Employee age: {Eage}");

        }
    }
    class ClsUDConstructor
    {
        static void Main(string[] args)
        {
            Employee1 obj1 = new Employee1();
            Employee1 obj2 = new Employee1();
            obj1.DisplayEmpData();
            obj2.DisplayEmpData();
        }
    }
}
