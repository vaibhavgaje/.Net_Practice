using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class14
    {
        static void Main(string[] args)
        {
            int i = 1;
            while(i <= 10)
            {
                          
                if(i == 5)
                {
                    i++;
                    continue;                    
                }
                Console.Write(i + " ");
                i++;
            }
        }
    }
}
