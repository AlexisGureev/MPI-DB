using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NetTopologySuite.Geometries;

namespace MPI_DB.Data
{
    [Table("zones_a")]
    public partial class ZonesA
    {
        [Key]
        [Column("id")]
        public double Id { get; set; }
        [Column("geom", TypeName = "geometry(MultiPolygon)")]
        public MultiPolygon Geom { get; set; }
        [Column("rang")]
        public double? Rang { get; set; }
        [Column("exist")]
        [StringLength(10)]
        public string Exist { get; set; }
        [Column("index_")]
        [StringLength(50)]
        public string Index { get; set; }
        [Column("name")]
        [StringLength(50)]
        public string Name { get; set; }
        [Column("ds")]
        [StringLength(10)]
        public string Ds { get; set; }
        [Column("gr_pi")]
        [StringLength(10)]
        public string GrPi { get; set; }
        [Column("pi")]
        [StringLength(150)]
        public string Pi { get; set; }
        [Column("pi_dop")]
        [StringLength(150)]
        public string PiDop { get; set; }
        [Column("age")]
        [StringLength(25)]
        public string Age { get; set; }
        [Column("age_dop")]
        [StringLength(25)]
        public string AgeDop { get; set; }
        [Column("pers")]
        [StringLength(30)]
        public string Pers { get; set; }
        [Column("shape_leng")]
        public double? ShapeLeng { get; set; }
        [Column("shape_area")]
        public double? ShapeArea { get; set; }
    }
}
