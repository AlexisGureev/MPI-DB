using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NetTopologySuite.Geometries;

namespace MPI_DB.Data
{
    [Table("deposit1810")]
    public partial class Deposit1810
    {
        public Deposit1810()
        {
            T2Geolunits = new HashSet<T2Geolunits>();
            T3Rock = new HashSet<T3Rock>();
            T4OreBody = new HashSet<T4OreBody>();
            T5Mineral = new HashSet<T5Mineral>();
            T6Reser = new HashSet<T6Reser>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("geom", TypeName = "geometry(Point,4326)")]
        public Point Geom { get; set; }
        [Column("mass")]
        [StringLength(10)]
        public string Mass { get; set; }
        [Column("name_mest")]
        [StringLength(254)]
        public string NameMest { get; set; }
        [Column("index_")]
        [StringLength(100)]
        public string Index { get; set; }
        [Column("main_id")]
        [StringLength(250)]
        public string MainId { get; set; }
        [Column("min_id")]
        [StringLength(254)]
        public string MinId { get; set; }
        [Column("vid_mest")]
        [StringLength(50)]
        public string VidMest { get; set; }
        [Column("raz_dep")]
        [StringLength(100)]
        public string RazDep { get; set; }
        [Column("gp_type")]
        [StringLength(150)]
        public string GpType { get; set; }
        [Column("u_balance")]
        [StringLength(250)]
        public string UBalance { get; set; }
        [Column("prom")]
        [StringLength(254)]
        public string Prom { get; set; }
        [Column("gr_i")]
        [StringLength(254)]
        public string GrI { get; set; }
        [Column("gr_ii")]
        [StringLength(254)]
        public string GrIi { get; set; }
        [Column("geotyp1")]
        [StringLength(254)]
        public string Geotyp1 { get; set; }
        [Column("geotyp2")]
        [StringLength(254)]
        public string Geotyp2 { get; set; }
        [Column("rud_form1")]
        [StringLength(254)]
        public string RudForm1 { get; set; }
        [Column("rud_form2")]
        [StringLength(254)]
        public string RudForm2 { get; set; }
        [Column("god_doc")]
        public int? GodDoc { get; set; }
        [Column("tgf")]
        [StringLength(254)]
        public string Tgf { get; set; }
        [Column("subrf_fo")]
        [StringLength(100)]
        public string SubrfFo { get; set; }
        [Column("subrf")]
        [StringLength(254)]
        public string Subrf { get; set; }
        [Column("subrf_admr")]
        [StringLength(254)]
        public string SubrfAdmr { get; set; }
        [Column("list_200")]
        [StringLength(50)]
        public string List200 { get; set; }
        [Column("latitude")]
        public double? Latitude { get; set; }
        [Column("longitude")]
        public double? Longitude { get; set; }
        [Column("min_pr")]
        [StringLength(254)]
        public string MinPr { get; set; }
        [Column("id_gbz")]
        public int? IdGbz { get; set; }
        [Column("id_size")]
        public int? IdSize { get; set; }
        [Column("id_gp_type")]
        public int? IdGpType { get; set; }
        [Column("subgr")]
        [StringLength(50)]
        public string Subgr { get; set; }
        [Column("os")]
        [StringLength(50)]
        public string Os { get; set; }
        [Column("kd_id")]
        public int KdId { get; set; }
        [Column("mdgid")]
        public int? Mdgid { get; set; }
        [Column("comm")]
        [StringLength(150)]
        public string Comm { get; set; }
        [Column("action_")]
        [StringLength(50)]
        public string Action { get; set; }
        [Column("url")]
        [StringLength(250)]
        public string Url { get; set; }
        [Column("mm_arr", TypeName = "character varying[]")]
        public string[] MmArr { get; set; }
        [Column("am_arr", TypeName = "character varying[]")]
        public string[] AmArr { get; set; }
        [Column("name_cmp")]
        [StringLength(150)]
        public string NameCmp { get; set; }
        [Column("m__id")]
        public int? MId { get; set; }
        [Column("join_rate")]
        public int? JoinRate { get; set; }
        [Column("join_dist")]
        public double? JoinDist { get; set; }
        [Column("ref_cnt")]
        public int? RefCnt { get; set; }
        [Column("isnd_id")]
        public int? IsndId { get; set; }
        [Column("rgf_pass")]
        [StringLength(50)]
        public string RgfPass { get; set; }
        [Column("rgf_mass")]
        [StringLength(10)]
        public string RgfMass { get; set; }
        [Column("rgf_num")]
        public int? RgfNum { get; set; }
        [Column("isnd_join_rate")]
        public int IsndJoinRate { get; set; }

        [ForeignKey(nameof(IsndId))]
        [InverseProperty(nameof(Kadastr.Deposit1810))]
        public virtual Kadastr Isnd { get; set; }
        [ForeignKey(nameof(MId))]
        [InverseProperty(nameof(Mpi.Deposit1810))]
        public virtual Mpi M { get; set; }
        [InverseProperty(nameof(Mpi.D))]
        public virtual Mpi MpiD { get; set; }
        public virtual Mpi MpiRgf { get; set; }
        public virtual ICollection<T2Geolunits> T2Geolunits { get; set; }
        public virtual ICollection<T3Rock> T3Rock { get; set; }
        public virtual ICollection<T4OreBody> T4OreBody { get; set; }
        public virtual ICollection<T5Mineral> T5Mineral { get; set; }
        public virtual ICollection<T6Reser> T6Reser { get; set; }
    }
}
