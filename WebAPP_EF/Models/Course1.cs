using System;
using System.Collections.Generic;

namespace WebAPP_EF.Models
{
    public partial class Course1
    {
        public Course1()
        {
            Staff = new HashSet<Staff>();
        }

        public int Cid { get; set; }
        public string Cname { get; set; } = null!;
        public int Fees { get; set; }
        public int Duration { get; set; }

        public virtual ICollection<Staff> Staff { get; set; }
    }
}
