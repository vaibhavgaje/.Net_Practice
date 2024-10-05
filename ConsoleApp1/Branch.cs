using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Branch
    {
        int Bcode;
        string Bname;
        string Baddress;

        public void GetBData()
        {
            Console.WriteLine("Enter Branch Details");
            Console.Write("Enter Branch code : ");
            this.Bcode = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Branch name : ");
            this.Bname = Console.ReadLine();
            Console.Write("Enter Branch address : ");
            this.Baddress = Console.ReadLine();

        }
        public void DisplayBData()
        {
            Console.WriteLine("Branch details are");
            Console.WriteLine($"Branch code:{this.Bcode}");
            Console.WriteLine($"Branch name:{this.Bname}"); 
            Console.WriteLine($"Branch address{this.Baddress}");
        }
    }
    class Employee5: Branch //Employee5 class(Derived/Child class) is inherited from branch class(Base/PArent class)
    {
        int Empid;
        string Ename;
        string Eaddress;
        int Eage;

        public void GetEmpData()
        {
            Console.WriteLine("Enter the employee details");
            Console.Write("Enter Employee id : ");
            Empid = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Employee name : ");
            Ename = Console.ReadLine();
            Console.Write("Enter Employee address : ");
            Eaddress = Console.ReadLine();
            Console.Write("Enter Employee age : ");
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
    class EmployeeSalary: Employee5
    {
        double Basic, DA, HRA, Gross;

        public void GetSal()
        {
            Console.WriteLine("Enter basic Salary");
            this.Basic = Convert.ToDouble(Console.ReadLine());
        }
        public void Calculate()
        {
            this.DA = this.Basic * 0.04;
            this.HRA = this.Basic * 0.6;
            this.Gross = this.Basic + this.DA + this.HRA;
        }
        public void Displaysal()
        {
            Console.WriteLine("Employee salary details");
            Console.WriteLine("Basic is :"+this.Basic);
            Console.WriteLine("DA is :"+this.DA);
            Console.WriteLine("HRA is :"+this.HRA);
            Console.WriteLine("Gross is :"+this.Gross);

        }
    }
    class ClsInheritance
    {
        static void Main(string[] args)
        {
/*            Branch obj1 = new Branch(); 
            obj1.GetBData();
            obj1.DisplayBData();*/
            EmployeeSalary obj1 = new EmployeeSalary();
            obj1.GetBData();
            obj1.GetEmpData();
            obj1.GetSal();
            obj1.Calculate();
            obj1.DisplayBData();
            obj1.DisplayEmpData();
            obj1.Displaysal();
        }  
    }
}

