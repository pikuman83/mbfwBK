using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Keyless]
    [Table("LOG")]
    public partial class Log
    {
        [Column("VOUCHER")]
        [StringLength(50)]
        public string Voucher { get; set; }
        [Column("NO")]
        public int? No { get; set; }
        [Column("USERNM")]
        [StringLength(25)]
        public string Usernm { get; set; }
        [Column("EDATE", TypeName = "datetime")]
        public DateTime? Edate { get; set; }
        [Column("ETIME")]
        [StringLength(25)]
        public string Etime { get; set; }
        [Column("ADATE", TypeName = "datetime")]
        public DateTime? Adate { get; set; }
        [Column("MODE")]
        [StringLength(25)]
        public string Mode { get; set; }
    }
}
