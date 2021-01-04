using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Keyless]
    [Table("PERIOD")]
    public partial class Period
    {
        [Column("PERIOD")]
        [StringLength(2)]
        public string Period1 { get; set; }
        [Column("SDATE", TypeName = "datetime")]
        public DateTime? Sdate { get; set; }
        [Column("EDATE", TypeName = "datetime")]
        public DateTime? Edate { get; set; }
    }
}
