using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Keyless]
    public partial class PendingOrdersPO
    {
        [Required]
        [Column("PCODE")]
        [StringLength(25)]
        public string Pcode { get; set; }
        [Column("PNAME")]
        [StringLength(150)]
        public string Pname { get; set; }
        [Column("UNIT")]
        [StringLength(20)]
        public string Unit { get; set; }
        [Column("SRATEP")]
        public double? Sratep { get; set; }
        [Column("PTYPE")]
        public short? Ptype { get; set; }
        [Column("GNAME")]
        [StringLength(25)]
        public string Gname { get; set; }
        [Column("QTY")]
        public double? Qty { get; set; }
        [Column("PONO")]
        public int? Pono { get; set; }
        [Column("VCODE")]
        [StringLength(50)]
        public string Vcode { get; set; }
        [Column("VNAME")]
        [StringLength(150)]
        public string Vname { get; set; }
    }
}
