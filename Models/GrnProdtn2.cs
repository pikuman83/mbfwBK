using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Keyless]
    [Table("GRN_PRODTN2")]
    public partial class GrnProdtn2
    {
        [Column("NO")]
        public int? No { get; set; }
        [Column("VDATE", TypeName = "datetime")]
        public DateTime? Vdate { get; set; }
        [Column("PCODE")]
        [StringLength(10)]
        public string Pcode { get; set; }
        [Column("PNAME")]
        [StringLength(50)]
        public string Pname { get; set; }
        [Column("UNIT")]
        [StringLength(10)]
        public string Unit { get; set; }
        [Column("QTY")]
        public double? Qty { get; set; }
        [Column("RATE")]
        public double? Rate { get; set; }
        [Column("BQTY")]
        public double? Bqty { get; set; }
        [Column("AMOUNT")]
        public double? Amount { get; set; }
        [Column("FCODE")]
        [StringLength(10)]
        public string Fcode { get; set; }
        [Column("SHIFT")]
        [StringLength(10)]
        public string Shift { get; set; }
    }
}
