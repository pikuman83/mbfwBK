using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Table("SERVICE2")]
    public partial class Service2
    {
        [Key]
        [Column("NO")]
        public double No { get; set; }
        [Column("VDATE", TypeName = "datetime")]
        public DateTime? Vdate { get; set; }
        [Column("ORDERNO")]
        public double? Orderno { get; set; }
        [Column("PCODE")]
        [StringLength(15)]
        public string Pcode { get; set; }
        [Column("PNAME")]
        [StringLength(150)]
        public string Pname { get; set; }
        [Column("UNIT")]
        [StringLength(5)]
        public string Unit { get; set; }
        [Column("QTY")]
        public double? Qty { get; set; }
        [Column("RATE")]
        public double? Rate { get; set; }
        [Column("AMOUNT")]
        public double? Amount { get; set; }

        [ForeignKey(nameof(Orderno))]
        [InverseProperty(nameof(Service1.Service2s))]
        public virtual Service1 OrdernoNavigation { get; set; }
        [ForeignKey(nameof(Pcode))]
        [InverseProperty(nameof(Product2delete.Service2s))]
        public virtual Product2delete PcodeNavigation { get; set; }
    }
}
