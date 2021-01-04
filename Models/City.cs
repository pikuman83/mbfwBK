using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Table("CITY")]
    public partial class City
    {
        [Key]
        [Column("CCODE")]
        public int Ccode { get; set; }
        [Column("CNAME")]
        [StringLength(35)]
        public string Cname { get; set; }
    }
}
