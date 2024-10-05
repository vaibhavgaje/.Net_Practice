using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class16
    {
        static void Main(string[] args)
        {
            int i = 1;
        loop:
            i++;
            if(i<100)
            {
                Console.Write(i + " ");
                goto loop;
            }
        }
    }
}
