using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MPI_DB.Data
{
    [Table("skd_rud_oxid", Schema = "kd")]
    public partial class SkdRudOxid
    {
        public SkdRudOxid()
        {
            KdPi = new HashSet<KdPi>();
        }

        [Key]
        [Column("rud_oxid_id")]
        public short RudOxidId { get; set; }
        [Column("name")]
        [StringLength(50)]
        public string Name { get; set; }

        [InverseProperty("RudOxid")]
        public virtual ICollection<KdPi> KdPi { get; set; }
    }
}
