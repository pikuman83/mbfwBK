using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Table("CUSTOMER")]
    public partial class Customer
    {
        public Customer()
        {
            Service1s = new HashSet<Service1>();
        }

        [Key]
        [Column("VCODE")]
        [StringLength(15)]
        public string Vcode { get; set; }
        [Column("VNAME")]
        [StringLength(150)]
        public string Vname { get; set; }
        [Column("ADDRESS")]
        [StringLength(250)]
        public string Address { get; set; }
        [Column("MOBILENO")]
        [StringLength(25)]
        public string Mobileno { get; set; }

        [InverseProperty(nameof(Service1.VcodeNavigation))]
        public virtual ICollection<Service1> Service1s { get; set; }
    }
}
