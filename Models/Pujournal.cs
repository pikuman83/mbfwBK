using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Table("PUJOURNAL")]
    public partial class Pujournal
    {
        [Column("NO")]
        public int? No { get; set; }
        [Column("VDATE", TypeName = "datetime")]
        public DateTime? Vdate { get; set; }
        [Required]
        [Column("ACODE")]
        [StringLength(10)]
        public string Acode { get; set; }
        [Column("ANAME")]
        [StringLength(40)]
        public string Aname { get; set; }
        [Column("DESCR")]
        [StringLength(50)]
        public string Descr { get; set; }
        [Column("DEBIT")]
        public double? Debit { get; set; }
        [Column("CREDIT")]
        public double? Credit { get; set; }
        [Column("EUSER")]
        [StringLength(25)]
        public string Euser { get; set; }
        [Key]
        [Column("id")]
        public int Id { get; set; }
    }
}
