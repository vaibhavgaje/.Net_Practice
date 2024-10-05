using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class18
    {
        /*        private void f1(string name)
                {
                    Console.WriteLine("Hello "+name);
                }
                static void Main(string[] args)
                {
                    Class18 obj1 = new Class18();
                    obj1.f1("Vaibhav");
                    obj1.f1("Varun");
                }*/
        /*        private void add(float a, int b)
                {
                    Console.WriteLine($"Sum is :{a+b}");
                }
                static void Main(string[] args)
                {
                    Class18 obj1 = new Class18();
                    obj1.add(5.1f, 6);
                }*/
        private int add(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Class18 obj1 = new Class18();
            int r = obj1.add(5, 6);
            Console.WriteLine("Result is = " + r);
        }
        /*        static void f1()
                {
                    Console.WriteLine("Hello");
                }
                static void Main(string[] args)
                {
                    f1();
                }*/

    }
}
