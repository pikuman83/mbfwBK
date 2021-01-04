using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Keyless]
    [Table("VIEW2")]
    public partial class View2
    {
        [Column("MGNAME")]
        [StringLength(25)]
        public string Mgname { get; set; }
        [Column("NO")]
        public short? No { get; set; }
        [Column("QTY")]
        public double? Qty { get; set; }
        [Column("LES1")]
        public double? Les1 { get; set; }
        [Column("LES2")]
        public double? Les2 { get; set; }
    }
}
