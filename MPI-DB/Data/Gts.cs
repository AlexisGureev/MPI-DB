using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MPI_DB.Data
{
    [Table("gts", Schema = "dict")]
    public partial class Gts
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("parent")]
        public int? Parent { get; set; }
        [Column("deep")]
        public int? Deep { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("color_rgb")]
        public string ColorRgb { get; set; }
        [Column("note")]
        public string Note { get; set; }
        [Column("age_txt")]
        public string AgeTxt { get; set; }
        [Column("ind")]
        [StringLength(30)]
        public string Ind { get; set; }
        [Column("from_ma")]
        public double? FromMa { get; set; }
        [Column("to_ma")]
        public double? ToMa { get; set; }
        [Column("num")]
        public int? Num { get; set; }
        [Column("lbl_part")]
        [StringLength(5)]
        public string LblPart { get; set; }
        [Column("is_leaf")]
        public bool IsLeaf { get; set; }
        [Column("ref_from")]
        public int? RefFrom { get; set; }
        [Column("ref_to")]
        public int? RefTo { get; set; }
        [Column("ind_lvl5")]
        [StringLength(70)]
        public string IndLvl5 { get; set; }
    }
}
