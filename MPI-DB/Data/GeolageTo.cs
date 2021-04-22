using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MPI_DB.Data
{
    [Table("geolage_to", Schema = "kd")]
    public partial class GeolageTo
    {
        [Column("id_kd_geolage")]
        public int? IdKdGeolage { get; set; }
        [Column("id_kadastr")]
        public int? IdKadastr { get; set; }
        [Column("geolage_from_id")]
        public int? GeolageFromId { get; set; }
        [Column("geolage_to_id")]
        public int? GeolageToId { get; set; }
        [Column("change_date", TypeName = "timestamp(3) without time zone")]
        public DateTime? ChangeDate { get; set; }
        [Column("insert_date")]
        public string InsertDate { get; set; }
        [Column("owner")]
        [StringLength(32)]
        public string Owner { get; set; }
        [Column("source_id")]
        public int? SourceId { get; set; }
        [Column("owner_insert")]
        [StringLength(32)]
        public string OwnerInsert { get; set; }
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
        [Column("ref_cnt")]
        public int? RefCnt { get; set; }
        [Column("ind")]
        [StringLength(50)]
        public string Ind { get; set; }
        [Column("color")]
        [StringLength(12)]
        public string Color { get; set; }
    }
}
