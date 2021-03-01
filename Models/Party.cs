using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Table("PARTY")]
    public partial class Party
    {
        [Key]
        [Column("VCODE")]
        [StringLength(15)]
        public string Vcode { get; set; }
        [Column("VCODEOLD")]
        [StringLength(15)]
        public string Vcodeold { get; set; }
        [Column("VCODE_NO")]
        public int? VcodeNo { get; set; }
        [Column("VNAME")]
        [StringLength(150)]
        public string Vname { get; set; }
        [Column("uvname")]
        [StringLength(250)]
        public string Uvname { get; set; }
        [Column("UFVNAME")]
        [StringLength(250)]
        public string Ufvname { get; set; }
        [Column("ADDR")]
        [StringLength(250)]
        public string Addr { get; set; }
        [Column("UADDR")]
        [StringLength(250)]
        public string Uaddr { get; set; }
        [Column("UVADDR")]
        [StringLength(250)]
        public string Uvaddr { get; set; }
        [Column("CITY")]
        [StringLength(50)]
        public string City { get; set; }
        [Column("AREA")]
        [StringLength(50)]
        public string Area { get; set; }
        [Column("LIMIT")]
        public double? Limit { get; set; }
        [Column("ATYPE")]
        public short? Atype { get; set; }
        [Column("ATYPNAME")]
        [StringLength(50)]
        public string Atypname { get; set; }
        [Column("CCODE")]
        public int? Ccode { get; set; }
        [Column("PGRP")]
        public int? Pgrp { get; set; }
        [Column("PGNAME")]
        [StringLength(50)]
        public string Pgname { get; set; }
        [Column("PERSON")]
        [StringLength(80)]
        public string Person { get; set; }
        [Column("TEL")]
        [StringLength(20)]
        public string Tel { get; set; }
        [Column("MOBILE")]
        [StringLength(20)]
        public string Mobile { get; set; }
        [Column("MOBILE1")]
        [StringLength(50)]
        public string Mobile1 { get; set; }
        [Column("MOBILE2")]
        [StringLength(50)]
        public string Mobile2 { get; set; }
        [Column("FAX")]
        [StringLength(20)]
        public string Fax { get; set; }
        [Column("MAIL")]
        [StringLength(50)]
        public string Mail { get; set; }
        [Column("SMCODE")]
        [StringLength(15)]
        public string Smcode { get; set; }
        [Column("SMNAME")]
        [StringLength(150)]
        public string Smname { get; set; }
        [Column("COMM")]
        public double? Comm { get; set; }
        [Column("MGRP")]
        public short? Mgrp { get; set; }
        [Column("MGNAME")]
        [StringLength(50)]
        public string Mgname { get; set; }
        [Column("ACTIV")]
        public short? Activ { get; set; }
        [Column("TCODE")]
        public int? Tcode{ get; set; }

        [Column("TNAME")]
        [StringLength(50)]
        public string Tname { get; set; }
    }
}
