using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Calculator
    {
        internal int MulRegular(int a, int b, int c)
        {
            return (a * b * c);
        }

        public int MulOptonal(int a,int b, int c=0)
        {
            return (a * b * c);
        }

        public int MulParams(params int[] a)
        {
            int mul = 1;
            foreach (var i in a)
            {
               
                mul *= i;    
            }
            return mul;
        }
    }
    internal class Example
    {
        public static void Main1(string[] args)
        {
            Console.WriteLine("Enter first number ");
            int a=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number : ");
            int b=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number ");
            int c=int.Parse(Console.ReadLine()); 
            Calculator c1=new Calculator();
            Console.WriteLine("Multiplication : "+c1.MulRegular(a,b,c));

            Console.WriteLine("Multiplication : " + c1.MulOptonal(a, b));

            Console.WriteLine("Multiplication : " + c1.MulOptonal(b=2,c=3,a=2));

            Console.WriteLine("multiplication params : "+c1.MulParams(1,2,3,4,5));


        }
    }
}
