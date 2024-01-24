using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace BlogWebApi.Models
{
    
    public partial class AdminInfo
    {
        [Key]
        public string? EmailId { get; set; }
        
        public string? Password { get; set; }
    }
}
