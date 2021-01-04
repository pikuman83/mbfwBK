using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Keyless]
    [Table("ACBAL")]
    public partial class Acbal
    {
        [Column("ACODE")]
        [StringLength(10)]
        public string Acode { get; set; }
        [Column("ATYPE")]
        public short? Atype { get; set; }
        [Column("ATPNAME")]
        [StringLength(40)]
        public string Atpname { get; set; }
        [Column("TDEBIT")]
        public double? Tdebit { get; set; }
        [Column("TCREDIT")]
        public double? Tcredit { get; set; }
        [Column("TDEBIT2")]
        public double? Tdebit2 { get; set; }
        [Column("TCREDIT2")]
        public double? Tcredit2 { get; set; }
        [Column("TDEBIT3")]
        public double? Tdebit3 { get; set; }
        [Column("TCREDIT3")]
        public double? Tcredit3 { get; set; }
        [Column("TDEBIT4")]
        public double? Tdebit4 { get; set; }
        [Column("TCREDIT4")]
        public double? Tcredit4 { get; set; }
        [Column("GDNAME")]
        [StringLength(40)]
        public string Gdname { get; set; }
        [Column("DATE", TypeName = "datetime")]
        public DateTime? Date { get; set; }
        [Column("ANAME")]
        [StringLength(60)]
        public string Aname { get; set; }
        [Column("VTYPE")]
        public int? Vtype { get; set; }
        [Column("VORDR")]
        public int? Vordr { get; set; }
        [Column("AMOUNT")]
        public double? Amount { get; set; }
        [Column("SDATE", TypeName = "datetime")]
        public DateTime? Sdate { get; set; }
        [Column("EDATE", TypeName = "datetime")]
        public DateTime? Edate { get; set; }
        [Column("EXP")]
        public double? Exp { get; set; }
        [Column("UACODE")]
        [StringLength(250)]
        public string Uacode { get; set; }
        [Column("UANAME")]
        [StringLength(250)]
        public string Uaname { get; set; }
    }
}
