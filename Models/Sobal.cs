using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Keyless]
    [Table("SOBAL")]
    public partial class Sobal
    {
        [Column("PCODE")]
        [StringLength(15)]
        public string Pcode { get; set; }
        [Column("VCODE")]
        [StringLength(50)]
        public string Vcode { get; set; }
        [Column("NO")]
        public double? No { get; set; }
        [Column("ORD")]
        public double? Ord { get; set; }
        [Column("DIS")]
        public double? Dis { get; set; }
        [Column("BAL")]
        public double? Bal { get; set; }
        [Column("CANCL")]
        public double? Cancl { get; set; }
        [Column("STKBAL")]
        public double? Stkbal { get; set; }
    }
}
