using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MPI_DB.Data
{
    [Table("skd_rud_distrib", Schema = "kd")]
    public partial class SkdRudDistrib
    {
        public SkdRudDistrib()
        {
            KdPi = new HashSet<KdPi>();
        }

        [Key]
        [Column("rud_distrib_id")]
        public short RudDistribId { get; set; }
        [Column("name")]
        [StringLength(50)]
        public string Name { get; set; }

        [InverseProperty("RudDistrib")]
        public virtual ICollection<KdPi> KdPi { get; set; }
    }
}
