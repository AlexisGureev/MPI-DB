using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MPI_DB.Data
{
    [Table("ore_quality", Schema = "dict")]
    public partial class OreQuality
    {
        public OreQuality()
        {
            Mpi = new HashSet<Mpi>();
        }

        [Key]
        [Column("code")]
        [StringLength(1)]
        public string Code { get; set; }
        [Column("leg_ru")]
        [StringLength(255)]
        public string LegRu { get; set; }
        [Column("leg_en")]
        [StringLength(255)]
        public string LegEn { get; set; }
        [Column("k_oq")]
        public int? KOq { get; set; }

        [InverseProperty("OqNavigation")]
        public virtual ICollection<Mpi> Mpi { get; set; }
    }
}
