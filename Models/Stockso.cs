using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Table("STOCKSO")]
    public partial class Stockso
    {
        [Column("NO")]
        public int? No { get; set; }
        [Column("SONO")]
        public int? Sono { get; set; }
        [Column("VDATE", TypeName = "datetime")]
        public DateTime? Vdate { get; set; }
        [Column("JO")]
        [StringLength(3)]
        public string Jo { get; set; }
        [Column("PCODE")]
        [StringLength(15)]
        public string Pcode { get; set; }
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
        [Column("BATCH")]
        [StringLength(15)]
        public string Batch { get; set; }
        [Column("POST")]
        public int? Post { get; set; }
        [Column("VCODE")]
        [StringLength(50)]
        public string Vcode { get; set; }
        [Column("GRP")]
        [StringLength(10)]
        public string Grp { get; set; }
        [Column("GNAME")]
        [StringLength(50)]
        public string Gname { get; set; }
        [Column("GDCODE")]
        [StringLength(10)]
        public string Gdcode { get; set; }
        [Column("GDNAME")]
        [StringLength(150)]
        public string Gdname { get; set; }
        [Column("VNO")]
        [StringLength(15)]
        public string Vno { get; set; }
        [Column("STYPE")]
        public short? Stype { get; set; }
        [Key]
        [Column("id")]
        public int Id { get; set; }
    }
}
