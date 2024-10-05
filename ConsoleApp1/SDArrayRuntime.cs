using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SDArrayRuntime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the lengtyh of arry");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the array element");
                A[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Elements if array");
            for (int i = 0; i < n; i++)
            {
                Console.Write(A[i] + " ");
            }
        }
    }
}
