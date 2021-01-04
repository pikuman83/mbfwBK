using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Keyless]
    [Table("PAY_LN_PAYMENT")]
    public partial class PayLnPayment
    {
        [Column("VNO")]
        public int Vno { get; set; }
        [Column("VDATE", TypeName = "datetime")]
        public DateTime? Vdate { get; set; }
        [Column("ECODE")]
        [StringLength(10)]
        public string Ecode { get; set; }
        [Column("ENAME")]
        [StringLength(50)]
        public string Ename { get; set; }
        [Column("EDESIG")]
        [StringLength(50)]
        public string Edesig { get; set; }
        [Column("EDEPT")]
        [StringLength(50)]
        public string Edept { get; set; }
        [Column("LN_PAY_AMT")]
        public double? LnPayAmt { get; set; }
        [Column("ADV_PAY_AMT")]
        public double? AdvPayAmt { get; set; }
        [Column("VCODE")]
        [StringLength(10)]
        public string Vcode { get; set; }
        [Column("VNAME")]
        [StringLength(150)]
        public string Vname { get; set; }
    }
}
