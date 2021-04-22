using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MPI_DB.Data
{
    [Table("pr_ar")]
    public partial class PrAr
    {
        [Column("id")]
        [StringLength(10)]
        public string Id { get; set; }
        [Column("sp_id")]
        [StringLength(10)]
        public string SpId { get; set; }
        [Column("name_ru")]
        [StringLength(150)]
        public string NameRu { get; set; }
        [Column("name_en")]
        [StringLength(150)]
        public string NameEn { get; set; }
        [Column("ord")]
        public int? Ord { get; set; }
        [Column("pr_id")]
        [StringLength(20)]
        public string PrId { get; set; }
        [Column("s")]
        public double? S { get; set; }
    }
}
