using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MPI_DB.Data
{
    [Table("dict_age", Schema = "kd")]
    public partial class DictAge
    {
        [Column("parent")]
        [StringLength(50)]
        public string Parent { get; set; }
        [Column("geolage_id")]
        public int? GeolageId { get; set; }
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
    }
}
