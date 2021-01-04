using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Keyless]
    [Table("TAttSummary")]
    public partial class TattSummary
    {
        [Column("ADate", TypeName = "datetime")]
        public DateTime? Adate { get; set; }
        public int? Mnth { get; set; }
        public int? Yar { get; set; }
        [Column("ECode")]
        [StringLength(6)]
        public string Ecode { get; set; }
        [Column("EName")]
        [StringLength(50)]
        public string Ename { get; set; }
        [StringLength(50)]
        public string Designation { get; set; }
        [StringLength(50)]
        public string Department { get; set; }
        [Column("PRESENT")]
        public double? Present { get; set; }
        [Column("ABSENT")]
        public double? Absent { get; set; }
        [Column("LEAVE")]
        public double? Leave { get; set; }
    }
}
