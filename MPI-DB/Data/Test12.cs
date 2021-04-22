using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NetTopologySuite.Geometries;

namespace MPI_DB.Data
{
    [Table("test12")]
    public partial class Test12
    {
        [Column("oz_code")]
        [StringLength(10)]
        public string OzCode { get; set; }
        [Column("oz_ord")]
        public int? OzOrd { get; set; }
        [Column("oz_name_en")]
        [StringLength(150)]
        public string OzNameEn { get; set; }
        [Column("sp_code")]
        [StringLength(10)]
        public string SpCode { get; set; }
        [Column("sp_ord")]
        public int? SpOrd { get; set; }
        [Column("sp_name_en")]
        [StringLength(150)]
        public string SpNameEn { get; set; }
        [Column("pr_code1")]
        [StringLength(10)]
        public string PrCode1 { get; set; }
        [Column("pr_ord")]
        public int? PrOrd { get; set; }
        [Column("pr_name_en")]
        [StringLength(150)]
        public string PrNameEn { get; set; }
        [Column("gid")]
        public int? Gid { get; set; }
        [Column("pr_code")]
        [StringLength(20)]
        public string PrCode { get; set; }
        [Column("code")]
        [StringLength(20)]
        public string Code { get; set; }
        [Column("name_en")]
        [StringLength(100)]
        public string NameEn { get; set; }
        [Column("name_ru")]
        [StringLength(100)]
        public string NameRu { get; set; }
        [Column("gr_pi_1")]
        [StringLength(5)]
        public string GrPi1 { get; set; }
        [Column("gr_pi_2")]
        [StringLength(5)]
        public string GrPi2 { get; set; }
        [Column("gr_pi")]
        [StringLength(10)]
        public string GrPi { get; set; }
        [Column("pi")]
        [StringLength(100)]
        public string Pi { get; set; }
        [Column("age")]
        [StringLength(100)]
        public string Age { get; set; }
        [Column("npp", TypeName = "numeric")]
        public decimal? Npp { get; set; }
        [Column("u1", TypeName = "numeric")]
        public decimal? U1 { get; set; }
        [Column("u2", TypeName = "numeric")]
        public decimal? U2 { get; set; }
        [Column("u3", TypeName = "numeric")]
        public decimal? U3 { get; set; }
        [Column("npp_m", TypeName = "numeric")]
        public decimal? NppM { get; set; }
        [Column("prod", TypeName = "numeric")]
        public decimal? Prod { get; set; }
        [Column("s")]
        public double? S { get; set; }
        [Column("geom", TypeName = "geometry(MultiPolygon,100003)")]
        public MultiPolygon Geom { get; set; }
    }
}
