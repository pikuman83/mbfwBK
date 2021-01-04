using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Table("PRLIST")]
    public partial class Prlist
    {
        [Column("NO")]
        public int? No { get; set; }
        [Column("VDATE", TypeName = "datetime")]
        public DateTime? Vdate { get; set; }
        [Column("VCODE")]
        [StringLength(10)]
        public string Vcode { get; set; }
        [Column("VNAME")]
        [StringLength(50)]
        public string Vname { get; set; }
        [Column("PCODE")]
        [StringLength(10)]
        public string Pcode { get; set; }
        [Column("PNAME")]
        [StringLength(50)]
        public string Pname { get; set; }
        [Column("UNIT")]
        [StringLength(10)]
        public string Unit { get; set; }
        [Column("SRATE")]
        public double? Srate { get; set; }
        [Column("PRATE2")]
        public double? Prate2 { get; set; }
        [Column("SNO")]
        public int? Sno { get; set; }
        [Key]
        [Column("id")]
        public int Id { get; set; }
    }
}
