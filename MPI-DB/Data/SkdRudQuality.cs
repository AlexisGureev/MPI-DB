using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MPI_DB.Data
{
    [Table("skd_rud_quality", Schema = "kd")]
    public partial class SkdRudQuality
    {
        public SkdRudQuality()
        {
            KdPi = new HashSet<KdPi>();
        }

        [Key]
        [Column("rud_quality_id")]
        public short RudQualityId { get; set; }
        [Column("name")]
        [StringLength(50)]
        public string Name { get; set; }

        [InverseProperty("RudQuality")]
        public virtual ICollection<KdPi> KdPi { get; set; }
    }
}
