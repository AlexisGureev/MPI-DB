using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MPI_DB.Data
{
    [Table("skd_geolage", Schema = "kd")]
    public partial class SkdGeolage
    {
        public SkdGeolage()
        {
            InverseParent = new HashSet<SkdGeolage>();
            KdGeolageGeolageFrom = new HashSet<KdGeolage>();
            KdGeolageGeolageTo = new HashSet<KdGeolage>();
        }

        [Key]
        [Column("geolage_id")]
        public int GeolageId { get; set; }
        [Column("parent_id")]
        public int? ParentId { get; set; }
        [Column("name")]
        [StringLength(50)]
        public string Name { get; set; }
        [Column("geolage_level_id")]
        public short? GeolageLevelId { get; set; }
        [Column("geolage_version_mask")]
        public int? GeolageVersionMask { get; set; }
        [Column("order_no")]
        public int? OrderNo { get; set; }
        [Column("hierarchy")]
        [StringLength(64)]
        public string Hierarchy { get; set; }
        [Column("ref_cnt")]
        public int? RefCnt { get; set; }
        [Column("ind")]
        [StringLength(50)]
        public string Ind { get; set; }
        [Column("color")]
        [StringLength(12)]
        public string Color { get; set; }
        [Column("ru_ind")]
        public string RuInd { get; set; }
        [Column("ind_ser")]
        public string IndSer { get; set; }
        [Column("gts_o_id")]
        public int? GtsOId { get; set; }
        [Column("gts_y_id")]
        public int? GtsYId { get; set; }

        [ForeignKey(nameof(ParentId))]
        [InverseProperty(nameof(SkdGeolage.InverseParent))]
        public virtual SkdGeolage Parent { get; set; }
        [InverseProperty(nameof(SkdGeolage.Parent))]
        public virtual ICollection<SkdGeolage> InverseParent { get; set; }
        [InverseProperty(nameof(KdGeolage.GeolageFrom))]
        public virtual ICollection<KdGeolage> KdGeolageGeolageFrom { get; set; }
        [InverseProperty(nameof(KdGeolage.GeolageTo))]
        public virtual ICollection<KdGeolage> KdGeolageGeolageTo { get; set; }
    }
}
