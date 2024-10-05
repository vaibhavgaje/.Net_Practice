using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Parent
    {
        public void m1()
        {
            Console.WriteLine("m1 method of parent class");
        }
    }
    class Child1:Parent
    {
        public void m2()
        {
            Console.WriteLine("m2 method of child1 class");
        }
    }
    class Child2:Parent
    {
        public void m3()
        {
            Console.WriteLine("m3 method of child2 class");
        }
    }
    class ClsHierarchical
    {
        static void Main(string[] args)
        {
            Child1 c1 = new Child1();
            Child2 c2 = new Child2();
            c1.m1();
            c1.m2();

            c2.m1();
            c2.m3();

        }
    }
}
