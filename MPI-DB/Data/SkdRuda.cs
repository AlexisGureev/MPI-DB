using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MPI_DB.Data
{
    [Table("skd_ruda", Schema = "kd")]
    public partial class SkdRuda
    {
        public SkdRuda()
        {
            KdPi = new HashSet<KdPi>();
        }

        [Key]
        [Column("kd_ruda_id")]
        public short KdRudaId { get; set; }
        [Column("parent_id")]
        public short? ParentId { get; set; }
        [Column("name")]
        [StringLength(255)]
        public string Name { get; set; }
        [Column("ed_izm_id")]
        public short? EdIzmId { get; set; }
        [Column("hierarchy")]
        [StringLength(64)]
        public string Hierarchy { get; set; }

        [InverseProperty("KdRuda")]
        public virtual ICollection<KdPi> KdPi { get; set; }
    }
}
