using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ArrayMethods 
    {
        static void Main(string[] args)
        {
            int[] A = new int[7] { 10, 20, 30, 40, 50, 60, 70 };
            int[] B = new int[10] { 15, 5, 35, 25, 55, 45, 75, 65, 95, 85 };
            Console.WriteLine("Elements of Array A");
            foreach (int i in A)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine("\n Elements of Array B");
            foreach (int i in B) 
            {
                Console.Write(i + " ");
            }
            //A.CopyTo(B, 2);
            //Array.Copy(A, B, 4);
            //Array.Copy(A, 2, B, 5, 4);
            //Array.Sort(B);
            /*            Array.Sort(B, 3, 4);
                        Console.WriteLine("\n Elements of Array B after sorting");
                        foreach (int i in B)
                        {
                            Console.Write(i + " ");
                        }*/
            //Array.Reverse(A);
            /*            Array.Reverse(A, 2 , 4);
                        Console.WriteLine("\n Elements of Array A after reverse");
                        foreach (int i in A)
                        {
                            Console.Write(i + " ");
                        }*/
            /*            Array.Reverse(B);
                        Console.WriteLine("\n Elements of Array B after reverse");
                        foreach (int i in B)
                        {
                            Console.Write(i + " ");
                        }*/
            Array.Clear(A);
            //Array.Clear(A, 2, 4);
            Console.WriteLine("\n Elements of Array A after clear");
            foreach (int i in A)
            {
                Console.Write(i + " ");
            }
        }
    }
}
