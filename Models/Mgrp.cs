using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Table("MGRP")]
    public partial class Mgrp
    {
        [Key]
        [Column("GRP")]
        public int Grp { get; set; }
        [Column("GNAME")]
        [StringLength(20)]
        public string Gname { get; set; }
    }
}
