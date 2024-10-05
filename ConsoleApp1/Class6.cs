using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class6
    {
        static void Main(string[] args)
        {
            int i = 100;
            char c = 'a';
            float f = 21.4f;
            double d = 45.67;
            string s = "Vaibhav";
            long l = 5410545612;
            bool b = true;
            Console.WriteLine(i+"........."+sizeof(int));
            Console.WriteLine(c + "........." + sizeof(char));
            Console.WriteLine(f + "........." + sizeof(float));
            Console.WriteLine(d + "........." + sizeof(double));
            Console.WriteLine(s);
            Console.WriteLine(l + "........." + sizeof(long));
            Console.WriteLine(b + "........." + sizeof(bool)); 

        }
    }
}
