using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MPI_DB.Data
{
    [Table("mineral_group", Schema = "dict")]
    public partial class MineralGroup
    {
        public MineralGroup()
        {
            Mpi = new HashSet<Mpi>();
        }

        [Key]
        [Column("code")]
        [StringLength(5)]
        public string Code { get; set; }
        [Column("leg_ru")]
        [StringLength(150)]
        public string LegRu { get; set; }
        [Column("lag_eng")]
        [StringLength(150)]
        public string LagEng { get; set; }
        [Column("descr_ru")]
        public string DescrRu { get; set; }
        [Column("descr_en")]
        public string DescrEn { get; set; }
        [Column("valid")]
        [StringLength(1)]
        public string Valid { get; set; }
        [Column("lcode")]
        [StringLength(2)]
        public string Lcode { get; set; }
        [Column("gr_ii")]
        [StringLength(150)]
        public string GrIi { get; set; }

        [InverseProperty("MgNavigation")]
        public virtual ICollection<Mpi> Mpi { get; set; }
    }
}
