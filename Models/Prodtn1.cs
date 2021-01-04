using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Keyless]
    [Table("PRODTN1")]
    public partial class Prodtn1
    {
        [Column("NO")]
        public int? No { get; set; }
        [Column("VNO")]
        [StringLength(50)]
        public string Vno { get; set; }
        [Column("VDATE", TypeName = "datetime")]
        public DateTime? Vdate { get; set; }
        [Column("FCODE")]
        [StringLength(25)]
        public string Fcode { get; set; }
        [Column("FNAME")]
        [StringLength(150)]
        public string Fname { get; set; }
        [Column("FUNIT")]
        [StringLength(25)]
        public string Funit { get; set; }
        [Column("FQTY")]
        public double? Fqty { get; set; }
        [Column("TOTAL")]
        public double? Total { get; set; }
        [Column("RATE")]
        public double? Rate { get; set; }
        [Column("SHIFT")]
        [StringLength(10)]
        public string Shift { get; set; }
        [Column("GDCODE")]
        [StringLength(10)]
        public string Gdcode { get; set; }
        [Column("GDNAME")]
        [StringLength(150)]
        public string Gdname { get; set; }
        [Column("TYP")]
        public short? Typ { get; set; }
        [Column("EUSER")]
        [StringLength(25)]
        public string Euser { get; set; }
    }
}
