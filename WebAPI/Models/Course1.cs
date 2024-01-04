using System;
using System.Collections.Generic;

namespace WebAPI.Models
{
    public partial class Course1
    {
        public Course1()
        {
            staff = new HashSet<staff>();
        }

        public int Cid { get; set; }
        public string Cname { get; set; } = null!;
        public int Fees { get; set; }
        public int Duration { get; set; }

        public virtual ICollection<staff> staff { get; set; }
    }
}
