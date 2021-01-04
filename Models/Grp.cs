using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Table("GRP")]
    public partial class Grp
    {
        [Key]
        [Column("GRP")]
        public int Grp1 { get; set; }
        [Column("GNAME")]
        [StringLength(100)]
        public string Gname { get; set; }
    }
}
