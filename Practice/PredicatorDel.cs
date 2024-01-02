using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
   
    internal class PredicatorDel
    {
        public static bool isPositive(int no)
        {
            return (no > 0);
        }

        static void Main(string[] args)
        {
            Predicate<int> pr = isPositive;
            Console.WriteLine(pr(10));

            pr += delegate (int no)
            {
                return no < 0;
            };
            Console.WriteLine(pr(20));

            pr += (a) => { return a % 2 == 0; };
            Console.WriteLine(pr(30));
        }
    }
}
