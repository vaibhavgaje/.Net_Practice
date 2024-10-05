using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class TwoDArrayRuntime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the row size");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the column size");
            int c = Convert.ToInt32(Console.ReadLine());

            int[,] A = new int[r, c];
            Console.WriteLine($"Enter {r * c} elements");

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.WriteLine("Enter the array element");
                    A[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Elements of array are:");
            for(int i = 0;i < r; i++)
            {
                for(int j = 0;j < c; j++)
                {
                    Console.Write(A[i,j]+ " ");
                }
                Console.WriteLine();
            }

        }
    }
}
