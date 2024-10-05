using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Employee4
    {
        int Empid;
        string Ename;
        string Eaddress;
        int Eage;

        public Employee4() 
        {
            Empid = 1234;
            Ename = "Vaibhav";
            Eaddress = "Pune";
            Eage = 28;
        }
        public Employee4(Employee4 objTemp)
        {
            Empid = objTemp.Empid;
            Ename = objTemp.Ename;
            Eaddress = objTemp.Eaddress;
            Eage = objTemp.Eage;
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
    class ClsCopyConstructor
    {
        static void Main(string[] args)
        {
            Employee4 obj1 = new Employee4();
            Employee4 obj2 = new Employee4(obj1);
            obj1.DisplayEmpData();
            obj2.DisplayEmpData();
        }
    }
}
