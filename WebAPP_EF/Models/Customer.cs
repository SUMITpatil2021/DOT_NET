using System;
using System.Collections.Generic;

namespace WebAPP_EF.Models
{
    public partial class Customer
    {
        public int Custid { get; set; }
        public string? Cname { get; set; }
        public string? Location { get; set; }
    }
}
