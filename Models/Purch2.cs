using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Table("PURCH2")]
    public partial class Purch2
    {
        [Column("NO")]
        public int? No { get; set; }
        [Column("VDATE", TypeName = "datetime")]
        public DateTime? Vdate { get; set; }
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
        [Column("GST")]
        public float? Gst { get; set; }
        [Column("GSTAMT")]
        public double? Gstamt { get; set; }
        [Column("TOTAL")]
        public double? Total { get; set; }
        [Column("SNO")]
        public int? Sno { get; set; }
        [Column("VCODE")]
        [StringLength(15)]
        public string Vcode { get; set; }
        [Column("PONO")]
        public int? Pono { get; set; }
        [Column("GDCODE")]
        [StringLength(10)]
        public string Gdcode { get; set; }
        [Column("GDNAME")]
        [StringLength(150)]
        public string Gdname { get; set; }
        [Column("VNO")]
        [StringLength(25)]
        public string Vno { get; set; }
        [Key]
        [Column("id")]
        public int Id { get; set; }
    }
}
