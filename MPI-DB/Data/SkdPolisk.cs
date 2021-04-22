using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MPI_DB.Data
{
    [Table("skd_polisk", Schema = "kd")]
    public partial class SkdPolisk
    {
        public SkdPolisk()
        {
            KdListpilist = new HashSet<KdListpilist>();
        }

        [Key]
        [Column("kd_polisk_id")]
        public short KdPoliskId { get; set; }
        [Column("name")]
        [StringLength(100)]
        public string Name { get; set; }
        [Column("polcomp_ei_id")]
        public short? PolcompEiId { get; set; }
        [Column("gas_vid_id")]
        public short? GasVidId { get; set; }
        [Column("chemical")]
        [StringLength(10)]
        public string Chemical { get; set; }
        [Column("gkm_mask")]
        public int? GkmMask { get; set; }
        [Column("gender")]
        public char? Gender { get; set; }
        [Column("f_zapas_rud")]
        public bool? FZapasRud { get; set; }

        [InverseProperty("KdPolisk")]
        public virtual ICollection<KdListpilist> KdListpilist { get; set; }
    }
}
