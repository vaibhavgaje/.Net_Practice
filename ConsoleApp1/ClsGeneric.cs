using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ClsGeneric
    {
        static void Display<G1, G2>(G1 s1, G2 s2)
        {
            Console.WriteLine("Value is : " + s1 + "," + s2);
        }
        static void Main(string[] args)
        {
            Display<string, int>("Vaibhav", 70);
            Display<int, double>(100,45.6 );
            Display<double, string>(34.5, "Varun");
        }
    }
}

/*
namespace ConsoleApp1
{
    internal class ClsGeneric
    {
        public void Display<G>(G s)
        {
            Console.WriteLine("Value is : "+s);
        }
        static void Main(string[] args)
        {
            ClsGeneric obj1 = new ClsGeneric();
            obj1.Display<string>("Vaibhav");
            obj1.Display<int>(1);
            obj1.Display<double>(34.5);
        }
    }
}*/


/*namespace ConsoleApp1
{
    internal class ClsGeneric
    {
        static void Display<G>(G s)
        {
            Console.WriteLine("Value is : " + s);
        }
        static void Main(string[] args)
        {
            Display<string>("Vaibhav");
            Display<int>(1);
            Display<double>(34.5);
        }
    }
}*/

/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ClsGeneric
    {
        public void Display(string s)
        {
            Console.WriteLine("Value is : " + s);
        }
        public void Display(int s)
        {
            Console.WriteLine("Value is : " + s);
        }
        public void Display(double s)
        {
            Console.WriteLine("Value is : " + s);
        }
        static void Main(string[] args)
        {
            ClsGeneric obj1 = new ClsGeneric();
            obj1.Display("Vaibhav");
            obj1.Display(1);
            obj1.Display(34.5);
        }
    }
}

*/