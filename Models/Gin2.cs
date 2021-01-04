﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Table("GIN2")]
    public partial class Gin2
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
        [Column("SONO")]
        public int? Sono { get; set; }
        [Column("SOBAL")]
        public double? Sobal { get; set; }
        [Column("OABAL")]
        public double? Oabal { get; set; }
        [Column("COLORDEMAND")]
        [StringLength(250)]
        public string Colordemand { get; set; }
        [Column("QTY")]
        public double? Qty { get; set; }
        [Column("SNO")]
        public int? Sno { get; set; }
        [Column("GDCODE")]
        [StringLength(10)]
        public string Gdcode { get; set; }
        [Column("GDNAME")]
        [StringLength(100)]
        public string Gdname { get; set; }
        [Column("RATE")]
        public double? Rate { get; set; }
        [Column("NETRATE")]
        public double? Netrate { get; set; }
        [Column("AMOUNT")]
        public double? Amount { get; set; }
        [Key]
        [Column("id")]
        public int Id { get; set; }
    }
}
