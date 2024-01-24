using System;
using System.Collections.Generic;

namespace BlogWebApi.Models
{
    public partial class EmpInfo
    {
        public string EmailId { get; set; } = null!;
        public string? Name { get; set; }
        public DateTime? DatOfJoining { get; set; }
        public int? PassCode { get; set; }
    }
}
