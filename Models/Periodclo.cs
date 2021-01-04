using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Keyless]
    [Table("PERIODCLOS")]
    public partial class Periodclo
    {
        [Column("PERIOD")]
        [StringLength(2)]
        public string Period { get; set; }
        [Column("EDATE", TypeName = "datetime")]
        public DateTime? Edate { get; set; }
    }
}
