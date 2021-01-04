using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Keyless]
    [Table("EMPTY_SHEET_ADVANCE")]
    public partial class EmptySheetAdvance
    {
        [Column("ECODE")]
        [StringLength(10)]
        public string Ecode { get; set; }
        [Column("ENAME")]
        [StringLength(150)]
        public string Ename { get; set; }
        [Column("BPay")]
        public double? Bpay { get; set; }
        [Column("DAYS")]
        public int? Days { get; set; }
        public double? CalcPay { get; set; }
        [Column("PADVANCE")]
        public double? Padvance { get; set; }
        [Column("VDATE", TypeName = "datetime")]
        public DateTime? Vdate { get; set; }
    }
}
