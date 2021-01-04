using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Table("LOCATION")]
    public partial class Location
    {
        [Key]
        [Column("GCODE")]
        public int Gcode { get; set; }
        [Column("GNAME")]
        [StringLength(50)]
        public string Gname { get; set; }
    }
}
