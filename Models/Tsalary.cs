using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Keyless]
    [Table("TSalary")]
    public partial class Tsalary
    {
        [Column("ECode")]
        [StringLength(13)]
        public string Ecode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Dat { get; set; }
        public int? Mnth { get; set; }
        public int? Yar { get; set; }
        public int? Status { get; set; }
        [Column("WDays")]
        public double? Wdays { get; set; }
        [Column("ADays")]
        public double? Adays { get; set; }
        [Column("BPay")]
        public double? Bpay { get; set; }
        [Column("HRent")]
        public int? Hrent { get; set; }
        public int? Utility { get; set; }
        public int? Con { get; set; }
        [Column("OTIME")]
        public int? Otime { get; set; }
        public int? Loan { get; set; }
        [Column("ITax")]
        public int? Itax { get; set; }
        public int? Adv { get; set; }
        public int? LeaveDed { get; set; }
        [Column("EOBI")]
        public int? Eobi { get; set; }
        public int? Post { get; set; }
        [Column("DPCODE")]
        [StringLength(3)]
        public string Dpcode { get; set; }
        [Column("MESS")]
        public double? Mess { get; set; }
        public double? Allow { get; set; }
        public double? Conv { get; set; }
        public double? Utilty { get; set; }
        [Column("OTHER")]
        public double? Other { get; set; }
        [Column("OTHRS")]
        public double? Othrs { get; set; }
        [Column("OTAMT")]
        public double? Otamt { get; set; }
        [Column("LOANAMT")]
        public double? Loanamt { get; set; }
        [Column("NET")]
        public double? Net { get; set; }
        [Column("LBAL")]
        public double? Lbal { get; set; }
    }
}
