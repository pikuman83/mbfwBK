using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Table("PRODUCT")]
    public partial class Product
    {
        [Key]
        [Column("PCODE")]
        [StringLength(25)]
        public string Pcode { get; set; }
        [Column("PCODEOLD")]
        [StringLength(25)]
        public string Pcodeold { get; set; }
        [Column("PCODE_NO")]
        public double? PcodeNo { get; set; }
        [Column("PNAME")]
        [StringLength(150)]
        public string Pname { get; set; }
        [Column("UPNAME")]
        [StringLength(250)]
        public string Upname { get; set; }
        [Column("UPFNAME")]
        [StringLength(250)]
        public string Upfname { get; set; }
        [Column("UNIT")]
        [StringLength(20)]
        public string Unit { get; set; }
        [Column("GRP")]
        public short? Grp { get; set; }
        [Column("GNAME")]
        [StringLength(25)]
        public string Gname { get; set; }
        [Column("MGRP")]
        public short? Mgrp { get; set; }
        [Column("MGNAME")]
        [StringLength(25)]
        public string Mgname { get; set; }
        [Column("PRATE")]
        public double? Prate { get; set; }
        [Column("PRATEP")]
        public double? Pratep { get; set; }
        [Column("SRATE")]
        public double? Srate { get; set; }
        [Column("SRATEP")]
        public double? Sratep { get; set; }
        [Column("PTYPE")]
        public short? Ptype { get; set; }
        [Column("PTPNAME")]
        [StringLength(15)]
        public string Ptpname { get; set; }
        [Column("SGNAME")]
        [StringLength(100)]
        public string Sgname { get; set; }
        [Column("SIZE")]
        [StringLength(100)]
        public string Size { get; set; }
        [Column("ARTICLE")]
        [StringLength(25)]
        public string Article { get; set; }
        [Column("SHOESTYP")]
        [StringLength(25)]
        public string Shoestyp { get; set; }
        [Column("TYP")]
        [StringLength(10)]
        public string Typ { get; set; }
        [Column("LESSAMNT")]
        public double? Lessamnt { get; set; }
        [Column("MINLEVL")]
        public double? Minlevl { get; set; }
        [Column("MAXLEVL")]
        public double? Maxlevl { get; set; }
        [StringLength(50)]
        public string FileName { get; set; }
        [Column("DISC")]
        public double? Disc { get; set; }
        [Column("ACTIV")]
        public short? Activ { get; set; }
        [Column("DEAD")]
        public short? Dead { get; set; }
        [Column("VDATE", TypeName = "datetime")]
        public DateTime? Vdate { get; set; }
    }
}
