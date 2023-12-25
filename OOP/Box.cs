using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Box
    {
        private int height;
        private int width;
        private int depth;
        public Box() {
            height = 1;
            width = 1;
            depth = 1;
        }

        public Box(int height, int width,int depth)
        {
            this.height = height;
            this.width = width;
            this.depth = depth;  
        }

        public Box(Box b)
        {
            this.height=b.height;
            this.width=b.width; 
            this.depth=b.depth;
        }

        public int Height { get; set; }
        public int Width { get; set; }
        public int Depth { get; set; }  

        public int CalculateVolume()
        { 
        
        return height * width*depth;
        
        }
}
}
