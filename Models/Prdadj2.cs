using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Keyless]
    [Table("PRDADJ2")]
    public partial class Prdadj2
    {
        [Column("NO")]
        public int? No { get; set; }
        [Column("VDATE", TypeName = "datetime")]
        public DateTime? Vdate { get; set; }
        [Column("SNO")]
        public int? Sno { get; set; }
        [Column("PCODE")]
        [StringLength(100)]
        public string Pcode { get; set; }
        [Column("PNAME")]
        [StringLength(250)]
        public string Pname { get; set; }
        [Column("UNIT")]
        [StringLength(25)]
        public string Unit { get; set; }
        [Column("AVBLSTOCK")]
        public double? Avblstock { get; set; }
        [Column("QTYP")]
        public double? Qtyp { get; set; }
        [Column("QTYM")]
        public double? Qtym { get; set; }
        [Column("RATE")]
        public double? Rate { get; set; }
        [Column("AMOUNT")]
        public double? Amount { get; set; }
    }
}
