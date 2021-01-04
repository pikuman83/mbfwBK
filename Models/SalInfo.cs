using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Keyless]
    [Table("SalInfo")]
    public partial class SalInfo
    {
        [Column("ECode")]
        [StringLength(13)]
        public string Ecode { get; set; }
        [Column("EName")]
        [StringLength(150)]
        public string Ename { get; set; }
        [Column("EDesg")]
        [StringLength(50)]
        public string Edesg { get; set; }
        [Column("EDept")]
        [StringLength(50)]
        public string Edept { get; set; }
        [Column("EDeptSub")]
        [StringLength(50)]
        public string EdeptSub { get; set; }
        [StringLength(25)]
        public string Estat { get; set; }
        public int? Leave { get; set; }
        [Column("BPay")]
        public int? Bpay { get; set; }
        public int? Con { get; set; }
        [Column("HRent")]
        public int? Hrent { get; set; }
        [Column("OTime")]
        public int? Otime { get; set; }
        public int? Utility { get; set; }
        public int? Loan { get; set; }
        public int? Adv { get; set; }
        [Column("ITax")]
        public int? Itax { get; set; }
        public int? LeaveDed { get; set; }
        [Column("EOBI")]
        public int? Eobi { get; set; }
    }
}
