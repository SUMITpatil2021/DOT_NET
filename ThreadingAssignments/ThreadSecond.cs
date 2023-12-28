using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadingAssignments
{
    internal class ThreadSecond
    {
        static void Main1(string[] args)
        {
            Thread t = new Thread(Print);
            t.Start();

        }
        static void Print()
        {
            for(int i=1;i<=5;i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(500);
            }
        }
    }
}
