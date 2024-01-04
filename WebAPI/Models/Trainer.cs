using System;
using System.Collections.Generic;

namespace WebAPI.Models
{
    public partial class Trainer
    {
        public string Tid { get; set; } = null!;
        public string? Tname { get; set; }
        public string? Cid { get; set; }
        public int? Salary { get; set; }
        public int? Experience { get; set; }

        public virtual Course? CidNavigation { get; set; }
    }
}
