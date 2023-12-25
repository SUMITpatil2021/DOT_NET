using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class PointTest
    {

        public static void Main1(string[] args)
        {

            Console.WriteLine("Enter X Co-ordinate ");
            int x=int.Parse(Console.ReadLine());    
            Console.WriteLine("Enter y co-ordinate ");
            int y=int.Parse(Console.ReadLine());    
           

            Point p=new Point(x,y);

            p.Display();




        }
    }
}
