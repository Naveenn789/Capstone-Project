using System;
using System.Collections.Generic;

namespace BlogSpot.Models
{
    public partial class AdminInfo
    {
        public string EmailId { get; set; } = null!;
        public string? Password { get; set; }
    }
}
