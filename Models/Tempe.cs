using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Keyless]
    [Table("TEmpe")]
    public partial class Tempe
    {
        [Column("ECode")]
        [StringLength(50)]
        public string Ecode { get; set; }
        [Column("EName")]
        [StringLength(50)]
        public string Ename { get; set; }
        [Column("FName")]
        [StringLength(50)]
        public string Fname { get; set; }
        [Column("DOB", TypeName = "datetime")]
        public DateTime? Dob { get; set; }
        [Column("NIC")]
        [StringLength(20)]
        public string Nic { get; set; }
        [Column("DName")]
        [StringLength(30)]
        public string Dname { get; set; }
        [StringLength(30)]
        public string DpName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ApDate { get; set; }
        [Column("EStat")]
        [StringLength(20)]
        public string Estat { get; set; }
        public int? Active { get; set; }
    }
}
