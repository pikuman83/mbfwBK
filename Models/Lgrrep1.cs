using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Keyless]
    [Table("Lgrrep1")]
    public partial class Lgrrep1
    {
        public int? No { get; set; }
        [Column("VDate", TypeName = "datetime")]
        public DateTime? Vdate { get; set; }
        [Column("ACode")]
        [StringLength(25)]
        public string Acode { get; set; }
        [Column("AName")]
        [StringLength(150)]
        public string Aname { get; set; }
        [StringLength(250)]
        public string Descr { get; set; }
        [StringLength(3)]
        public string Jo { get; set; }
        public double? Debit { get; set; }
        public double? Credit { get; set; }
        [Column("CACODE")]
        [StringLength(25)]
        public string Cacode { get; set; }
        [Column("CANAME")]
        [StringLength(150)]
        public string Caname { get; set; }
        [Column("PDATE", TypeName = "datetime")]
        public DateTime? Pdate { get; set; }
        [Column("OPBAL")]
        public double? Opbal { get; set; }
        [Column("inv")]
        [StringLength(20)]
        public string Inv { get; set; }
        [Column("CHQNO")]
        [StringLength(100)]
        public string Chqno { get; set; }
        [Column("CLRDT", TypeName = "datetime")]
        public DateTime? Clrdt { get; set; }
        [Column("PARTY")]
        [StringLength(150)]
        public string Party { get; set; }
    }
}
