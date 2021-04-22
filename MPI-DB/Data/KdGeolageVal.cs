using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MPI_DB.Data
{
    [Table("kd_geolage_val", Schema = "kd")]
    public partial class KdGeolageVal
    {
        [Column("id_kd_geolage")]
        public int? IdKdGeolage { get; set; }
        [Column("id_kadastr")]
        public int? IdKadastr { get; set; }
        [Column("pafrom")]
        [StringLength(50)]
        public string Pafrom { get; set; }
        [Column("afrom")]
        [StringLength(50)]
        public string Afrom { get; set; }
        [Column("pato")]
        [StringLength(50)]
        public string Pato { get; set; }
        [Column("ato")]
        [StringLength(50)]
        public string Ato { get; set; }
    }
}
