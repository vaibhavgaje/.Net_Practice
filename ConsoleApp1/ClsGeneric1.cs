/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ClsGeneric1<G>
    {
        public void Display(G s)
        {
            Console.WriteLine($"Value is : {s}");
        }
    }
    class ClsGeneric2
    {
        static void Main(string[] args)
        {
            ClsGeneric1<string> obj1 = new ClsGeneric1<string>();
            ClsGeneric1<int> obj2 = new ClsGeneric1<int>();
            ClsGeneric1<double> obj3 = new ClsGeneric1<double>();
            obj1.Display("vaibhav");
            obj2.Display(100);
            obj3.Display(23.45);
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
    internal class ClsGeneric1<G1, G2>
    {
        public void Display(G1 s1, G2 s2)
        {
            Console.WriteLine($"Value are : {s1} ; {s2}");
        }
    }
    class ClsGeneric2
    {
        static void Main(string[] args)
        {
            ClsGeneric1<string, int> obj1 = new ClsGeneric1<string, int>();
            ClsGeneric1<int, float> obj2 = new ClsGeneric1<int, float>();
            ClsGeneric1<double, string> obj3 = new ClsGeneric1<double, string>();
            obj1.Display("vaibhav",100);
            obj2.Display(100, 34.5f);
            obj3.Display(23.45, "varun");
        }
    }
}
