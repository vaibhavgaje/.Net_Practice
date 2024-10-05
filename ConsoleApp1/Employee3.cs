using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Employee3
    {
        int Empid;
        string Ename;
        string Eaddress;
        int Eage;

        private Employee3()
        {
            Empid = 1234;
            Ename = "Vaibhav";
            Eaddress = "Pune";
            Eage = 28;
        }
        private void DisplayEmpData()
        {
            Console.WriteLine("Employee details are");
            Console.WriteLine($"Employee id: {Empid}");
            Console.WriteLine($"Employee name: {Ename}");
            Console.WriteLine($"Employee address: {Eaddress}");
            Console.WriteLine($"Employee age: {Eage}");
        }
        /*        static void Main(string[] args)
                {
                    Employee3 obj1 = new Employee3();
                    obj1.DisplayEmpData();
                }*/
    }
}
