using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Keyless]
    [Table("DWageAtt")]
    public partial class DwageAtt
    {
        [Column("ECode")]
        [StringLength(13)]
        public string Ecode { get; set; }
        [Column("EName")]
        [StringLength(100)]
        public string Ename { get; set; }
        [Column("FName")]
        [StringLength(100)]
        public string Fname { get; set; }
        [StringLength(100)]
        public string Designation { get; set; }
        public double? Att { get; set; }
        public int? Mnth { get; set; }
        public int? Yar { get; set; }
        [Column("OTHRS")]
        public int? Othrs { get; set; }
        [Column("OTAMT")]
        public double? Otamt { get; set; }
        [Column("BPAY")]
        public double? Bpay { get; set; }
        [Column("SALARY")]
        public double? Salary { get; set; }
        [Column("LOAN")]
        public double? Loan { get; set; }
        [Column("LOANAMT")]
        public double? Loanamt { get; set; }
        [Column("ADV")]
        public double? Adv { get; set; }
        [Column("MESS")]
        public double? Mess { get; set; }
        [Column("NET")]
        public double? Net { get; set; }
        public double? Allow { get; set; }
        public double? Conv { get; set; }
        public double? Utilty { get; set; }
        public double? Itax { get; set; }
        [Column("OTHER")]
        public double? Other { get; set; }
        [Column("PJCODE")]
        [StringLength(10)]
        public string Pjcode { get; set; }
        [Column("PJNAME")]
        [StringLength(100)]
        public string Pjname { get; set; }
        [Column("INCREMENT")]
        public double? Increment { get; set; }
        [Column("WDAY")]
        public double? Wday { get; set; }
        [Column("LEVPAID")]
        public double? Levpaid { get; set; }
        [Column("ARRER")]
        public double? Arrer { get; set; }
        [Column("EOBI")]
        public double? Eobi { get; set; }
        [Column("SSC")]
        public double? Ssc { get; set; }
        [Column("INCOMTAX")]
        public double? Incomtax { get; set; }
    }
}
