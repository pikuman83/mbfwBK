using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Keyless]
    [Table("PRDBAL")]
    public partial class Prdbal
    {
        [Column("PCODE")]
        [StringLength(10)]
        public string Pcode { get; set; }
        [Column("PNAME")]
        [StringLength(40)]
        public string Pname { get; set; }
        [Column("UNIT")]
        [StringLength(10)]
        public string Unit { get; set; }
        [Column("PTYPE")]
        public int? Ptype { get; set; }
        [Column("PTPNAME")]
        [StringLength(30)]
        public string Ptpname { get; set; }
        [Column("QTY")]
        public double? Qty { get; set; }
        [Column("AMOUNT")]
        public double? Amount { get; set; }
        [Column("GRP")]
        [StringLength(25)]
        public string Grp { get; set; }
        [Column("COLOR")]
        [StringLength(25)]
        public string Color { get; set; }
        [Column("ART")]
        [StringLength(25)]
        public string Art { get; set; }
        [Column("SIZE")]
        [StringLength(25)]
        public string Size { get; set; }
        [Column("PURAVG")]
        public double? Puravg { get; set; }
        public double? Q1 { get; set; }
        public double? Q2 { get; set; }
        public double? Q3 { get; set; }
        public double? Q4 { get; set; }
        public double? Q5 { get; set; }
        public double? Q6 { get; set; }
        public double? Q7 { get; set; }
        [Column("VCODE")]
        [StringLength(10)]
        public string Vcode { get; set; }
        [Column("VNAME")]
        [StringLength(50)]
        public string Vname { get; set; }
        [Column("GDCODE")]
        [StringLength(10)]
        public string Gdcode { get; set; }
        [Column("GDNAME")]
        [StringLength(150)]
        public string Gdname { get; set; }
        [Column("LDATE", TypeName = "datetime")]
        public DateTime? Ldate { get; set; }
        [Column("VDATE", TypeName = "datetime")]
        public DateTime? Vdate { get; set; }
        [Column("SALES")]
        public double? Sales { get; set; }
        [Column("CQ1")]
        public double? Cq1 { get; set; }
        [Column("CQ2")]
        public double? Cq2 { get; set; }
        [Column("CQ3")]
        public double? Cq3 { get; set; }
        [Column("AMNT1")]
        public double? Amnt1 { get; set; }
        [Column("AMNT2")]
        public double? Amnt2 { get; set; }
        [Column("AMNT3")]
        public double? Amnt3 { get; set; }
        [Column("AMNT4")]
        public double? Amnt4 { get; set; }
        public double? Bal { get; set; }
    }
}
