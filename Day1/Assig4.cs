using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class Assig4
    {
        public static void Main1(string[] args)
        {
            Console.WriteLine("Enter marks:");
            Console.WriteLine("Enter marks for Maths : ");
            int maths=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter marks for Phy : ");
            int phy=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter marks for Chem : ");
            int chem=int.Parse(Console.ReadLine());

            int totalMarks = maths + phy + chem;

            if (maths >= 65 && phy >= 55 && chem >= 50 && totalMarks >= 180)
            {
                Console.WriteLine(" Congratulations you are  Eligible for this course");
            }
            else
            {
                Console.WriteLine("Bad to inform you that you are not eligible for this course");
            }
        }
    }
}
