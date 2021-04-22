using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MPI_DB.Data
{
    [Table("mpi_out_2")]
    public partial class MpiOut2
    {
        [Column("x")]
        public double? X { get; set; }
        [Column("y")]
        public double? Y { get; set; }
        [Column("l_code", TypeName = "numeric(10,0)")]
        public decimal? LCode { get; set; }
        [Column("din")]
        [StringLength(50)]
        public string Din { get; set; }
        [Column("sheet")]
        public string Sheet { get; set; }
    }
}
