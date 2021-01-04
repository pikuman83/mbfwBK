using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mbfwAPI.Models
{
    [Keyless]
    [Table("Employee")]
    public partial class Employee
    {
        [Column("ECode")]
        [StringLength(13)]
        public string Ecode { get; set; }
        [Column("UCODE")]
        [StringLength(13)]
        public string Ucode { get; set; }
        [Column("EName")]
        [StringLength(150)]
        public string Ename { get; set; }
        [Column("FName")]
        [StringLength(150)]
        public string Fname { get; set; }
        [Column("BDATE", TypeName = "datetime")]
        public DateTime? Bdate { get; set; }
        [Column("NIC")]
        [StringLength(25)]
        public string Nic { get; set; }
        [Column("MOBNO")]
        [StringLength(100)]
        public string Mobno { get; set; }
        [Column("DCode")]
        [StringLength(3)]
        public string Dcode { get; set; }
        [Column("DPCode")]
        [StringLength(3)]
        public string Dpcode { get; set; }
        [Column("dpcodeSub")]
        [StringLength(5)]
        public string DpcodeSub { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ApDate { get; set; }
        [Column("EStat")]
        public int? Estat { get; set; }
        public int? Active { get; set; }
        [Column("STATUS")]
        [StringLength(2)]
        public string Status { get; set; }
        [Column("ADDR")]
        [StringLength(250)]
        public string Addr { get; set; }
        [Column("REF")]
        [StringLength(250)]
        public string Ref { get; set; }
        [Column("AGE")]
        [StringLength(10)]
        public string Age { get; set; }
        [Column("cECN1Name")]
        [StringLength(250)]
        public string CEcn1name { get; set; }
        [Column("cECN1Rel")]
        [StringLength(250)]
        public string CEcn1rel { get; set; }
        [Column("cECN1Add")]
        [StringLength(250)]
        public string CEcn1add { get; set; }
        [Column("cECN1Tel")]
        [StringLength(250)]
        public string CEcn1tel { get; set; }
        [Column("cECN2Name")]
        [StringLength(250)]
        public string CEcn2name { get; set; }
        [Column("cECN2Rel")]
        [StringLength(250)]
        public string CEcn2rel { get; set; }
        [Column("cECN2Add")]
        [StringLength(250)]
        public string CEcn2add { get; set; }
        [Column("cECN2Tel")]
        [StringLength(250)]
        public string CEcn2tel { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CurDate { get; set; }
        [StringLength(2000)]
        public string Experience { get; set; }
        [Column("PJCODE")]
        [StringLength(10)]
        public string Pjcode { get; set; }
        [Column("PJNAME")]
        [StringLength(100)]
        public string Pjname { get; set; }
        [StringLength(50)]
        public string FileName { get; set; }
    }
}
