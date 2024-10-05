using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no");
            int i = Convert.ToInt32(Console.ReadLine());
            if (i%2 == 0)
            {
                Console.WriteLine($"{i} is Even");
            }
            else
            {
                Console.WriteLine($"{i} is Odd");
            }
        }
    }
}
