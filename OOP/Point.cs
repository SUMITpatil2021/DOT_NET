using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Point
    {
        private int x;
        private int y;

        public Point()
        {
            x= 0; y = 0;    
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }

        public void Display()
        {
            Console.WriteLine("[ "+x+" , "+y+" ]");
        }

    }
}
