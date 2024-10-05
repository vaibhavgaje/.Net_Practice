using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Branch1
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
            Console.WriteLine($"Branch address:{this.Baddress}");
        }
    }
    interface Employee7
    {
        public void GetEmpData();
        public void DisplayEmpData();
    }
    class ClsManager : Branch1, Employee7
    {
        int Empid;
        string Ename;
        double CA;
        double Bonus;
        public void GetEmpData()
        {
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
        public void DisplayEmpData()
        {
            Console.WriteLine("Manager details are");
            Console.WriteLine("Manager id : " + this.Empid);
            Console.WriteLine("Manager name : " + this.Ename);
            Console.WriteLine("Manager CA : " + this.CA);
            Console.WriteLine("Manager Bonus : " + this.Bonus);
        }
    }
    class ClsMultipleInheritance
    {
        static void Main(string[] args)
        {
            ClsManager obj1 = new ClsManager();
            obj1.GetBData();
            obj1.GetEmpData();
            obj1.DisplayBData();
            obj1.DisplayEmpData();
        }

    }
}
