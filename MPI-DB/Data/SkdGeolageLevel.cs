using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MPI_DB.Data
{
    [Table("skd_geolage_level", Schema = "kd")]
    public partial class SkdGeolageLevel
    {
        [Key]
        [Column("geolage_level_id")]
        public short GeolageLevelId { get; set; }
        [Column("name")]
        [StringLength(50)]
        public string Name { get; set; }
    }
}
