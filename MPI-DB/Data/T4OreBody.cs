using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MPI_DB.Data
{
    [Table("t4_ore_body")]
    public partial class T4OreBody
    {
        [Column("OBJECTID")]
        public int? Objectid { get; set; }
        [Key]
        [Column("NN")]
        public int Nn { get; set; }
        [Column("MAS")]
        [StringLength(254)]
        public string Mas { get; set; }
        [Column("ID_KADASTR")]
        public int? IdKadastr { get; set; }
        [Column("N_RGF")]
        public int? NRgf { get; set; }
        [Column("ORE_TEXT")]
        [StringLength(254)]
        public string OreText { get; set; }
        [Column("Name_Orebo")]
        [StringLength(254)]
        public string NameOrebo { get; set; }
        [Column("N_Orebody")]
        public double? NOrebody { get; set; }
        [Column("Form_Orebo")]
        [StringLength(254)]
        public string FormOrebo { get; set; }
        [Column("Position_O")]
        [StringLength(254)]
        public string PositionO { get; set; }
        [Column("Balance_Za")]
        public double? BalanceZa { get; set; }
        [Column("GOD_DOC")]
        public int? GodDoc { get; set; }
        [Column("kd_id")]
        public int? KdId { get; set; }

        public virtual Deposit1810 Kd { get; set; }
    }
}
