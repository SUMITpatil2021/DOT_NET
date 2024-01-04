using System;
using System.Collections.Generic;

namespace WebAPI.Models
{
    public partial class EmpView
    {
        public int? Empno { get; set; }
        public string? Ename { get; set; }
        public int? Deptno { get; set; }
        public decimal? Sal { get; set; }
    }
}
