using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SealedClass
    {
    }
    class Class20 : SealedClass
    {

    }
    sealed class Class21 : Class20
    {

    }
/*    class Class22:Class21
    {

    }*/
}
