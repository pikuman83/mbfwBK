using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Table("PRDINFO")]
    public partial class Prdinfo
    {
        [Column("FCODE")]
        [StringLength(20)]
        public string Fcode { get; set; }
        [Column("FNAME")]
        [StringLength(150)]
        public string Fname { get; set; }
        [Column("FUNIT")]
        [StringLength(25)]
        public string Funit { get; set; }
        [Column("FQTY")]
        public double? Fqty { get; set; }
        [Column("PCODE")]
        [StringLength(20)]
        public string Pcode { get; set; }
        [Column("PNAME")]
        [StringLength(150)]
        public string Pname { get; set; }
        [Column("UNIT")]
        [StringLength(25)]
        public string Unit { get; set; }
        [Column("QTY")]
        public double? Qty { get; set; }
        [Column("SNO")]
        public int? Sno { get; set; }
        [Key]
        [Column("ID")]
        public int Id { get; set; }
    }
}
