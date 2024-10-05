using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Employee
    {
        int Empid;
        string Ename;
        string Eaddress;
        int Eage;

        public void GetEmpData()
        {
            Console.WriteLine("Enter the employee details");
            Empid = Convert.ToInt32(Console.ReadLine());
            Ename = Console.ReadLine();
            Eaddress = Console.ReadLine();
            Eage = Convert.ToInt32(Console.ReadLine());
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
    class ClsAccess 
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.GetEmpData(); //Here . is called as member access operator
            emp.DisplayEmpData();
        }
    }

}
