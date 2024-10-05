using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ClsEmp
    {
        int id;
        string name;
        double salary;
        string address;

        public ClsEmp(int id, string name, double salary, string address)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;                
            this.address = address;
        }
        public object this[int index]  //object is the returntype, its advantage is it will store any type of data
        {
            get
            {
                if (index == 0)
                    return id;
                else if (index == 1)
                    return name;
                else if (index == 2)
                    return salary;
                else if (index == 3)
                    return address;
                return null;
            }
            set
            {
                if(index == 0)
                    id = (int) value;
                else if (index == 1)
                    name = (string) value;
                else if (index == 2)
                    salary = (double) value;
                else if (index == 3)
                    address = (string) value;

            }
        }
    }
}
