using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MPI_DB.Data
{
    [Table("kd_listpilist", Schema = "kd")]
    public partial class KdListpilist
    {
        [Key]
        [Column("id_kd_listpilist")]
        public int IdKdListpilist { get; set; }
        [Column("kd_polisk_id")]
        public short? KdPoliskId { get; set; }
        [Column("polisksostav_id")]
        public short? PolisksostavId { get; set; }
        [Column("color_id")]
        public short? ColorId { get; set; }
        [Column("strata_grain_id")]
        public short? StrataGrainId { get; set; }
        [Column("intensity_id")]
        public short? IntensityId { get; set; }
        [Column("strata_change_id")]
        public short? StrataChangeId { get; set; }
        [Column("prim_pi_id")]
        public short? PrimPiId { get; set; }
        [Column("pi_add")]
        [StringLength(100)]
        public string PiAdd { get; set; }
        [Column("id_kd_listpi")]
        public int? IdKdListpi { get; set; }
        [Column("change_date", TypeName = "timestamp(3) without time zone")]
        public DateTime? ChangeDate { get; set; }
        [Column("insert_date")]
        public string InsertDate { get; set; }
        [Column("owner")]
        [StringLength(32)]
        public string Owner { get; set; }
        [Column("source_id")]
        public int? SourceId { get; set; }
        [Column("sp_otr_id")]
        public short? SpOtrId { get; set; }
        [Column("owner_insert")]
        [StringLength(32)]
        public string OwnerInsert { get; set; }

        [ForeignKey(nameof(IdKdListpi))]
        [InverseProperty(nameof(KdListpi.KdListpilist))]
        public virtual KdListpi IdKdListpiNavigation { get; set; }
        [ForeignKey(nameof(KdPoliskId))]
        [InverseProperty(nameof(SkdPolisk.KdListpilist))]
        public virtual SkdPolisk KdPolisk { get; set; }
    }
}
