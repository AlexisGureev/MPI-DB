using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NetTopologySuite.Geometries;

namespace MPI_DB.Data
{
    [Table("regions_ar")]
    public partial class RegionsAr
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        [StringLength(200)]
        public string Name { get; set; }
        [Column("cover")]
        [StringLength(200)]
        public string Cover { get; set; }
        [Column("geom", TypeName = "geometry(Polygon,4326)")]
        public Polygon Geom { get; set; }
    }
}
