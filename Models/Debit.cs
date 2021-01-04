using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Table("DEBIT")]
    public partial class Debit
    {
        [Column("NO")]
        public double? No { get; set; }
        [Column("RNO")]
        [StringLength(10)]
        public string Rno { get; set; }
        [Column("VDATE", TypeName = "datetime")]
        public DateTime? Vdate { get; set; }
        [Required]
        [Column("ACODE")]
        [StringLength(13)]
        public string Acode { get; set; }
        [Column("ANAME")]
        [StringLength(250)]
        public string Aname { get; set; }
        [Column("DESCR")]
        [StringLength(250)]
        public string Descr { get; set; }
        [Column("DEBIT")]
        public double? Debit1 { get; set; }
        [Column("CREDIT")]
        public double? Credit { get; set; }
        [Column("SNO")]
        public int? Sno { get; set; }
        [Column("PDATE", TypeName = "datetime")]
        public DateTime? Pdate { get; set; }
        [Column("CLRDATE")]
        [StringLength(10)]
        public string Clrdate { get; set; }
        [Column("SORD")]
        public int? Sord { get; set; }
        [Column("CHQNO")]
        [StringLength(20)]
        public string Chqno { get; set; }
        [Column("CACODE")]
        [StringLength(13)]
        public string Cacode { get; set; }
        [Column("CANAME")]
        [StringLength(250)]
        public string Caname { get; set; }
        [Column("TERM")]
        [StringLength(50)]
        public string Term { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
        [Column("REMARKS")]
        [StringLength(250)]
        public string Remarks { get; set; }
        [Column("CR_BY")]
        [StringLength(10)]
        public string CrBy { get; set; }
        [Column("CR_TYM")]
        [StringLength(20)]
        public string CrTym { get; set; }
        [Column("EUSER")]
        [StringLength(25)]
        public string Euser { get; set; }
        [Key]
        [Column("id")]
        public int Id { get; set; }
    }
}
