using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAssignments
{
    

    internal class DelegateAss2
    {
        public delegate void DelString(string s);
        public static void main(String[]args)
        {
            //Using Annonyonoumous function 
            DelString d=delegate (string s)
                {
                Console.WriteLine("LowerCase : "+s.ToLower());
                Console.WriteLine("--------------------------------");

                };
            d += delegate (string s)
            {
                Console.WriteLine("UpperCase : " + s.ToUpper());
                Console.WriteLine("--------------------------------");

            };

            d += delegate (string s)
            {
                Console.WriteLine("Message : " + s);
                Console.WriteLine("--------------------------------");
            };

            d("sumit");
        }
    }
}
