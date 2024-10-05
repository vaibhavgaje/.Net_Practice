using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class12
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            int n = Convert.ToInt32(Console.ReadLine());
            int s = 0;
            for(int i=1; i<=n; i++)
            {
                s += i;
            }
            Console.WriteLine($"Sum of {n} is : {s} ");
        }
    }
}
