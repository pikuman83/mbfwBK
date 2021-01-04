using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Table("SALE2")]
    public partial class Sale2
    {
        [Column("NO")]
        public short? No { get; set; }
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
        [Column("RATEP")]
        public double? Ratep { get; set; }
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
        [Column("BONUS")]
        public double? Bonus { get; set; }
        [Column("BATCH")]
        [StringLength(15)]
        public string Batch { get; set; }
        [Column("SNO")]
        public int? Sno { get; set; }
        [Column("VCODE")]
        [StringLength(10)]
        public string Vcode { get; set; }
        [Column("GDCODE")]
        [StringLength(10)]
        public string Gdcode { get; set; }
        [Column("GDNAME")]
        [StringLength(100)]
        public string Gdname { get; set; }
        [Column("LRATE")]
        public double? Lrate { get; set; }
        [Column("SLRATE")]
        public double? Slrate { get; set; }
        [Column("SONO")]
        public int? Sono { get; set; }
        [Key]
        [Column("id")]
        public int Id { get; set; }
    }
}
