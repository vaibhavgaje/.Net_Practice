using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ClsParent
    {
        public void assets()
        {
            Console.WriteLine("Cash+Gold+Lands");
        }
        public void car()
        {
            Console.WriteLine("alto car");
        }
    }
    class ClsChild:ClsParent
    { 
        public new void car()
        {
            base.car();
            Console.WriteLine("benz car");
        }
    }
    class ClsOverriding
    {
        static void Main(string[] args)
        {
            ClsChild c1 = new ClsChild();
            c1.assets();
            c1.car();
        }
    }
}

