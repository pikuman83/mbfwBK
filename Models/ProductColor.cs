using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Table("PRODUCT_COLOR")]
    public partial class ProductColor
    {
        [Key]
        [Column("pcid")]
        public int Pcid { get; set; }
        [Column("pcode")]
        [StringLength(20)]
        public string Pcode { get; set; }
        [Column("color")]
        [StringLength(25)]
        public string Color { get; set; }
    }
}
