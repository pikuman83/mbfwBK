using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Table("PORDER1")]
    public partial class Porder1
    {
        [Key]
        [Column("NO")]
        public int No { get; set; }
        [Column("VDATE", TypeName = "datetime")]
        public DateTime? Vdate { get; set; }
        [Column("VCODE")]
        [StringLength(10)]
        public string Vcode { get; set; }
        [Column("TOTAL")]
        public double? Total { get; set; }
        [Column("DISCOUNT")]
        public double? Discount { get; set; }
        [Column("VNAME")]
        [StringLength(150)]
        public string Vname { get; set; }
        [Column("ADDR")]
        [StringLength(250)]
        public string Addr { get; set; }
        [Column("DESCR")]
        [StringLength(250)]
        public string Descr { get; set; }
        [Column("VNO")]
        [StringLength(15)]
        public string Vno { get; set; }
        [Column("PCODE")]
        [StringLength(10)]
        public string Pcode { get; set; }
        [Column("PRNAME")]
        [StringLength(150)]
        public string Prname { get; set; }
        [Column("STAMT")]
        public double? Stamt { get; set; }
        [Column("NET")]
        public double? Net { get; set; }
        [Column("PONO")]
        public int? Pono { get; set; }
        [Column("OPBAL")]
        public double? Opbal { get; set; }
        [Column("CBAL")]
        public double? Cbal { get; set; }
        [Column("GDCODE")]
        [StringLength(10)]
        public string Gdcode { get; set; }
        [Column("GDNAME")]
        [StringLength(100)]
        public string Gdname { get; set; }
        [Column("FREIGHT")]
        [StringLength(50)]
        public string Freight { get; set; }
        [Column("EUSER")]
        [StringLength(25)]
        public string Euser { get; set; }
        [Column("PRDCODE")]
        [StringLength(25)]
        public string Prdcode { get; set; }
        [Column("PRDNAME")]
        [StringLength(150)]
        public string Prdname { get; set; }
        [Column("DQTY")]
        [StringLength(250)]
        public string Dqty { get; set; }
        [Column("PJCODE")]
        [StringLength(10)]
        public string Pjcode { get; set; }
        [Column("PJNAME")]
        [StringLength(50)]
        public string Pjname { get; set; }
        [Column("SPECIAL")]
        [StringLength(250)]
        public string Special { get; set; }
        [Column("DELIVERY")]
        [StringLength(250)]
        public string Delivery { get; set; }
    }
}
