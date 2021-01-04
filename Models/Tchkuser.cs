using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Keyless]
    [Table("TCHKUSER")]
    public partial class Tchkuser
    {
        [Column("USER")]
        [StringLength(50)]
        public string User { get; set; }
    }
}
