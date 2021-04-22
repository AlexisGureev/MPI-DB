using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MPI_DB.Data
{
    [Table("sys_fldstxt", Schema = "dict")]
    public partial class SysFldstxt
    {
        [Key]
        [Column("col_name", TypeName = "character varying")]
        public string ColName { get; set; }
        [Column("col_lbl")]
        public string ColLbl { get; set; }
    }
}
