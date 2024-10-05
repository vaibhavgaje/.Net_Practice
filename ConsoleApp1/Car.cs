using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Car
    {
        private string car_name = ""; //default access modifier for data field is private
        private int maxspeed = 0;

       /* private Car()*/
        public Car()
        {
            this.car_name = "Mg astor";
            this.maxspeed = 100;

        }

        /*private void Display()*/
        public void Display()
        {
            Console.WriteLine($"{car_name} car driving with the speed {maxspeed}");
        }
        /*        static void Main(string[] args)
                {
                    Car c = new Car();
                    c.Display();
                    c.maxspeed = 200;
                    c.Display();
                }*/
    }
    class CarAccess    
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.Display();
            /*c.maxspeed = 200;*/ //maxspeed is private which will not accessible for editing, is called encapsulation
            c.Display();
        }
    }

}
