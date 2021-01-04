using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Keyless]
    [Table("BALREP")]
    public partial class Balrep
    {
        [Column("ACODE")]
        [StringLength(25)]
        public string Acode { get; set; }
        [Column("ANAME")]
        [StringLength(150)]
        public string Aname { get; set; }
        [Column("DEBIT")]
        public double? Debit { get; set; }
        [Column("CREDIT")]
        public double? Credit { get; set; }
        [Column("BALN")]
        public double? Baln { get; set; }
        [Column("QTY")]
        public double? Qty { get; set; }
        [Column("VDATE", TypeName = "datetime")]
        public DateTime? Vdate { get; set; }
        [Column("JO")]
        [StringLength(5)]
        public string Jo { get; set; }
        [Column("NO")]
        public int? No { get; set; }
        [Column("DESCR")]
        [StringLength(250)]
        public string Descr { get; set; }
        [Column("CHQNO")]
        [StringLength(50)]
        public string Chqno { get; set; }
        [Column("DD", TypeName = "datetime")]
        public DateTime? Dd { get; set; }
        [Column("GRUP")]
        [StringLength(150)]
        public string Grup { get; set; }
    }
}
