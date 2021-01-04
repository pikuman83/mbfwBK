using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Keyless]
    [Table("CHEQUES")]
    public partial class Cheque
    {
        [Column("VDATE", TypeName = "datetime")]
        public DateTime? Vdate { get; set; }
        [Column("DESCR")]
        [StringLength(250)]
        public string Descr { get; set; }
        [Column("BCODE")]
        [StringLength(15)]
        public string Bcode { get; set; }
        [Column("BNAME")]
        [StringLength(150)]
        public string Bname { get; set; }
        [Column("CHQNO")]
        [StringLength(50)]
        public string Chqno { get; set; }
        [Column("PDATE", TypeName = "datetime")]
        public DateTime? Pdate { get; set; }
        [Column("DEBIT")]
        public double? Debit { get; set; }
        [Column("POSS")]
        [StringLength(150)]
        public string Poss { get; set; }
        [Column("CHQDT", TypeName = "datetime")]
        public DateTime? Chqdt { get; set; }
        [Column("CANAME")]
        [StringLength(150)]
        public string Caname { get; set; }
        [Column("CACODE")]
        [StringLength(50)]
        public string Cacode { get; set; }
        [Column("NO")]
        public int? No { get; set; }
    }
}
