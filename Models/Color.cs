using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Table("COLOR")]
    public partial class Color
    {
        [Key]
        [Column("GRP")]
        public int Grp { get; set; }
        [Required]
        [Column("GNAME")]
        [StringLength(100)]
        public string Gname { get; set; }
        [Column("UCOLOR")]
        [StringLength(100)]
        public string Ucolor { get; set; }
    }
}
