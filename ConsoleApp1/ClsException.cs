/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ClsException
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter two numbers");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            if (b == 0)
            {
                Console.WriteLine("Second number can not zero");
            }
            else
            {
                c = a / b;
                Console.WriteLine("result is : " + c);
            }
        }
    }
}
*/

/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ClsException
    {
        static void Main(string[] args)
        {
            try
            {
                int a, b, c;
                Console.WriteLine("Enter two numbers");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
                Console.WriteLine("result is : " + c);
            }
            catch
            {
                Console.WriteLine("Something went wrong");
            }
        }
    }
}*/

/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ClsException
    {
        static void Main(string[] args)
        {
            try
            {
                int a, b, c;
                Console.WriteLine("Enter two numbers");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
                Console.WriteLine("result is : " + c);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}*/

/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ClsException
    {
        static void Main(string[] args)
        {
            try
            {
                int a, b, c;
                Console.WriteLine("Enter two numbers");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
                Console.WriteLine("result is : " + c);
            }
            catch (Exception ex)  //Exception is super class which contain all exception handling msg
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}*/

/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ClsException
    {
        static void Main(string[] args)
        {
            try
            {
                int a, b, c;
                Console.WriteLine("Enter two numbers");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
                Console.WriteLine("result is : " + c);
            }
            catch (DivideByZeroException ex)  //Exception is super class which contain all exception handling msg
            {
                Console.WriteLine(ex.Message);
            }
            catch //default catch block should be on last, as well as super class also
            {
                Console.WriteLine("Something went wromg");
            }
        }
    }
}*/

/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{    
    internal class ClsException
    {
        static void Main(string[] args)
        {

            int a = 10;
            int b = 0;
            try
            {
                Console.WriteLine(a/b);
                Console.WriteLine("statement-2");
                Console.WriteLine("statement-3");
            }
            catch(FormatException ex)   //abnormal termination
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("statement-5");
        }
    }
}*/


/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ClsException
    {
        static void Main(string[] args)
        {

            int a = 10;
            int b = 0;
            try
            {
                Console.WriteLine(a / b);
                Console.WriteLine("statement-2");
                Console.WriteLine("statement-3");
            }
            catch (DivideByZeroException ex)   
            {
                Console.WriteLine(a / b); //abnormal termination
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("statement-5");
        }
    }
}*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ClsException
    {
        static void Main(string[] args)
        {
            try
            {

                int a = 10;
                int b = 0;
                Console.WriteLine(a / b);
                Console.WriteLine("try block");
            }
            catch
            {
                Console.WriteLine("catch block");
            }
            finally //finally block always execute whether exception raised or not raised
            {
                Console.WriteLine("final block");
            }
        }
    }
}