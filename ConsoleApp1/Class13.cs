using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class13
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n}*{i}={n * i}");
            }
        }
    }
}
