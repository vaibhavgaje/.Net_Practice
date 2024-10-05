using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ClsProperty1
    {
        static void Main(string[] args)
        {
            ClsArithmetic obj1 = new ClsArithmetic();
            Console.WriteLine("Enter two number");
            obj1.PNum1 = Convert.ToInt32(Console.ReadLine());
            obj1.PNum2 = Convert.ToInt32(Console.ReadLine());
            obj1.Add();
            Console.WriteLine("Sum is : "+obj1.PResult);
            obj1.Sub();
            Console.WriteLine("Sub is : " + obj1.PResult);
            obj1.Mul();
            Console.WriteLine("Mul is : " + obj1.PResult);
            obj1.Div();
            Console.WriteLine("Div is : " + obj1.PResult);
        }
    }
}
