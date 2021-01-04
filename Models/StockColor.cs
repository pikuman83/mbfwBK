using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Table("STOCK_COLOR")]
    public partial class StockColor
    {
        [Column("NO")]
        public int No { get; set; }
        [Column("VDATE", TypeName = "datetime")]
        public DateTime? Vdate { get; set; }
        [Column("JO")]
        [StringLength(3)]
        public string Jo { get; set; }
        [Column("PCODE")]
        [StringLength(10)]
        public string Pcode { get; set; }
        [Column("COLOR")]
        [StringLength(50)]
        public string Color { get; set; }
        [Column("RNO")]
        public int? Rno { get; set; }
        [Column("DESCR")]
        [StringLength(250)]
        public string Descr { get; set; }
        [Column("INQT")]
        public double? Inqt { get; set; }
        [Column("OUTQT")]
        public double? Outqt { get; set; }
        [Column("INAMT")]
        public double? Inamt { get; set; }
        [Column("OUTAMT")]
        public double? Outamt { get; set; }
        [Column("VCODE")]
        [StringLength(50)]
        public string Vcode { get; set; }
        [Column("GDCODE")]
        [StringLength(10)]
        public string Gdcode { get; set; }
        [Column("GDNAME")]
        [StringLength(150)]
        public string Gdname { get; set; }
        [Column("VNO")]
        [StringLength(15)]
        public string Vno { get; set; }
        [Column("BQTY")]
        public double? Bqty { get; set; }
        [Column("ESTATUS")]
        [StringLength(25)]
        public string Estatus { get; set; }
        [Key]
        [Column("id")]
        public int Id { get; set; }
    }
}
