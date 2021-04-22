using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MPI_DB.Data
{
    [Table("t6_reser")]
    public partial class T6Reser
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("SUBRF_FO")]
        [StringLength(254)]
        public string SubrfFo { get; set; }
        [Column("SUBRF")]
        [StringLength(254)]
        public string Subrf { get; set; }
        [Column("Code_M")]
        public double? CodeM { get; set; }
        [Column("GEN_TYPE")]
        [StringLength(254)]
        public string GenType { get; set; }
        [Column("NAME_MEST")]
        [StringLength(254)]
        public string NameMest { get; set; }
        [Column("BN")]
        [StringLength(254)]
        public string Bn { get; set; }
        [Column("PROM")]
        [StringLength(254)]
        public string Prom { get; set; }
        [Column("TGF")]
        [StringLength(254)]
        public string Tgf { get; set; }
        [Column("MAIN_COMP")]
        [StringLength(254)]
        public string MainComp { get; set; }
        [Column("RAZMER_M")]
        [StringLength(254)]
        public string RazmerM { get; set; }
        [Column("RAZMER_D")]
        [StringLength(254)]
        public string RazmerD { get; set; }
        [Column("VID_BALANC")]
        [StringLength(254)]
        public string VidBalanc { get; set; }
        [Column("ID_KADASTR")]
        public int? IdKadastr { get; set; }
        [Column("Comp_")]
        [StringLength(254)]
        public string Comp { get; set; }
        [Column("ED_R")]
        [StringLength(254)]
        public string EdR { get; set; }
        [Column("ED_COMP")]
        [StringLength(254)]
        public string EdComp { get; set; }
        public double? Xcomp { get; set; }
        [Column("ED_X")]
        [StringLength(254)]
        public string EdX { get; set; }
        [StringLength(254)]
        public string Примечание { get; set; }
        [Column("ABC1rud")]
        public double? Abc1rud { get; set; }
        [Column("ABC1comp")]
        public double? Abc1comp { get; set; }
        public double? C2rud { get; set; }
        public double? C2comp { get; set; }
        [Column("ZABAL_RUD")]
        public double? ZabalRud { get; set; }
        [Column("ZABAL_COMP")]
        public double? ZabalComp { get; set; }
        [Column("VID_BAL")]
        [StringLength(254)]
        public string VidBal { get; set; }
        [Column("kd_id")]
        public int? KdId { get; set; }

        public virtual Deposit1810 Kd { get; set; }
    }
}
