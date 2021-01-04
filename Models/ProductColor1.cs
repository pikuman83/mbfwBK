using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Keyless]
    [Table("PRODUCT_COLOR1")]
    public partial class ProductColor1
    {
        [Column("PCODE")]
        [StringLength(25)]
        public string Pcode { get; set; }
        [Column("COLOR")]
        [StringLength(20)]
        public string Color { get; set; }
    }
}
