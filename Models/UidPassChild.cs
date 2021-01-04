using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Keyless]
    [Table("UID_PASS_CHILD")]
    public partial class UidPassChild
    {
        [Column("u_login")]
        [StringLength(50)]
        public string ULogin { get; set; }
        [Column("frm_ID")]
        [StringLength(50)]
        public string FrmId { get; set; }
        [Column("FRM_NAME")]
        [StringLength(50)]
        public string FrmName { get; set; }
        [Column("frm_Main_Menu")]
        [StringLength(25)]
        public string FrmMainMenu { get; set; }
    }
}
