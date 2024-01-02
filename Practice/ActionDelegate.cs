using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public delegate void ActionDel(string s);
   

    internal class ActionDelegate
    {
        public static void UpperPrint(string s)
        {
            Console.WriteLine( s.ToUpper());
            Console.WriteLine("--------------------------------");

        }

        public static void LowerPrint(string s)
        {
            Console.WriteLine( s.ToLower());
            Console.WriteLine("--------------------------------");

        }
        public static void Print(string s)
        {
            Console.WriteLine(s);
            Console.WriteLine("--------------------------------");
        }

        static void Main1(string[] args)
        {
            
        ActionDel d = new ActionDel(Print);
       
        Action<string> action = UpperPrint;
            action += LowerPrint;
            action += Print;
            action("SumIt");


        }

    }
}
