using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Keyless]
    [Table("PLS")]
    public partial class Pl
    {
        [Column("SALES")]
        public double? Sales { get; set; }
        [Column("COGS")]
        public double? Cogs { get; set; }
        [Column("EXPENSES")]
        public double? Expenses { get; set; }
        [Column("PRODUCTION")]
        public double? Production { get; set; }
        [Column("RECOVERY")]
        public double? Recovery { get; set; }
    }
}
