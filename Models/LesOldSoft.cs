using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Keyless]
    [Table("LesOldSoft")]
    public partial class LesOldSoft
    {
        [Column("NO")]
        public double? No { get; set; }
        [Column("VDATE", TypeName = "smalldatetime")]
        public DateTime? Vdate { get; set; }
        [Column("SNO")]
        public double? Sno { get; set; }
        [Column("VCODE")]
        [StringLength(255)]
        public string Vcode { get; set; }
        [Column("VNAME")]
        [StringLength(255)]
        public string Vname { get; set; }
        [Column("OVCODE")]
        [StringLength(255)]
        public string Ovcode { get; set; }
        [Column("OVNAME")]
        [StringLength(255)]
        public string Ovname { get; set; }
        [Column("PCODE")]
        public double? Pcode { get; set; }
        [Column("PNAME")]
        [StringLength(255)]
        public string Pname { get; set; }
        [Column("PRATE")]
        public double? Prate { get; set; }
        [Column("SRATE")]
        public double? Srate { get; set; }
    }
}
