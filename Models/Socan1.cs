﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Keyless]
    [Table("SOCAN1")]
    public partial class Socan1
    {
        [Column("NO")]
        public int No { get; set; }
        [Column("VDATE", TypeName = "datetime")]
        public DateTime? Vdate { get; set; }
        [Column("VCODE")]
        [StringLength(15)]
        public string Vcode { get; set; }
        [Column("VNAME")]
        [StringLength(150)]
        public string Vname { get; set; }
        [Column("ADDR")]
        [StringLength(200)]
        public string Addr { get; set; }
        [Column("TOTAL")]
        public double? Total { get; set; }
        [Column("VNO")]
        [StringLength(15)]
        public string Vno { get; set; }
        [Column("GDCODE")]
        [StringLength(10)]
        public string Gdcode { get; set; }
        [Column("GDNAME")]
        [StringLength(100)]
        public string Gdname { get; set; }
        [Column("EUSER")]
        [StringLength(25)]
        public string Euser { get; set; }
        [Column("TRANSPORT")]
        [StringLength(150)]
        public string Transport { get; set; }
        [Column("BNO")]
        [StringLength(50)]
        public string Bno { get; set; }
        [Column("SQTY")]
        [StringLength(25)]
        public string Sqty { get; set; }
        [Column("SQTY1")]
        [StringLength(25)]
        public string Sqty1 { get; set; }
        [Column("BDATE", TypeName = "datetime")]
        public DateTime? Bdate { get; set; }
        [Column("STYPE")]
        public short? Stype { get; set; }
    }
}