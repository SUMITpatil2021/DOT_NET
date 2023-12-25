using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class DateDemo
    {
        public static  void Main1(string[] args)
        { 
            Console.WriteLine("Enter Date : ");
            int dd=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Month ");
            int mm=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Year ");
            int yy = int.Parse(Console.ReadLine());

            Date d1= new Date();
            Console.WriteLine("using defalut :"+d1.ShowDate());

            Date d = new Date(dd,mm,yy);

            Console.WriteLine("Using Para.Constructor "+d.ShowDate()); 

            Date d2 = new Date() { dd=20,mm=12,yy=2000};
            Console.WriteLine("using object initialzer with all values "+d2.ShowDate());

            Date d3 = new Date() { dd=24,yy=2001};
            Console.WriteLine("Using Object initializer with 2 values "+d3.ShowDate());




        }
    }
}
