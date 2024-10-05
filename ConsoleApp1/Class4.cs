using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class4
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Int32.MaxValue);
            Console.WriteLine(Int32.MinValue);
            int a, b, c;
            Console.WriteLine("Enter two numbers");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = a + b;
            Console.WriteLine("sum is: " + c);
            Console.Read();
/*            float a, b, c;
            Console.WriteLine("Enter two numbers");
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            c = a + b;
            Console.WriteLine("sum is: " + c);
            Console.Read();*/
        }
    }
}
