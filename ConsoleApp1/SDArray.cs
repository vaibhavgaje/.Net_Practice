﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SDArray
    {
        static void Main(string[] args)
        {
            /*            int[] A = new int[4];
                        A[0] = 10;
                        A[1] = 20;
                        A[2] = 30;
                        A[3] = 40;

                        Console.WriteLine("Elements of array A are:");
                        Console.WriteLine(A[0]);
                        Console.WriteLine(A[1]);
                        Console.WriteLine(A[2]);
                        Console.WriteLine(A[3]);*/

            //int[] A = new int[4] { 10, 20, 30, 40 };
            string[] A = new string[4] {"sai", "vaibhav", "varun", "rashmi"};

            //for(int i = 0; i < A.Length; i++)
            //{
            //    Console.Write(A[i]+" ");

            //}

            foreach (string s in A)
            {
                Console.Write(s+" ");
            }
            Console.WriteLine("Length is: "+A.Length);
            Console.WriteLine("Rank is: "+A.Rank);
        }
    }
}
