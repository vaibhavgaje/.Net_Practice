using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Employee2
    {
        int Empid;
        string Ename;
        string Eaddress;
        int Eage;

        public Employee2(int id, string s1, string s2, int Ag)
        {
            Empid = id;
            Ename = s1;
            Eaddress = s2;
            Eage = Ag;

        }
        public Employee2(int id, string s1)
        {
            Empid = id;
            Ename = s1;

        }
        public Employee2()
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

    class ClsParameter
    {
        static void Main(string[] args)
        {
            Employee2 obj1 = new Employee2(123, "Vaibhav", "Pune", 28);
            Employee2 obj2 = new Employee2(234, "Varun", "Pune", 29);
            Employee2 obj3 = new Employee2();
            Employee2 obj4 = new Employee2(234, "Varun");
            obj1.DisplayEmpData();
            obj2.DisplayEmpData();
            obj3.DisplayEmpData();
            obj4.DisplayEmpData();
        }
    }
}
