using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Employee6
    {
        protected int Empid;
        protected string Ename;
        string Eaddress;
        int Eage;
        public virtual void GetEmpData()
        {
            Console.WriteLine("Enter employee details");
            Console.WriteLine("Enter employee id");
            this.Empid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter employee name");
            this.Ename = Console.ReadLine();
            Console.WriteLine("Enter employee address");
            this.Eaddress = Console.ReadLine();
            Console.WriteLine("Enter employee age");
            this.Eage = Convert.ToInt32(Console.ReadLine());
        }
        public virtual void DisplayEmpData()
        {
            Console.WriteLine("Employee details are");
            Console.WriteLine("Employee id : "+this.Empid);
            Console.WriteLine("Employee name : "+this.Ename);
            Console.WriteLine("Employee address : "+this.Eaddress);
            Console.WriteLine("Employee age : "+this.Eage);
        }
    }
    class Manager : Employee6
    {
        double CA, Bonus;
        public override void GetEmpData()
        {
            base.GetEmpData();
            Console.WriteLine("Enter manager details");
            Console.WriteLine("Enter manager id");
            this.Empid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter manager name");
            this.Ename = Console.ReadLine();
            Console.WriteLine("Enter manager CA");
            this.CA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter manager Bonus");
            this.Bonus = Convert.ToDouble(Console.ReadLine());
        }
        public override void DisplayEmpData()
        {
            base.DisplayEmpData();
            Console.WriteLine("Manager details are");
            Console.WriteLine("Manager id : " + this.Empid);
            Console.WriteLine("Manager name : " + this.Ename);
            Console.WriteLine("Manager CA : " + this.CA);
            Console.WriteLine("Manager Bonus : " + this.Bonus);
        }
    }
    class ClsOverride
    {
        static void Main(string[] args)
        {
            Manager obj1 = new Manager();
            obj1.GetEmpData();
            obj1.DisplayEmpData();
        }
    }
}

/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Employee6
    {
        protected int Empid;
        protected string Ename;
        string Eaddress;
        int Eage;
        public  void GetEmpData()
        {
            Console.WriteLine("Enter employee details");
            Console.WriteLine("Enter employee id");
            this.Empid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter employee name");
            this.Ename = Console.ReadLine();
            Console.WriteLine("Enter employee address");
            this.Eaddress = Console.ReadLine();
            Console.WriteLine("Enter employee age");
            this.Eage = Convert.ToInt32(Console.ReadLine());
        }
        public  void DisplayEmpData()
        {
            Console.WriteLine("Employee details are");
            Console.WriteLine("Employee id : " + this.Empid);
            Console.WriteLine("Employee name : " + this.Ename);
            Console.WriteLine("Employee address : " + this.Eaddress);
            Console.WriteLine("Employee age : " + this.Eage);
        }
    }
    class Manager : Employee6
    {
        double CA, Bonus;
        public new void GetEmpData()
        {
            base.GetEmpData();
            Console.WriteLine("Enter manager details");
            Console.WriteLine("Enter manager id");
            this.Empid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter manager name");
            this.Ename = Console.ReadLine();
            Console.WriteLine("Enter manager CA");
            this.CA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter manager Bonus");
            this.Bonus = Convert.ToDouble(Console.ReadLine());
        }
        public new void DisplayEmpData()
        {
            base.DisplayEmpData();
            Console.WriteLine("Manager details are");
            Console.WriteLine("Manager id : " + this.Empid);
            Console.WriteLine("Manager name : " + this.Ename);
            Console.WriteLine("Manager CA : " + this.CA);
            Console.WriteLine("Manager Bonus : " + this.Bonus);
        }
    }
    class ClsOverride
    {
        static void Main(string[] args)
        {
            Manager obj1 = new Manager();
            obj1.GetEmpData();
            obj1.DisplayEmpData();
        }
    }
}
*/