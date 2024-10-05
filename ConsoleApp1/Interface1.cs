/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal interface Interface1
    {
        public void m1();
    }
    interface Interface2  //default acceess modifier for interface is internal
    {
        public void m1();
    }
    class C:Interface1, Interface2
    {
        public void m1()
        {
            Console.WriteLine("implementation of m1 for Interface1 and Interface2");
        }
    }
    class ClsInterface1
    {
        static void Main(string[] args)
        {
            C obj1 = new C();
            obj1.m1();
        }
    }
}
*/
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal interface Interface1
    {
        public void m1();
    }
    interface Interface2  //default acceess modifier for interface is internal
    {
        public void m2();
    }
    class C : Interface1, Interface2
    {
        public void m1()
        {
            Console.WriteLine("implementation of m1 for Interface1");
        }
        public void m2()
        {
            Console.WriteLine("implementation of m2 for Interface2");
        }
    }
    class ClsInterface1
    {
        static void Main(string[] args)
        {
            C obj1 = new C();
            obj1.m1();
            obj1.m2();
        }
    }
}*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal interface Interface1
    {
        public void m1();
    }
    interface Interface2  //default acceess modifier for interface is internal
    {
        public void m1();
    }
    class C : Interface1, Interface2
    {
        void Interface1.m1() //by default interface are public and abstract so no need to use public
        {
            Console.WriteLine("implementation of m1 for Interface1");
        }
        void Interface2.m1()
        {
            Console.WriteLine("implementation of m1 for Interface2");
        }
    }
    class ClsInterface1
    {
        static void Main(string[] args)
        {
            C obj1 = new C();
         //   Interface1 i1 = obj1;  //Explicitely creating object for interface to avoid ambeguity
         //   Interface2 i2 = obj1;
            Interface1 i1 = (Interface1)obj1;
            Interface2 i2 = (Interface2)obj1;
            i1.m1();
            i2.m1();
        }
    }
}