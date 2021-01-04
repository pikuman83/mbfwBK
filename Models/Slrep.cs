using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Keyless]
    [Table("SLREP")]
    public partial class Slrep
    {
        [Column("NO")]
        public int? No { get; set; }
        [Column("VDATE", TypeName = "smalldatetime")]
        public DateTime? Vdate { get; set; }
        [Column("VNAME")]
        [StringLength(250)]
        public string Vname { get; set; }
        [Column("VCODE")]
        [StringLength(25)]
        public string Vcode { get; set; }
        [Column("PCODE")]
        [StringLength(25)]
        public string Pcode { get; set; }
        [Column("PNAME")]
        [StringLength(150)]
        public string Pname { get; set; }
        [Column("UNIT")]
        [StringLength(10)]
        public string Unit { get; set; }
        [Column("QTY")]
        public double? Qty { get; set; }
        [Column("RATE")]
        public double? Rate { get; set; }
        [Column("AMOUNT")]
        public double? Amount { get; set; }
        [Column("ART")]
        [StringLength(50)]
        public string Art { get; set; }
        [Column("JO")]
        [StringLength(3)]
        public string Jo { get; set; }
        [Column("VNO")]
        [StringLength(20)]
        public string Vno { get; set; }
        [Column("GST")]
        public double? Gst { get; set; }
        [Column("GSTAMT")]
        public double? Gstamt { get; set; }
        [Column("TOTAL")]
        public double? Total { get; set; }
        [Column("FTAMT")]
        public double? Ftamt { get; set; }
        [Column("BAL15")]
        public double? Bal15 { get; set; }
        [Column("BAL30")]
        public double? Bal30 { get; set; }
        [Column("BAL45")]
        public double? Bal45 { get; set; }
        [Column("BAL46")]
        public double? Bal46 { get; set; }
        [Column("BAL")]
        public double? Bal { get; set; }
        [Column("OPBAL")]
        public double? Opbal { get; set; }
        [Column("SALE")]
        public double? Sale { get; set; }
        [Column("SRET")]
        public double? Sret { get; set; }
        [Column("CASH")]
        public double? Cash { get; set; }
        [Column("GTOTAL")]
        public double? Gtotal { get; set; }
        [Column("SDATE", TypeName = "datetime")]
        public DateTime? Sdate { get; set; }
        [Column("EDATE", TypeName = "datetime")]
        public DateTime? Edate { get; set; }
        [Column("OPENING")]
        public double? Opening { get; set; }
        [Column("RECOVERY")]
        public double? Recovery { get; set; }
        [Column("AVERAGE")]
        public double? Average { get; set; }
        [Column("CLAIM")]
        public double? Claim { get; set; }
        [Column("GROSS")]
        public double? Gross { get; set; }
        [Column("rem")]
        [StringLength(250)]
        public string Rem { get; set; }
        [Column("BNO")]
        [StringLength(25)]
        public string Bno { get; set; }
        [Column("TRANSPORT")]
        [StringLength(250)]
        public string Transport { get; set; }
        [Column("BAL75")]
        public double? Bal75 { get; set; }
        [Column("BAL90")]
        public double? Bal90 { get; set; }
        [Column("BAL60")]
        public double? Bal60 { get; set; }
        [Column("TENAME")]
        [StringLength(250)]
        public string Tename { get; set; }
        [Column("GDCODE")]
        [StringLength(10)]
        public string Gdcode { get; set; }
        [Column("GDNAME")]
        [StringLength(100)]
        public string Gdname { get; set; }
    }
}
