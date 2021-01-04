using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Keyless]
    [Table("TSTKTRF")]
    public partial class Tstktrf
    {
        [Column("NO")]
        public int? No { get; set; }
        [Column("VDATE", TypeName = "datetime")]
        public DateTime? Vdate { get; set; }
        [Column("PCODE")]
        [StringLength(15)]
        public string Pcode { get; set; }
        [Column("PNAME")]
        [StringLength(50)]
        public string Pname { get; set; }
        [Column("UNIT")]
        [StringLength(10)]
        public string Unit { get; set; }
        [Column("QTY")]
        public double? Qty { get; set; }
        [Column("FGDNAME")]
        [StringLength(100)]
        public string Fgdname { get; set; }
        [Column("TGDNAME")]
        [StringLength(100)]
        public string Tgdname { get; set; }
        [Column("SNO")]
        public int? Sno { get; set; }
        [Column("VNO")]
        [StringLength(15)]
        public string Vno { get; set; }
    }
}
