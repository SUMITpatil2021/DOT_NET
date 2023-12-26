using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Exceptions
{
    internal class ArrayAss
    {
        public static void Main1(string[] args)
        {

            Console.WriteLine("Enter Size for array : ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            try
            {
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine("Enter Element at  " + i + " position : ");
                    arr[i] = int.Parse(Console.ReadLine());                   
                }
                Console.WriteLine("Enter elements index number to be searched : ");
                int index=int.Parse(Console.ReadLine());

                Console.WriteLine("element at "+index+" is " + arr[index]);         
            }
            catch (SystemException e)
            {
                Console.WriteLine(e.Message);
            }

        }

    }
}
