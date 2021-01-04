using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Table("TRANSPORT")]
    public partial class Transport
    {
        [Key]
        [Column("TCODE")]
        public short Tcode { get; set; }
        [Column("TNAME")]
        [StringLength(50)]
        public string Tname { get; set; }
        [Column("TADDR")]
        [StringLength(50)]
        public string Taddr { get; set; }
        [Column("TCITY")]
        [StringLength(40)]
        public string Tcity { get; set; }
        [Column("OCITY")]
        [StringLength(40)]
        public string Ocity { get; set; }
        [Column("TTEL")]
        [StringLength(30)]
        public string Ttel { get; set; }
        [Column("TMOB")]
        [StringLength(30)]
        public string Tmob { get; set; }
        [Column("UTNAME")]
        [StringLength(300)]
        public string Utname { get; set; }
        [Column("bilty")]
        [StringLength(300)]
        public string Bilty { get; set; }
        [Column("adda")]
        [StringLength(300)]
        public string Adda { get; set; }
    }
}
