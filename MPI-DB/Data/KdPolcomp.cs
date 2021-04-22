using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MPI_DB.Data
{
    [Table("kd_polcomp", Schema = "kd")]
    public partial class KdPolcomp
    {
        [Key]
        [Column("id_kd_polcomp")]
        public int IdKdPolcomp { get; set; }
        [Column("id_kadastr")]
        public int? IdKadastr { get; set; }
        [Column("type_obj_pi")]
        public short? TypeObjPi { get; set; }
        [Column("f_vskr")]
        public short? FVskr { get; set; }
        [Column("uch_gbz_id")]
        public short? UchGbzId { get; set; }
        [Column("mineable_id")]
        public short? MineableId { get; set; }
        [Column("ed_izm_id")]
        public short? EdIzmId { get; set; }
        [Column("dobicha", TypeName = "numeric(15,3)")]
        public decimal? Dobicha { get; set; }
        [Column("zapas_skl", TypeName = "numeric(15,3)")]
        public decimal? ZapasSkl { get; set; }
        [Column("change_date", TypeName = "timestamp(3) without time zone")]
        public DateTime? ChangeDate { get; set; }
        [Column("insert_date")]
        public string InsertDate { get; set; }
        [Column("owner")]
        [StringLength(32)]
        public string Owner { get; set; }
        [Column("ptr", TypeName = "numeric(15,3)")]
        public decimal? Ptr { get; set; }
        [Column("zapas_use_id")]
        public short? ZapasUseId { get; set; }
        [Column("order_no")]
        public int? OrderNo { get; set; }
        [Column("source_id")]
        public int? SourceId { get; set; }
        [Column("pk_add")]
        [StringLength(100)]
        public string PkAdd { get; set; }
        [Column("id_kd_listpi")]
        public int? IdKdListpi { get; set; }
        [Column("id_kd_coaluse")]
        public int? IdKdCoaluse { get; set; }
        [Column("id_kd_coalsort")]
        public int? IdKdCoalsort { get; set; }
        [Column("owner_insert")]
        [StringLength(32)]
        public string OwnerInsert { get; set; }
        [Column("f_zapas")]
        public bool? FZapas { get; set; }
        [Column("utv_order_no")]
        public int? UtvOrderNo { get; set; }

        [ForeignKey(nameof(IdKadastr))]
        [InverseProperty(nameof(Kadastr.KdPolcomp))]
        public virtual Kadastr IdKadastrNavigation { get; set; }
        [ForeignKey(nameof(IdKdListpi))]
        [InverseProperty(nameof(KdListpi.KdPolcomp))]
        public virtual KdListpi IdKdListpiNavigation { get; set; }
    }
}
