using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MPI_DB.Data
{
    [Table("sys_fldstxt", Schema = "dict")]
    public class sys_fldstxt
    {
        [Key]
        public string col_name { get; set; }
        public string col_lbl { get; set; }
    }
}
