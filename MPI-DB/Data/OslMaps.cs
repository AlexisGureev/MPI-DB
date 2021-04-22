using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NetTopologySuite.Geometries;

namespace MPI_DB.Data
{
    [Table("osl_maps")]
    public partial class OslMaps
    {
        [Key]
        [Column("code")]
        [StringLength(70)]
        public string Code { get; set; }
        [Required]
        [Column("title")]
        [StringLength(250)]
        public string Title { get; set; }
        [Required]
        [Column("title_sh")]
        [StringLength(70)]
        public string TitleSh { get; set; }
        [Column("descr")]
        public string Descr { get; set; }
        [Column("area_geom", TypeName = "geometry(MultiPolygon)")]
        public MultiPolygon AreaGeom { get; set; }
    }
}
