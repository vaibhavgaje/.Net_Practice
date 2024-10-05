using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ClsEnum
    {
        enum level
        {
            Low, Medium, High
        }
        static void Main(string[] args)
        {
            /*            level l = level.High;
                        Console.WriteLine("The level is : "+l);*/
            level l = level.Medium;

            switch(l)
            {
                case level.Low:
                    Console.WriteLine("Low level");
                    break;
                case level.Medium:
                    Console.WriteLine("Medium level");
                    break;
                case level.High:
                    Console.WriteLine("High level");
                    break;
            }
            Console.Read();
        }
    }
}

/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ClsEnum
    {
        enum level
        {
            january,
            february,
            march,
            april,
            may,
            june
        }
        static void Main(string[] args)
        {
*//*            level l = level.march;
            Console.WriteLine("The level is : " + l);*//*
            int m = (int)level.march;
            Console.WriteLine(m);
            Console.Read();
        }
    }
}*/
