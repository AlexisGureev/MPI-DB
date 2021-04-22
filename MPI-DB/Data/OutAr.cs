using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NetTopologySuite.Geometries;

namespace MPI_DB.Data
{
    [Table("out_ar")]
    public partial class OutAr
    {
        [Column("u0")]
        [StringLength(10)]
        public string U0 { get; set; }
        [Column("sp_indx_en")]
        [StringLength(10)]
        public string SpIndxEn { get; set; }
        [Column("sp_nm_ru")]
        [StringLength(150)]
        public string SpNmRu { get; set; }
        [Column("sp_nm_en")]
        [StringLength(150)]
        public string SpNmEn { get; set; }
        [Column("pr_indx_en")]
        [StringLength(10)]
        public string PrIndxEn { get; set; }
        [Column("pr_nm_ru")]
        [StringLength(150)]
        public string PrNmRu { get; set; }
        [Column("pr_nm_en")]
        [StringLength(150)]
        public string PrNmEn { get; set; }
        [Column("gid")]
        public int? Gid { get; set; }
        [Column("pr_code")]
        [StringLength(20)]
        public string PrCode { get; set; }
        [Column("ind_ar_en")]
        [StringLength(20)]
        public string IndArEn { get; set; }
        [Column("nm_ar_en")]
        [StringLength(100)]
        public string NmArEn { get; set; }
        [Column("nm_ar_ru")]
        [StringLength(100)]
        public string NmArRu { get; set; }
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
