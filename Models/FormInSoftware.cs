using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Keyless]
    [Table("FORM_IN_SOFTWARE")]
    public partial class FormInSoftware
    {
        [Column("frm_sno")]
        public int? FrmSno { get; set; }
        [Column("FRM_NAME")]
        [StringLength(50)]
        public string FrmName { get; set; }
        [Column("FRM_MENU_ID")]
        [StringLength(50)]
        public string FrmMenuId { get; set; }
        [Column("MENU_HEADING")]
        [StringLength(50)]
        public string MenuHeading { get; set; }
        [Column("Full_Access")]
        public short? FullAccess { get; set; }
        [Column("Manager_Level")]
        public short? ManagerLevel { get; set; }
        [Column("Advanced_User")]
        public short? AdvancedUser { get; set; }
        [Column("General_Staff")]
        public short? GeneralStaff { get; set; }
        [Column("View_Only")]
        public short? ViewOnly { get; set; }
    }
}
