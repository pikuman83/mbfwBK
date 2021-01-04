﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Table("CASHRCP")]
    public partial class Cashrcp
    {
        [Column("NO")]
        public int? No { get; set; }
        [Column("VDATE", TypeName = "datetime")]
        public DateTime? Vdate { get; set; }
        [Column("CACODE")]
        [StringLength(10)]
        public string Cacode { get; set; }
        [Column("CANAME")]
        [StringLength(150)]
        public string Caname { get; set; }
        [Column("ACODE")]
        [StringLength(20)]
        public string Acode { get; set; }
        [Column("ANAME")]
        [StringLength(150)]
        public string Aname { get; set; }
        [Column("DESCR")]
        [StringLength(250)]
        public string Descr { get; set; }
        [Column("DEBIT")]
        public double? Debit { get; set; }
        [Column("EUSER")]
        [StringLength(25)]
        public string Euser { get; set; }
        [Column("SNO")]
        public int? Sno { get; set; }
        [Key]
        [Column("id")]
        public int Id { get; set; }
    }
}
