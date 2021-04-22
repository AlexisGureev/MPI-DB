using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MPI_DB.Data
{
    [Table("kd_geolage", Schema = "kd")]
    public partial class KdGeolage
    {
        [Key]
        [Column("id_kd_geolage")]
        public int IdKdGeolage { get; set; }
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

        [ForeignKey(nameof(GeolageFromId))]
        [InverseProperty(nameof(SkdGeolage.KdGeolageGeolageFrom))]
        public virtual SkdGeolage GeolageFrom { get; set; }
        [ForeignKey(nameof(GeolageToId))]
        [InverseProperty(nameof(SkdGeolage.KdGeolageGeolageTo))]
        public virtual SkdGeolage GeolageTo { get; set; }
        [ForeignKey(nameof(IdKadastr))]
        [InverseProperty(nameof(Kadastr.KdGeolage))]
        public virtual Kadastr IdKadastrNavigation { get; set; }
    }
}
