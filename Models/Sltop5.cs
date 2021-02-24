using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Keyless]
    public partial class Sltop5
    {
        [Column("QTY")]
        public double? Qty { get; set; }
        [Column("PNAME")]
        [StringLength(150)]
        public string Pname { get; set; }
    }
}
