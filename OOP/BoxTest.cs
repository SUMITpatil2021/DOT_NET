using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class BoxTest
    {
        public static void Main1(string[] args)
        {
            Console.WriteLine("Enter Height :");
            int h=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Width : ");
            int w=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter depth : ");
            int d=int .Parse(Console.ReadLine());
            Box b=new Box();
            Console.WriteLine("******************Default constructor ****************************");
            Console.WriteLine("Volume:"+b.CalculateVolume());
            Console.WriteLine("*******************Parameterized constructor ****************************");
            Box b1= new Box(h,w,d);
            Console.WriteLine("Volume: "+b1.CalculateVolume()); 
            Console.WriteLine("*******************Copy constructor ****************************");
            Box b2= new Box(b1);
            Console.WriteLine("Volume: "+b2.CalculateVolume());

            

        }
    }
}
