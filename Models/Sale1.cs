using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Table("SALE1")]
    public partial class Sale1
    {
        [Key]
        [Column("NO")]
        public int No { get; set; }
        [Column("VDATE", TypeName = "datetime")]
        public DateTime? Vdate { get; set; }
        [Column("STYPE")]
        public short? Stype { get; set; }
        [Column("STNAME")]
        [StringLength(10)]
        public string Stname { get; set; }
        [Column("VCODE")]
        [StringLength(10)]
        public string Vcode { get; set; }
        [Column("VNAME")]
        [StringLength(150)]
        public string Vname { get; set; }
        [Column("ADDR")]
        [StringLength(250)]
        public string Addr { get; set; }
        [Column("TOTAL")]
        public double? Total { get; set; }
        [Column("VNO")]
        [StringLength(15)]
        public string Vno { get; set; }
        [Column("SCODE")]
        [StringLength(10)]
        public string Scode { get; set; }
        [Column("SNAME")]
        [StringLength(50)]
        public string Sname { get; set; }
        [Column("STAMT")]
        public double? Stamt { get; set; }
        [Column("NET")]
        public double? Net { get; set; }
        [Column("GST")]
        public double? Gst { get; set; }
        [Column("OPBAL")]
        public double? Opbal { get; set; }
        [Column("DESCR")]
        [StringLength(250)]
        public string Descr { get; set; }
    }
}
