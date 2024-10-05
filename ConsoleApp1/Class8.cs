using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three number");
            int i = Convert.ToInt32(Console.ReadLine());
            int j = Convert.ToInt32(Console.ReadLine());
            int k = Convert.ToInt32(Console.ReadLine());
            if (i > j & i > k)
            {
                Console.WriteLine($"{i} is big");
            }
            else if (j > k)
            {
                Console.WriteLine($"{j} is big");
            }
            else
            {
                Console.WriteLine($"{k} is big");
            }
        }
    }
}
