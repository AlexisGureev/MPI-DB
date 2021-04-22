using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MPI_DB.Data
{
    [Table("smas_gkm", Schema = "kd")]
    public partial class SmasGkm
    {
        [Key]
        [Column("code")]
        public short Code { get; set; }
        [Column("name")]
        [StringLength(10)]
        public string Name { get; set; }
    }
}
