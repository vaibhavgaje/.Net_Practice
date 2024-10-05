using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ClsDelegate
    {
        public void display(string s)
        {
            Console.WriteLine("Value is : "+s);
        }
        //creating a delegate
        public delegate void mydelegate(string s) ;
        static void Main(string[] args)
        { 
            ClsDelegate obj1 = new ClsDelegate();
            //instantiating as delegate
            mydelegate objd = new mydelegate(obj1.display);
            objd("Pune");
        }
    }
}
