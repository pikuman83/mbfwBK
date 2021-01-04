using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Table("SORDER1")]
    public partial class Sorder1
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
        [StringLength(50)]
        public string Vname { get; set; }
        [Column("ADDR")]
        [StringLength(50)]
        public string Addr { get; set; }
        [Column("TOTAL")]
        public double? Total { get; set; }
        [Column("DISCOUNT")]
        public double? Discount { get; set; }
        [Column("VNO")]
        [StringLength(15)]
        public string Vno { get; set; }
        [Column("REM")]
        [StringLength(250)]
        public string Rem { get; set; }
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
        [Column("TRANSPORT")]
        [StringLength(50)]
        public string Transport { get; set; }
        [Column("BDATE", TypeName = "datetime")]
        public DateTime? Bdate { get; set; }
        [Column("BNO")]
        [StringLength(15)]
        public string Bno { get; set; }
        [Column("SQTY")]
        public int? Sqty { get; set; }
        [Column("SQTY1")]
        public int? Sqty1 { get; set; }
        [Column("DESCR")]
        [StringLength(250)]
        public string Descr { get; set; }
        [Column("TEL")]
        [StringLength(100)]
        public string Tel { get; set; }
        [Column("SMCODE")]
        [StringLength(10)]
        public string Smcode { get; set; }
        [Column("SMNAME")]
        [StringLength(100)]
        public string Smname { get; set; }
        [Column("COMM")]
        public double? Comm { get; set; }
        [Column("COMMRATE")]
        public double? Commrate { get; set; }
        [Column("GDCODE")]
        [StringLength(10)]
        public string Gdcode { get; set; }
        [Column("GDNAME")]
        [StringLength(100)]
        public string Gdname { get; set; }
        [Column("FREIGHT")]
        public double? Freight { get; set; }
        [Column("EUSER")]
        [StringLength(25)]
        public string Euser { get; set; }
        [Column("PCODE")]
        [StringLength(25)]
        public string Pcode { get; set; }
        [Column("PNAME")]
        [StringLength(150)]
        public string Pname { get; set; }
        [Column("DQTY")]
        public double? Dqty { get; set; }
        [Column("ORDFROM")]
        public short? Ordfrom { get; set; }
    }
}
