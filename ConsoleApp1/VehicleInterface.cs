using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal interface VehicleInterface
    {
        public abstract void wheels();
        public abstract void enginetype();
    }
    class ClsCar1:VehicleInterface
    {
        public void wheels()
        {
            Console.WriteLine("car : 4 wheels");
        }
        public void enginetype()
        {
            Console.WriteLine("car : Bs-6 engine");
        }
    }
    class ClsBike1 : VehicleInterface
    {
        public void wheels()
        {
            Console.WriteLine("bike : 2 wheels");
        }
        public void enginetype()
        {
            Console.WriteLine("bike : Bs-4 engine");
        }
    }
    class ClsInterface
    {
        static void Main(string[] args)
        {
            ClsCar1 obj1 = new ClsCar1();
            obj1.wheels();
            obj1.enginetype();

            ClsBike1 obj2 = new ClsBike1();
            obj2.wheels();
            obj2.enginetype();
        }
    }
}
