using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAssignments
{
    public delegate void  DelString(string s);
    internal class DelegateAss1
    {
        public static void  Upper(string s)
        {
            Console.WriteLine("UpperCase  : "+s.ToUpper());
            Console.WriteLine("--------------------------------");

        }

        public static void Lower(string s)
        {
            Console.WriteLine("LowerCase : "+s.ToLower());
            Console.WriteLine("--------------------------------");
        }

        public static void Print(string s  )
        {
            Console.WriteLine(s);
            Console.WriteLine("--------------------------------");
        }
        public static void Main1(string[] args)
        {
            DelString d1 = new DelString(Print);

            /* Using Multicast Delegates  
              
             d1 += Lower;
             d1 += Upper;
             d1("Sumit"); */
             
        // using Action
        
            Action<string> action = Upper;
            action += Lower;
            action += Print; 
            action("Developer");


        }
    }
}
