using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class funcDelegate
    {
        public string UpperPrint(string s)
        {
            return s.ToUpper();
        }

        public string LowerPrint(string s)
        {
            return s.ToLower();
        }

        public static void Main1(string[] args)
        {
            funcDelegate obj = new funcDelegate();


            Func<string, string> func = obj.UpperPrint;
            Console.WriteLine("-----UpperPrint------");
            Console.WriteLine(func("Sumit"));

            Func<string, string> fun2 = obj.LowerPrint; 
            Console.WriteLine("-----LowerPrint------");
            Console.WriteLine(fun2("SUMIT"));


        }
    }
}
