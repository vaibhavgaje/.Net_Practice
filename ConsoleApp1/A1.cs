/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class A1
    {
        public void m1()
        {
            Console.WriteLine("m1 method of A1 class");
        }
    }
    class B1:A1
    {
        public void m2()
        {
            Console.WriteLine("m2 method of B1 class");
        }
    }
    interface C1 : A1   //Interface can not inheritate from class thats why diamond shape proble exist in C# so we can not implement hybrid inheritance in C#
    {
        public void m3();
    }
    class D1:B1, C1
    {
        public void m3()
        {
            Console.WriteLine("m3 method of C1 class");
        }
    }
} 
*/