using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ClsDelegate1
    {
        public void add(int x, int y)
        {
            Console.WriteLine("sum is : "+ (x+y));
        }
        public void sub(int x, int y)
        {
            Console.WriteLine("sub is : " + (x - y));
        }
        public void mul(int x, int y)
        {
            Console.WriteLine("mul is : " + (x * y));
        }
        public void div(int x, int y)
        {
            Console.WriteLine("div is : " + (x / y));
        }
    }
    //creating delegate
    public delegate void mcdelegate(int x, int y);
    class ClsDelegate2
    {
        static void Main(string[] args)
        {
            ClsDelegate1 obj1  = new ClsDelegate1();
            mcdelegate objd = new mcdelegate(obj1.add);
            objd += obj1.sub;
            objd += obj1.mul;
            objd += obj1.div;

            //invoking a delegfate
            objd(20, 10);

            objd -= obj1.mul;
            objd -= obj1.div;

            objd(50, 30);

        }
    }
}
