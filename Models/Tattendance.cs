using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Keyless]
    [Table("TAttendance")]
    public partial class Tattendance
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
        [StringLength(2)]
        public string Status { get; set; }
    }
}
