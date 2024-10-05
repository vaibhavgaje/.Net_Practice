/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal abstract class Vehicle
    {
        public abstract void wheels();
        public void enginetype()
        {
            Console.WriteLine("Bs-6 engine");
        }
        public abstract void color();
    }
    class ClsCar : Vehicle
    {
        public override void wheels()
        {
            Console.WriteLine("Car: 4 wheels");
        }
        public override void color()
        {
            Console.WriteLine("Car colour is red");
        }
    }
    class ClsBike:Vehicle
    {
        public override void wheels()
        {
            Console.WriteLine("Bike: 2 wheels");
        }
        public override void color()
        {
            Console.WriteLine("Bike colour is orange");
        }
    }
    class CLsAbstract
    {
        static void Main(string[] args)
        {
            ClsCar obj1 = new ClsCar();
            obj1.wheels();
            obj1.enginetype();
            obj1.color();
            ClsBike obj2 = new ClsBike();
            obj2.wheels();
            obj2.enginetype();
            obj2.color();
        }
    }
 }

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal abstract class Vehicle
    {
        public abstract void wheels();
        public void enginetype()
        {
            Console.WriteLine("Bs-6 engine");
        }
        public abstract void color();
    }
    class ClsCar : Vehicle
    {
        public override void wheels()
        {
            Console.WriteLine("Car: 4 wheels");
        }
        public override void color()
        {
            Console.WriteLine("Car colour is red");
        }
    }
    class ClsBike : Vehicle
    {
        public override void wheels()
        {
            Console.WriteLine("Bike: 2 wheels");
        }
        public override void color()
        {
            Console.WriteLine("Bike colour is orange");
        }
        public new void enginetype()
        {
            Console.WriteLine("Bs-4 engine");
        }
    }
    class CLsAbstract
    {
        static void Main(string[] args)
        {
            ClsCar obj1 = new ClsCar();
            obj1.wheels();
            obj1.enginetype();
            obj1.color();
            ClsBike obj2 = new ClsBike();
            obj2.wheels();
            obj2.enginetype();
            obj2.color();
        }
    }
}

