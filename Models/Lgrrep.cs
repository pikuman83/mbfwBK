using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Keyless]
    [Table("Lgrrep")]
    public partial class Lgrrep
    {
        public int? No { get; set; }
        [Column("VDate", TypeName = "datetime")]
        public DateTime? Vdate { get; set; }
        [Column("ACode")]
        [StringLength(30)]
        public string Acode { get; set; }
        [Column("AName")]
        [StringLength(250)]
        public string Aname { get; set; }
        [StringLength(1000)]
        public string Descr { get; set; }
        [StringLength(3)]
        public string Jo { get; set; }
        public double? Debit { get; set; }
        public double? Credit { get; set; }
        [Column("CACODE")]
        [StringLength(30)]
        public string Cacode { get; set; }
        [Column("CANAME")]
        [StringLength(150)]
        public string Caname { get; set; }
        [Column("PDATE", TypeName = "datetime")]
        public DateTime? Pdate { get; set; }
        [Column("SORD")]
        public int? Sord { get; set; }
        [Column("OPBAL")]
        public double? Opbal { get; set; }
        [Column("FCODE")]
        [StringLength(20)]
        public string Fcode { get; set; }
        [Column("FNAME")]
        [StringLength(150)]
        public string Fname { get; set; }
        [Column("QTY")]
        public double? Qty { get; set; }
        [Column("sdate", TypeName = "datetime")]
        public DateTime? Sdate { get; set; }
        [Column("EDATE", TypeName = "datetime")]
        public DateTime? Edate { get; set; }
        [Column("PYM")]
        public double? Pym { get; set; }
        [Column("BAL")]
        public double? Bal { get; set; }
        [Column("SALE")]
        public double? Sale { get; set; }
        [Column("CHQNO")]
        [StringLength(50)]
        public string Chqno { get; set; }
        [Column("VNO")]
        [StringLength(50)]
        public string Vno { get; set; }
        [Column("OTHERS")]
        public double? Others { get; set; }
        [Column("DASTI")]
        public double? Dasti { get; set; }
        [Column("FREIGHT")]
        public double? Freight { get; set; }
        [Column("CHQ")]
        public double? Chq { get; set; }
        [Column("SNO")]
        public short? Sno { get; set; }
        [Column("TERM")]
        [StringLength(25)]
        public string Term { get; set; }
    }
}
