using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MPI_DB.Data
{
    [Table("kd_zapaspi", Schema = "kd")]
    public partial class KdZapaspi
    {
        [Key]
        [Column("id_kd_zapaspi")]
        public int IdKdZapaspi { get; set; }
        [Column("id_kd_pi")]
        public int? IdKdPi { get; set; }
        [Column("change_date", TypeName = "timestamp(3) without time zone")]
        public DateTime? ChangeDate { get; set; }
        [Column("insert_date")]
        public string InsertDate { get; set; }
        [Column("owner")]
        [StringLength(32)]
        public string Owner { get; set; }
        [Column("id_kd_placer")]
        public int? IdKdPlacer { get; set; }
        [Column("source_id")]
        public int? SourceId { get; set; }
        [Column("zapas_ab", TypeName = "numeric(15,2)")]
        public decimal? ZapasAb { get; set; }
        [Column("zapas_abc1", TypeName = "numeric(15,2)")]
        public decimal? ZapasAbc1 { get; set; }
        [Column("zapas_c1", TypeName = "numeric(15,2)")]
        public decimal? ZapasC1 { get; set; }
        [Column("zapas_c2", TypeName = "numeric(15,2)")]
        public decimal? ZapasC2 { get; set; }
        [Column("zapas_zab", TypeName = "numeric(15,2)")]
        public decimal? ZapasZab { get; set; }
        [Column("zapas_cont", TypeName = "numeric(15,2)")]
        public decimal? ZapasCont { get; set; }
        [Column("utv_abc1", TypeName = "numeric(15,2)")]
        public decimal? UtvAbc1 { get; set; }
        [Column("utv_c2", TypeName = "numeric(15,2)")]
        public decimal? UtvC2 { get; set; }
        [Column("ost_abc1", TypeName = "numeric(15,2)")]
        public decimal? OstAbc1 { get; set; }
        [Column("j_ed_izm_id")]
        public short? JEdIzmId { get; set; }
        [Column("owner_insert")]
        [StringLength(32)]
        public string OwnerInsert { get; set; }
    }
}
