using SampleClassLibrary;

namespace ConsoleAppForConsumeDLL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 obj1 = new Class1();
            Class2 obj2 = new Class2();

            Console.WriteLine("Enter two numbers");
            obj1.PNum1 = Convert.ToInt32(Console.ReadLine());  
            obj1.PNum2 = Convert.ToInt32(Console.ReadLine());

            obj1.Add();
            Console.WriteLine("The sum is : " + obj1.PResult);

            obj1.Sub();
            Console.WriteLine("The sub is : " + obj1.PResult);

            obj1.Mul();
            Console.WriteLine("The mul is : " + obj1.PResult);

            obj1.Div();
            Console.WriteLine("The div is : " + obj1.PResult);

            Console.WriteLine("Enter any number");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The square is : " + obj2.Square(n));
            Console.WriteLine("The cube is : " + obj2.Cube(n));
        }
    }
}
