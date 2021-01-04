using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Table("GPRICE")]
    public partial class Gprice
    {
        [Column("no")]
        public int? No { get; set; }
        [Column("VDATE", TypeName = "datetime")]
        public DateTime? Vdate { get; set; }
        [Column("PCODE")]
        [StringLength(10)]
        public string Pcode { get; set; }
        [Column("PNAME")]
        [StringLength(50)]
        public string Pname { get; set; }
        [Column("UNIT")]
        [StringLength(10)]
        public string Unit { get; set; }
        [Column("PRATE")]
        public double? Prate { get; set; }
        [Column("SRATE")]
        public double? Srate { get; set; }
        [Column("sno")]
        public int? Sno { get; set; }
        [Key]
        [Column("id")]
        public int Id { get; set; }
    }
}
