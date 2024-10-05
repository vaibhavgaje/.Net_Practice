using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal partial class ClassPartial
    {
        partial void m1();
        partial void m1()
        {
            Console.WriteLine("partial method m1");
        }
        public void m2()
        {
            Console.WriteLine("non partial method m2");
            m1();
        }
       
    }
    class ClassSamplePartial
    {
        static void Main(string[] args)
        {
            ClassPartial obj1 = new ClassPartial();
            obj1.m2();
            Console.Read();
        }
    }
}
