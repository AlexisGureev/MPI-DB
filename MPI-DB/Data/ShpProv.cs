using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NetTopologySuite.Geometries;

namespace MPI_DB.Data
{
    [Table("shp_prov")]
    public partial class ShpProv
    {
        [Column("shp")]
        public Geometry Shp { get; set; }
        [Column("code")]
        [StringLength(10)]
        public string Code { get; set; }
        [Column("sp_code")]
        [StringLength(10)]
        public string SpCode { get; set; }
        [Column("name_ru")]
        [StringLength(150)]
        public string NameRu { get; set; }
        [Column("name_en")]
        [StringLength(150)]
        public string NameEn { get; set; }
        [Column("ord")]
        public int? Ord { get; set; }
    }
}
