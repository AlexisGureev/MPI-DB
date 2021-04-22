using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MPI_DB.Data
{
    [Table("elements", Schema = "dict")]
    public partial class Elements
    {
        [Key]
        [Column("gid")]
        public int Gid { get; set; }
        [Column("n")]
        public double? N { get; set; }
        [Column("name_ru")]
        [StringLength(22)]
        public string NameRu { get; set; }
        [Column("symb")]
        [StringLength(3)]
        public string Symb { get; set; }
        [Column("name_lat")]
        [StringLength(24)]
        public string NameLat { get; set; }
        [Column("gr")]
        public double? Gr { get; set; }
        [Column("m")]
        [StringLength(22)]
        public string M { get; set; }
        [Column("p")]
        [StringLength(11)]
        public string P { get; set; }
        [Column("t_p")]
        public double? TP { get; set; }
        [Column("t_k")]
        public double? TK { get; set; }
        [Column("year")]
        public double? Year { get; set; }
        [Column("author")]
        [StringLength(93)]
        public string Author { get; set; }
        [Column("read")]
        [StringLength(65)]
        public string Read { get; set; }
        [Column("atomicno_")]
        public double? Atomicno { get; set; }
        [Column("name")]
        [StringLength(13)]
        public string Name { get; set; }
        [Column("symbol")]
        [StringLength(3)]
        public string Symbol { get; set; }
        [Column("group")]
        public double? Group { get; set; }
        [Column("period")]
        public double? Period { get; set; }
        [Column("block")]
        [StringLength(1)]
        public string Block { get; set; }
        [Column("state_at_s")]
        [StringLength(6)]
        public string StateAtS { get; set; }
        [Column("occurrence")]
        [StringLength(10)]
        public string Occurrence { get; set; }
        [Column("descriptio")]
        [StringLength(20)]
        public string Descriptio { get; set; }
    }
}
