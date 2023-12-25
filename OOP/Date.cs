using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Date
    {
        public int dd,mm,yy;

        public Date()
        {
            dd=21; mm=02; yy=2001;
        }

        public Date(int dd,int mm,int yy)
        {
            this.dd = dd;
            this.mm=mm; 
            this.yy = yy;   
        }


        public int DD
        {
            get { return dd; }
            set { dd = value; }
        }

        public int MM
        {
            get { return mm; }
            set { mm = value; }
        } 
        public int YY
        { get { return yy; } }  
        public override string ToString() {
            return "Date : [ "+dd+" : "+mm+" : "+yy+" ]";
        }
        // public override int GetHashCode() { }

        public String ShowDate()
        {
            return "Date : "+dd+" / "+mm+" / "+yy;
        }

    }
}
