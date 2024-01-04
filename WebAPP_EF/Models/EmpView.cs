using System;
using System.Collections.Generic;

namespace WebAPP_EF.Models
{
    public partial class EmpView
    {
        public int? Empno { get; set; }
        public string? Ename { get; set; }
        public int? Deptno { get; set; }
        public decimal? Sal { get; set; }
    }
}
