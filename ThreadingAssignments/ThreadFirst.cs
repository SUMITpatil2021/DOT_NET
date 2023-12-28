using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadingAssignments
{
    internal class ThreadFirst
    {
        static void Main1(string[] args)
        {
            Thread t = Thread.CurrentThread;
            t.Name = "Main Thread";
            Console.WriteLine(t.Name);
            Console.WriteLine(t.ThreadState);
            Console.WriteLine(t.Priority);

        }
    }
}
