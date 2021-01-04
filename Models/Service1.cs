using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Table("SERVICE1")]
    public partial class Service1
    {
        public Service1()
        {
            Service2s = new HashSet<Service2>();
        }

        [Key]
        [Column("NO")]
        public double No { get; set; }
        [Column("VDATE", TypeName = "datetime")]
        public DateTime? Vdate { get; set; }
        [Column("SNO")]
        public double? Sno { get; set; }
        [Column("INTIME", TypeName = "datetime")]
        public DateTime? Intime { get; set; }
        [Column("OUTTIME", TypeName = "datetime")]
        public DateTime? Outtime { get; set; }
        [Column("VCODE")]
        [StringLength(15)]
        public string Vcode { get; set; }
        [Column("TOTAL")]
        public double? Total { get; set; }
        [Column("PRVBAL")]
        public double? Prvbal { get; set; }
        [Column("ADVRCV")]
        public double? Advrcv { get; set; }
        [Column("NET")]
        public double? Net { get; set; }
        [Column("PREPBY")]
        [StringLength(100)]
        public string Prepby { get; set; }

        [ForeignKey(nameof(Vcode))]
        [InverseProperty(nameof(Customer.Service1s))]
        public virtual Customer VcodeNavigation { get; set; }
        [InverseProperty(nameof(Service2.OrdernoNavigation))]
        public virtual ICollection<Service2> Service2s { get; set; }
    }
}
