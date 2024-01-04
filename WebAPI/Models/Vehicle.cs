using System;
using System.Collections.Generic;

namespace WebAPI.Models
{
    public partial class Vehicle
    {
        public int Vid { get; set; }
        public string? Vname { get; set; }
        public int? Price { get; set; }
        public int? Discount { get; set; }
        public int? Milage { get; set; }
        public string? Details { get; set; }
    }
}
