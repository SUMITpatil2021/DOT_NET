using System;
using System.Collections.Generic;

namespace WebAPI.Models
{
    public partial class staff
    {
        public string Tid { get; set; } = null!;
        public string Tname { get; set; } = null!;
        public int? Cid { get; set; }
        public int? Sal { get; set; }
        public float? Incentive { get; set; }
        public string? Email { get; set; }

        public virtual Course1? CidNavigation { get; set; }
    }
}
