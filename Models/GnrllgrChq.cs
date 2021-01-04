using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Keyless]
    [Table("GNRLLGR_CHQS")]
    public partial class GnrllgrChq
    {
        public int? No { get; set; }
        [Column("VDate", TypeName = "datetime")]
        public DateTime? Vdate { get; set; }
        [StringLength(3)]
        public string Jo { get; set; }
        [Column("ACode")]
        [StringLength(15)]
        public string Acode { get; set; }
        [Column("AName")]
        [StringLength(150)]
        public string Aname { get; set; }
        [StringLength(250)]
        public string Descr { get; set; }
        public double? Debit { get; set; }
        public double? Credit { get; set; }
        [Column("PDATE", TypeName = "datetime")]
        public DateTime? Pdate { get; set; }
        [Column("FCODE")]
        [StringLength(10)]
        public string Fcode { get; set; }
        [Column("FNAME")]
        [StringLength(50)]
        public string Fname { get; set; }
        [Column("QTY")]
        public double? Qty { get; set; }
        [Column("POST")]
        public int? Post { get; set; }
        [Column("BNO")]
        [StringLength(50)]
        public string Bno { get; set; }
        [Column("TERM")]
        [StringLength(100)]
        public string Term { get; set; }
        [Column("CHQNO")]
        [StringLength(100)]
        public string Chqno { get; set; }
        [Column("CLRDATE")]
        [StringLength(10)]
        public string Clrdate { get; set; }
        [Column("BRNO")]
        public int? Brno { get; set; }
        [Column("VNO")]
        [StringLength(25)]
        public string Vno { get; set; }
        [Column("SNO")]
        public int? Sno { get; set; }
    }
}
