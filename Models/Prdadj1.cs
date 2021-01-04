using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Keyless]
    [Table("PRDADJ1")]
    public partial class Prdadj1
    {
        [Column("NO")]
        public int? No { get; set; }
        [Column("VNO")]
        [StringLength(10)]
        public string Vno { get; set; }
        [Column("STYPE")]
        [StringLength(2)]
        public string Stype { get; set; }
        [Column("STPNAME")]
        [StringLength(10)]
        public string Stpname { get; set; }
        [Column("VDATE", TypeName = "datetime")]
        public DateTime? Vdate { get; set; }
        [Column("VCODE")]
        [StringLength(10)]
        public string Vcode { get; set; }
        [Column("VNAME")]
        [StringLength(100)]
        public string Vname { get; set; }
        [Column("ADDR")]
        [StringLength(100)]
        public string Addr { get; set; }
        [Column("TOTAL")]
        public double? Total { get; set; }
        [Column("FGDN")]
        [StringLength(10)]
        public string Fgdn { get; set; }
        [Column("FGDNAME")]
        [StringLength(100)]
        public string Fgdname { get; set; }
        [Column("TGDN")]
        [StringLength(10)]
        public string Tgdn { get; set; }
        [Column("TGDNAME")]
        [StringLength(100)]
        public string Tgdname { get; set; }
        [Column("TQTY")]
        public double? Tqty { get; set; }
        [Column("REMARKS")]
        [StringLength(250)]
        public string Remarks { get; set; }
        [Column("EUSER")]
        [StringLength(25)]
        public string Euser { get; set; }
    }
}
