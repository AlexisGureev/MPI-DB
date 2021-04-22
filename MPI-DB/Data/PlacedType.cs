using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MPI_DB.Data
{
    [Table("placed_type", Schema = "dict")]
    public partial class PlacedType
    {
        public PlacedType()
        {
            Mpi = new HashSet<Mpi>();
        }

        [Key]
        [Column("id")]
        public char Id { get; set; }
        [Required]
        [Column("val_ru")]
        [StringLength(50)]
        public string ValRu { get; set; }
        [Required]
        [Column("val_en")]
        [StringLength(50)]
        public string ValEn { get; set; }

        [InverseProperty("TypeNavigation")]
        public virtual ICollection<Mpi> Mpi { get; set; }
    }
}
