using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ClsBoxing
    {
        static void Main(string[] args)
        {
            int i = 10; //normal initialition
            object o = i; //implicit Boxing
            object x = (object)i; // explicit Boxing
            int j = (int)o; //Explicit Unboxing

            Console.WriteLine("Value of i is:"+i);
            Console.WriteLine("Value of O after Implicit Boxing is: "+ o);
            Console.WriteLine("Value of O after Explicit Boxing is: "+ x);
            Console.WriteLine("Value of O after Explicit Unboxing is: "+ j);

        }
    }
}
