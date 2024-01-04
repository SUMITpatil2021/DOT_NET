using System;
using System.Collections.Generic;

namespace WebAPI.Models
{
    public partial class Employee
    {
        public int? Eno { get; set; }
        public string? Ename { get; set; }
        public int? Sal { get; set; }
        public DateOnly? Hiredate { get; set; }
    }
}
