using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Table("ACCOUNT")]
    public partial class Account
    {
        [Key]
        [Column("ACODE")]
        [StringLength(10)]
        public string Acode { get; set; }
        [Column("ANAME")]
        [StringLength(50)]
        public string Aname { get; set; }
        [Column("ATYPE")]
        public short? Atype { get; set; }
        [Column("ATPNAME")]
        [StringLength(15)]
        public string Atpname { get; set; }
        [Column("INTERF")]
        [StringLength(10)]
        public string Interf { get; set; }
        [Column("BAL")]
        public double? Bal { get; set; }
        [Column("AGNAME")]
        [StringLength(50)]
        public string Agname { get; set; }
        [Column("AGNAMESUB")]
        [StringLength(50)]
        public string Agnamesub { get; set; }
        [Column("ACTIV")]
        public short? Activ { get; set; }
    }
}
