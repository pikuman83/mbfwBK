using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Table("PGROUP")]
    public partial class Pgroup
    {
        [Key]
        [Column("PGRP")]
        public int Pgrp { get; set; }
        [Column("PGNAME")]
        [StringLength(50)]
        public string Pgname { get; set; }
    }
}
