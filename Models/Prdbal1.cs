using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Keyless]
    [Table("PRDBAL1")]
    public partial class Prdbal1
    {
        [Column("PCODE")]
        [StringLength(10)]
        public string Pcode { get; set; }
        [Column("PNAME")]
        [StringLength(40)]
        public string Pname { get; set; }
        [Column("UNIT")]
        [StringLength(10)]
        public string Unit { get; set; }
        [Column("PTYPE")]
        public int? Ptype { get; set; }
        [Column("PTPNAME")]
        [StringLength(30)]
        public string Ptpname { get; set; }
        [Column("QTY")]
        public double? Qty { get; set; }
        [Column("AMOUNT")]
        public double? Amount { get; set; }
        [Column("GRP")]
        [StringLength(25)]
        public string Grp { get; set; }
        [Column("PURAVG")]
        public double? Puravg { get; set; }
    }
}
