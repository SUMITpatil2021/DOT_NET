﻿using System;
using System.Collections.Generic;

namespace WebAPP_EF.Models
{
    public partial class Emptmp
    {
        public int? Empno { get; set; }
        public string? Ename { get; set; }
        public string? Job { get; set; }
        public int? Mgr { get; set; }
        public DateOnly? Hiredate { get; set; }
        public decimal? Sal { get; set; }
        public decimal? Comm { get; set; }
        public int? Deptno { get; set; }
    }
}
