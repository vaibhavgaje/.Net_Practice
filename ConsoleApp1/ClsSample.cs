/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ClsSample
    {
        int i;
        static int j;
        public ClsSample()
        {
            i = 100;
        }
        static ClsSample()
        {
            j = 100;
        }
        public void Display()
        {
            Console.WriteLine($"Value of i is:{i}");
            i++;
            Console.WriteLine($"Value of j is:{j}");
            j++;
        }
    }
    class ClsStaticConstructor
    {
        static void Main(string[] args)
        {
            ClsSample obj1 = new ClsSample();
            obj1.Display();

            ClsSample obj2 = new ClsSample();
            obj2.Display();

            ClsSample obj3 = new ClsSample();
            obj3.Display();
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
    internal class ClsSample
    {
        int i;
        static int j;
        public ClsSample()
        {
            i = 100;
        }
        static ClsSample()
        {
            j = 100;
        }
        public void Display()
        {
            Console.WriteLine($"Value of i display 1 is:{i}");
            i++;
            Console.WriteLine($"Value of j display 1 is:{j}");
            j++;
        }
        public void Display2()
        {
            Console.WriteLine($"Value of i display 2 is:{i}");
            i++;
            Console.WriteLine($"Value of j display 2 is:{j}");
            j++;
        }

        static void Main(string[] args)
        {
            ClsSample obj1 = new ClsSample();
            obj1.Display();
            obj1.Display2();


            ClsSample obj2 = new ClsSample();
            obj2.Display();
            obj2.Display2();

        }

    }
    /*    class ClsStaticConstructor
        {
            static void Main(string[] args)
            {
                ClsSample obj1 = new ClsSample();
                obj1.Display();

                ClsSample obj2 = new ClsSample();
                obj2.Display();

                ClsSample obj3 = new ClsSample();
                obj3.Display();
            }
        }*/
}
