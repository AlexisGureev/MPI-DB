using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MPI_DB.Data
{
    [Table("repl_age")]
    public partial class ReplAge
    {
        [Column("age_smb")]
        [StringLength(50)]
        public string AgeSmb { get; set; }
        [Column("?column?")]
        public string Column { get; set; }
    }
}
