using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Keyless]
    [Table("Dept")]
    public partial class Dept
    {
        [Column("DPCode")]
        [StringLength(3)]
        public string Dpcode { get; set; }
        [Column("DPName")]
        [StringLength(30)]
        public string Dpname { get; set; }
    }
}
