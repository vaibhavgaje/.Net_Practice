using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class11
    {
        static void Main(string[] args)
        {
            /*for (int i = 1; i <= 10; i++)
            {
                if(i == 5 || i == 8)
                    continue;
                Console.Write(i + " ");
            }*/
            for (int i = 1; i <= 100; i++)
            {
                if(i % 2 != 0)
                    continue;
                Console.Write(i + " ");
            }
        }
    }
}
