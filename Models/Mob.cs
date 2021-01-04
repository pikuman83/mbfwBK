using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Keyless]
    [Table("MOB")]
    public partial class Mob
    {
        [Column("MOB")]
        [StringLength(50)]
        public string Mob1 { get; set; }
    }
}
