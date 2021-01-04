using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Keyless]
    [Table("SENT_SMS")]
    public partial class SentSm
    {
        [Column("NO")]
        public int? No { get; set; }
        [Column("JO")]
        [StringLength(10)]
        public string Jo { get; set; }
        [Column("ACODE")]
        [StringLength(10)]
        public string Acode { get; set; }
        [Column("ANAME")]
        [StringLength(250)]
        public string Aname { get; set; }
        [Column("CELLNO")]
        [StringLength(50)]
        public string Cellno { get; set; }
        [Column("MSGSTR")]
        [StringLength(250)]
        public string Msgstr { get; set; }
    }
}
