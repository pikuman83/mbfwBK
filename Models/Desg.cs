using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Keyless]
    [Table("Desg")]
    public partial class Desg
    {
        [Column("DCode")]
        [StringLength(3)]
        public string Dcode { get; set; }
        [Column("DName")]
        [StringLength(30)]
        public string Dname { get; set; }
    }
}
