using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MPI_DB.Data
{
    [Table("kd_pi", Schema = "kd")]
    public partial class KdPi
    {
        [Key]
        [Column("id_kd_pi")]
        public int IdKdPi { get; set; }
        [Column("id_kadastr")]
        public int? IdKadastr { get; set; }
        [Column("kd_ruda_id")]
        public short? KdRudaId { get; set; }
        [Column("rud_sulphid_id")]
        public short? RudSulphidId { get; set; }
        [Column("rud_oxid_id")]
        public short? RudOxidId { get; set; }
        [Column("rud_rich_id")]
        public short? RudRichId { get; set; }
        [Column("rud_quality_id")]
        public short? RudQualityId { get; set; }
        [Column("rud_solid_id")]
        public short? RudSolidId { get; set; }
        [Column("rud_distrib_id")]
        public short? RudDistribId { get; set; }
        [Column("uch_gbz_id")]
        public short? UchGbzId { get; set; }
        [Column("obogat_id")]
        public short? ObogatId { get; set; }
        [Column("rud_add")]
        [StringLength(100)]
        public string RudAdd { get; set; }
        [Column("dobicha", TypeName = "numeric(15,2)")]
        public decimal? Dobicha { get; set; }
        [Column("zapas_skl", TypeName = "numeric(15,2)")]
        public decimal? ZapasSkl { get; set; }
        [Column("change_date", TypeName = "timestamp(3) without time zone")]
        public DateTime? ChangeDate { get; set; }
        [Column("insert_date", TypeName = "timestamp(3) without time zone")]
        public DateTime? InsertDate { get; set; }
        [Column("owner")]
        [StringLength(32)]
        public string Owner { get; set; }
        [Column("source_id")]
        public int? SourceId { get; set; }
        [Column("id_kd_listpi")]
        public int? IdKdListpi { get; set; }
        [Column("j_ptr", TypeName = "numeric(15,2)")]
        public decimal? JPtr { get; set; }
        [Column("owner_insert")]
        [StringLength(32)]
        public string OwnerInsert { get; set; }
        [Column("full_name_calc123")]
        [StringLength(255)]
        public string FullNameCalc123 { get; set; }
        [Column("full_name")]
        [StringLength(255)]
        public string FullName { get; set; }

        [ForeignKey(nameof(IdKadastr))]
        [InverseProperty(nameof(Kadastr.KdPi))]
        public virtual Kadastr IdKadastrNavigation { get; set; }
        [ForeignKey(nameof(IdKdListpi))]
        [InverseProperty(nameof(KdListpi.KdPi))]
        public virtual KdListpi IdKdListpiNavigation { get; set; }
        [ForeignKey(nameof(KdRudaId))]
        [InverseProperty(nameof(SkdRuda.KdPi))]
        public virtual SkdRuda KdRuda { get; set; }
        [ForeignKey(nameof(RudDistribId))]
        [InverseProperty(nameof(SkdRudDistrib.KdPi))]
        public virtual SkdRudDistrib RudDistrib { get; set; }
        [ForeignKey(nameof(RudOxidId))]
        [InverseProperty(nameof(SkdRudOxid.KdPi))]
        public virtual SkdRudOxid RudOxid { get; set; }
        [ForeignKey(nameof(RudQualityId))]
        [InverseProperty(nameof(SkdRudQuality.KdPi))]
        public virtual SkdRudQuality RudQuality { get; set; }
        [ForeignKey(nameof(RudRichId))]
        [InverseProperty(nameof(SkdRudRich.KdPi))]
        public virtual SkdRudRich RudRich { get; set; }
    }
}
