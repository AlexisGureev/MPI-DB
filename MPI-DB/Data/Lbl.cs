using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MPI_DB.Data
{
    [Table("lbl", Schema = "dict")]
    public partial class Lbl
    {
        [Column("lbl")]
        public string Lbl1 { get; set; }
        [Key]
        [Column("col")]
        public string Col { get; set; }
    }
}
