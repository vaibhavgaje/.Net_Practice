using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleClassLibrary
{
    public class Class2
    {
        public int Square(int x)
        {
            return x * x;
        }
        public int Cube(int x)
        {
            return Square(x) * x;
        }
    }
}
