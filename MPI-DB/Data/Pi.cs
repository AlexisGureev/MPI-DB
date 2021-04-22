using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MPI_DB.Data
{
    [Table("pi")]
    public partial class Pi
    {
        [Key]
        [Column("code")]
        [StringLength(50)]
        public string Code { get; set; }
        [Column("val_ru")]
        [StringLength(70)]
        public string ValRu { get; set; }
        [Column("val_en")]
        [StringLength(70)]
        public string ValEn { get; set; }
        [Column("gr")]
        [StringLength(100)]
        public string Gr { get; set; }
    }
}
