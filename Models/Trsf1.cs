using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Keyless]
    [Table("TRSF1")]
    public partial class Trsf1
    {
        [Column("NO")]
        public int No { get; set; }
        [Column("VDATE", TypeName = "datetime")]
        public DateTime? Vdate { get; set; }
        [Column("VNO")]
        [StringLength(15)]
        public string Vno { get; set; }
        [Column("FGDN")]
        public int? Fgdn { get; set; }
        [Column("FGDNAME")]
        [StringLength(100)]
        public string Fgdname { get; set; }
        [Column("TGDN")]
        public int? Tgdn { get; set; }
        [Column("TGDNAME")]
        [StringLength(100)]
        public string Tgdname { get; set; }
        [Column("TQTY")]
        public double? Tqty { get; set; }
        [Column("TOTAL")]
        public double? Total { get; set; }
        [Column("EUSER")]
        [StringLength(25)]
        public string Euser { get; set; }
        [Column("EDATE", TypeName = "datetime")]
        public DateTime? Edate { get; set; }
    }
}
