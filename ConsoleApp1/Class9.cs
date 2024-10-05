using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());
            switch(age)
            {
                case 10: Console.WriteLine("Your age is 10");
                    break;
                case 20: Console.WriteLine("Your age is 20");
                    break;
                case 30: Console.WriteLine("Your age is 30");
                    break;
                default: Console.WriteLine("age is not 10 or 20 or 30");
                    break;
            }
        }
    }
}
