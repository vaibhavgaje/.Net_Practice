using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal partial class PartialClass
    {
        //x developer code
        int id;
        string name;
        string address;
        public void GetData()
        {
            Console.WriteLine("Enter the id:");
            this.id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the name:");
            this.name = Console.ReadLine();
            Console.WriteLine("Enter the address:");
            this.address = Console.ReadLine();
        }
    }
} 
