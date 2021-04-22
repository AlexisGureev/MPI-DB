using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NetTopologySuite.Geometries;

namespace MPI_DB.Data
{
    [Table("shp_kno_a")]
    public partial class ShpKnoA
    {
        [Column("l_code")]
        public string LCode { get; set; }
        [Column("gid")]
        public int? Gid { get; set; }
        [Column("part")]
        [StringLength(10)]
        public string Part { get; set; }
        [Column("rang")]
        public short? Rang { get; set; }
        [Column("exist")]
        [StringLength(10)]
        public string Exist { get; set; }
        [Column("index_")]
        [StringLength(20)]
        public string Index { get; set; }
        [Column("ds")]
        [StringLength(10)]
        public string Ds { get; set; }
        [Column("gr_pi")]
        [StringLength(10)]
        public string GrPi { get; set; }
        [Column("name_rus")]
        [StringLength(150)]
        public string NameRus { get; set; }
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
        [StringLength(60)]
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
        [Column("zon_id")]
        public int? ZonId { get; set; }
        [Column("mpi_cnt")]
        public int? MpiCnt { get; set; }
    }
}
