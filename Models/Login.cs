using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Keyless]
    [Table("login")]
    public partial class Login
    {
        [Column("usernm")]
        [StringLength(20)]
        public string Usernm { get; set; }
        [Column("PASSWRD")]
        [StringLength(20)]
        public string Passwrd { get; set; }
        [Column("TYPE")]
        public short? Type { get; set; }
    }
}
