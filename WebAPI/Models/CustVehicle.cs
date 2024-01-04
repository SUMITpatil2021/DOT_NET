using System;
using System.Collections.Generic;

namespace WebAPI.Models
{
    public partial class CustVehicle
    {
        public int Tid { get; set; }
        public int Custid { get; set; }
        public int Vid { get; set; }
        public int Sid { get; set; }
        public int BuyPrice { get; set; }
        public int Rating { get; set; }
    }
}
