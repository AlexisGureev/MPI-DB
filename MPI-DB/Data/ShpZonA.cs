using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NetTopologySuite.Geometries;

namespace MPI_DB.Data
{
    [Table("shp_zon_a")]
    public partial class ShpZonA
    {
        [Column("gid")]
        public int? Gid { get; set; }
        [Column("part")]
        [StringLength(10)]
        public string Part { get; set; }
        [Column("rang")]
        public short? Rang { get; set; }
        [Column("index_")]
        [StringLength(50)]
        public string Index { get; set; }
        [Column("ds")]
        [StringLength(10)]
        public string Ds { get; set; }
        [Column("gr_pi")]
        [StringLength(10)]
        public string GrPi { get; set; }
        [Column("exist")]
        [StringLength(10)]
        public string Exist { get; set; }
        [Column("name_ru")]
        [StringLength(150)]
        public string NameRu { get; set; }
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
        [Column("name")]
        [StringLength(50)]
        public string Name { get; set; }
        [Column("pers")]
        [StringLength(30)]
        public string Pers { get; set; }
        [Column("id_age", TypeName = "numeric")]
        public decimal? IdAge { get; set; }
        [Column("geom", TypeName = "geometry(MultiPolygon,100003)")]
        public MultiPolygon Geom { get; set; }
        [Column("ar_id")]
        public int? ArId { get; set; }
        [Column("mpi_cnt")]
        public int? MpiCnt { get; set; }
        [Column("l_code", TypeName = "numeric(4,0)")]
        public decimal? LCode { get; set; }
    }
}
