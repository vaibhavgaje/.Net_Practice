using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ClsPointer
    {
        static void Main(string[] args)
        {
            int a = 100;
            unsafe  //unsafe block
            {
                int* x = &a;
                Console.WriteLine("Value of a is :"+ *x);
                Console.WriteLine("address of a is:"+ (int)x);
            }
        }
    }
}
