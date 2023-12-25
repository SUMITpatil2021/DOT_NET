using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class IndexerExample
    {
        int[] arr = new int[10];
        public int this[int index]
        {
            get { return arr[index]; }
            set { arr[index] = value; }
        }

        public void Display()
        {
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }

    public class IndexerDemo
    {
        public static  void Main(string[] args)
        {
            IndexerExample e = new IndexerExample();
            int i = 0;
            for (i = 0; i < 10; i++)
            {
                e[i] = i;
            }
            e.Display();    
        }
        
    }


}
