using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MPI_DB.Data
{
    [Table("skd_rud_rich", Schema = "kd")]
    public partial class SkdRudRich
    {
        public SkdRudRich()
        {
            KdPi = new HashSet<KdPi>();
        }

        [Key]
        [Column("rud_rich_id")]
        public short RudRichId { get; set; }
        [Column("name")]
        [StringLength(50)]
        public string Name { get; set; }

        [InverseProperty("RudRich")]
        public virtual ICollection<KdPi> KdPi { get; set; }
    }
}
