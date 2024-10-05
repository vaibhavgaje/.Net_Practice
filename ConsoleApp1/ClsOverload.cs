using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//static polymorphism means function/method overloading

namespace ConsoleApp1
{
    internal class ClsOverload
    {
        /*private void Add(int a, int b)
        {
            Console.WriteLine($"sum is:{a+b}");
        }
        private void Add(float a, int b)  
        {
            Console.WriteLine($"sum is:{a + b}");
        }
        private void Add(int a, int b, int c)
        {
            Console.WriteLine($"sum is:{a + b+c}");
        }
        static void Main(string[] args)
        {
            ClsOverload obj1 = new ClsOverload(); 
            obj1.Add(10,20);
            obj1.Add(10.5f,20);
            obj1.Add(10, 20, 30);
        }*/
        //all static methods are non-instance methods
       /* static void Add(int a, int b)
        {
            Console.WriteLine($"sum is:{a + b}");
        }
        static void Add(float a, int b)
        {
            Console.WriteLine($"sum is:{a + b}");
        }
        static void Add(int a, int b, int c)
        {
            Console.WriteLine($"sum is:{a + b + c}");
        }
        static void Main(string[] args)
        {
            Add(10, 20);
            Add(10.5f, 20);
            Add(10, 20, 30);
        }*/
        static int Add(int a, int b)
        {
            return a + b;
        }
        static float Add(float a, int b)
        {
            return a + b;
        }
        static int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        static void Main(string[] args)
        {
            int c = Add(10, 20);
            Console.WriteLine("Sum is: "+c);
            float d = Add(10.5f, 20);
            Console.WriteLine("Sum is: " + d);
            int e = Add(10, 20, 30);
            Console.WriteLine("Sum is: " + e);
            Console.WriteLine("All sum : "+(c+d+e));
        }
    }
}
