using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Keyless]
    [Table("TRIAL")]
    public partial class Trial
    {
        [Column("ACODE")]
        [StringLength(25)]
        public string Acode { get; set; }
        [Column("ANAME")]
        [StringLength(150)]
        public string Aname { get; set; }
        [Column("DEBIT")]
        public double? Debit { get; set; }
        [Column("CREDIT")]
        public double? Credit { get; set; }
        [Column("ODEBIT")]
        public double? Odebit { get; set; }
        [Column("OCREDIT")]
        public double? Ocredit { get; set; }
        [Column("CDEBIT")]
        public double? Cdebit { get; set; }
        [Column("CCREDIT")]
        public double? Ccredit { get; set; }
        [Column("UACODE")]
        [StringLength(150)]
        public string Uacode { get; set; }
        [Column("UANAME")]
        [StringLength(150)]
        public string Uaname { get; set; }
    }
}
