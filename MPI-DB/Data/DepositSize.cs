using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MPI_DB.Data
{
    [Table("deposit_size", Schema = "dict")]
    public partial class DepositSize
    {
        public DepositSize()
        {
            Mpi = new HashSet<Mpi>();
        }

        [Key]
        [Column("code")]
        [StringLength(10)]
        public string Code { get; set; }
        [Column("leg_ru")]
        [StringLength(255)]
        public string LegRu { get; set; }
        [Column("leg_en")]
        [StringLength(255)]
        public string LegEn { get; set; }
        [Column("k_ds")]
        public int? KDs { get; set; }

        [InverseProperty("DsNavigation")]
        public virtual ICollection<Mpi> Mpi { get; set; }
    }
}
