using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Table("PRODUCT2delete")]
    public partial class Product2delete
    {
        public Product2delete()
        {
            Service2s = new HashSet<Service2>();
        }

        [Key]
        [Column("PCODE")]
        [StringLength(15)]
        public string Pcode { get; set; }
        [Required]
        [Column("PNAME")]
        [StringLength(150)]
        public string Pname { get; set; }
        [Column("UNIT")]
        [StringLength(5)]
        public string Unit { get; set; }
        [Column("GROUP")]
        [StringLength(100)]
        public string Group { get; set; }

        [InverseProperty(nameof(Service2.PcodeNavigation))]
        public virtual ICollection<Service2> Service2s { get; set; }
    }
}
