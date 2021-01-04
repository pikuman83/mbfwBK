using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Keyless]
    [Table("IMGPATH")]
    public partial class Imgpath
    {
        [Column("IMGPATH")]
        [StringLength(500)]
        public string Imgpath1 { get; set; }
    }
}
