using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionAssignment
{
    internal class StringBuilderAss
    {
        static void Main1(string[] args)
        {
            Type t= typeof(StringBuilder);
           // Console.WriteLine("Constructors : "+t.GetConstructors());
            Console.WriteLine("Properties : "+t.GetProperties());   
            Console.WriteLine("Custom Attributes "+t.GetCustomAttributes(true));
            Console.WriteLine("Methods : "+t.GetMethods());
            Console.WriteLine("Name:" + t.Name);
            Console.WriteLine("Full NAme : " + t.FullName);
            Console.WriteLine("Base Type : " + t.BaseType); 
            Console.WriteLine("Assembly : "+t.Assembly);
            Console.WriteLine("-------------------Constructors -----------------------");
            foreach(var i in t.GetConstructors ())
            {
                Console.WriteLine(i);
            }

        }
    }
}
