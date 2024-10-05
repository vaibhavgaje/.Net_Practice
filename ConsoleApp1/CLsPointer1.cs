using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal unsafe class CLsPointer1
    {

        static void square(int* x)
        {
            Console.WriteLine("square is : " + *x * *x);
        }
        static void cube(int* x)
        {
            Console.WriteLine("cube is : " + *x * *x * *x);
        }
        static void Main(string[] args)
        {
            int a = 5;
            square(&a);  //&a is address of a which is passing to x, to get value *x should take
            cube(&a);
        }
    }
}
