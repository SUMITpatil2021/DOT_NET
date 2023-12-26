﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAssignment
{
    internal class ArrayException
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter Size for array : ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            try
            {
                for (int i = 0; i <= size; i++)
                {
                    Console.WriteLine("Enter Element at  " + i + " position : ");
                    int element = int.Parse(Console.ReadLine());
                    arr[i] = element;
                }

                foreach (var i in arr)
                {

                    Console.WriteLine(i);

                }
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }

        }
    }
}
