using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Keyless]
    [Table("PRDID")]
    public partial class Prdid
    {
        [Column("PRGID")]
        [StringLength(255)]
        public string Prgid { get; set; }
    }
}
