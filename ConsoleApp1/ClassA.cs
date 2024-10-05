using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ClassA
    {
        int i = 10;
        int j = 20;
        public ClassA(int i, int j)
        {
            Console.WriteLine($"Local variables:{i}, {j}");
            Console.WriteLine($"Class level variables:{this.i} {this.j}");
        }
    }
    class ClassB
    {
        static void Main(string[] args)
        {
            ClassA obj1 = new ClassA(30, 40);
        }
    }
}
