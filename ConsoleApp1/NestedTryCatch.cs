/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class NestedTryCatch
    {
        static void Main(string[] args)
        {
            try
            {
*//*                int a = 10;
                int b = 0;
                Console.WriteLine(a/b);*//*
                Console.WriteLine("Outer try");
                try
                {
                    int a = 10;
                    int b = 0;
                    Console.WriteLine(a / b);
                    Console.WriteLine("inner try");
                }
                catch
                {
                    Console.WriteLine("inner catch");
                }
                finally
                {
                    Console.WriteLine("inner finally");
                }
            }
            catch
            {
                Console.WriteLine("outer catch");
            }
            finally
            {
                Console.WriteLine("outer finally");
            }
        }
    }
}
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class NestedTryCatch
    {
        static void Main(string[] args)
        {
            try
            {
                /*                int a = 10;
                                int b = 0;
                                Console.WriteLine(a/b);*/
                Console.WriteLine("Outer try");
                try
                {
                    int a = 10;
                    int b = 0;
                    Console.WriteLine(a / b);
                    Console.WriteLine("inner try");
                }
                catch(FormatException msg)  //this catch block not execute so outer catch will execute here
                {
                    Console.WriteLine("inner catch");
                }
                finally
                {
                    Console.WriteLine("inner finally");
                }
            }
            catch
            {
                Console.WriteLine("outer catch");
            }
            finally
            {
                Console.WriteLine("outer finally");
            }
        }
    }
}
