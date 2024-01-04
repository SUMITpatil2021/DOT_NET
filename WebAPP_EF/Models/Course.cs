using System;
using System.Collections.Generic;

namespace WebAPP_EF.Models
{
    public partial class Course
    {
        public Course()
        {
            Trainers = new HashSet<Trainer>();
        }

        public string Cid { get; set; } = null!;
        public string Cname { get; set; } = null!;
        public int? Fees { get; set; }

        public virtual ICollection<Trainer> Trainers { get; set; }
    }
}
