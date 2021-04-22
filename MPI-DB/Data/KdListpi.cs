using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MPI_DB.Data
{
    [Table("kd_listpi", Schema = "kd")]
    public partial class KdListpi
    {
        public KdListpi()
        {
            KdListpilist = new HashSet<KdListpilist>();
            KdPi = new HashSet<KdPi>();
            KdPolcomp = new HashSet<KdPolcomp>();
        }

        [Key]
        [Column("id_kd_listpi")]
        public int IdKdListpi { get; set; }
        [Column("name")]
        [StringLength(512)]
        public string Name { get; set; }
        [Column("edizmsod_id")]
        public short? EdizmsodId { get; set; }
        [Column("change_date", TypeName = "timestamp(3) without time zone")]
        public DateTime? ChangeDate { get; set; }
        [Column("insert_date")]
        public string InsertDate { get; set; }
        [Column("owner")]
        [StringLength(32)]
        public string Owner { get; set; }
        [Column("source_id")]
        public int? SourceId { get; set; }
        [Column("chemical")]
        [StringLength(255)]
        public string Chemical { get; set; }
        [Column("owner_insert")]
        [StringLength(32)]
        public string OwnerInsert { get; set; }
        [Column("f_temp")]
        public int? FTemp { get; set; }
        [Column("gkm_mask_calc123")]
        public int? GkmMaskCalc123 { get; set; }
        [Column("gkm_mask")]
        public int? GkmMask { get; set; }

        [InverseProperty("IdKdListpiNavigation")]
        public virtual ICollection<KdListpilist> KdListpilist { get; set; }
        [InverseProperty("IdKdListpiNavigation")]
        public virtual ICollection<KdPi> KdPi { get; set; }
        [InverseProperty("IdKdListpiNavigation")]
        public virtual ICollection<KdPolcomp> KdPolcomp { get; set; }
    }
}
