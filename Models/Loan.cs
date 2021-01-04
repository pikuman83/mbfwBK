using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Keyless]
    [Table("LOAN")]
    public partial class Loan
    {
        [Column("VNO")]
        public int? Vno { get; set; }
        [Column("VDATE", TypeName = "datetime")]
        public DateTime? Vdate { get; set; }
        [Column("ECODE")]
        [StringLength(10)]
        public string Ecode { get; set; }
        [Column("ENAME")]
        [StringLength(150)]
        public string Ename { get; set; }
        [Column("edesg")]
        [StringLength(50)]
        public string Edesg { get; set; }
        [Column("EDEPT")]
        [StringLength(50)]
        public string Edept { get; set; }
        [StringLength(50)]
        public string Estat { get; set; }
        [Column("VTYPE")]
        [StringLength(10)]
        public string Vtype { get; set; }
        [Column("LAMOUNT")]
        public double? Lamount { get; set; }
        [Column("INST")]
        public double? Inst { get; set; }
        [Column("PMINST")]
        public double? Pminst { get; set; }
        [Column("VCODE")]
        [StringLength(15)]
        public string Vcode { get; set; }
        [Column("VNAME")]
        [StringLength(150)]
        public string Vname { get; set; }
    }
}
