using System;
using System.Collections.Generic;

namespace BlogSpot.Models
{
    public partial class EmpInfo
    {
        public EmpInfo()
        {
            BlogInfos = new HashSet<BlogInfo>();
        }

        public string EmailId { get; set; } = null!;
        public string? Name { get; set; }
        public DateTime? DatOfJoining { get; set; }
        public int? PassCode { get; set; }

        public virtual ICollection<BlogInfo> BlogInfos { get; set; }
    }
}
