using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MPI_DB.Data
{
    [Table("t5_mineral")]
    public partial class T5Mineral
    {
        [Column("OBJECTID")]
        public int? Objectid { get; set; }
        [Key]
        [Column("NN")]
        public int Nn { get; set; }
        [Column("ID_KADASTR")]
        public double? IdKadastr { get; set; }
        [Column("MAS")]
        [StringLength(254)]
        public string Mas { get; set; }
        [Column("N_RGF")]
        public double? NRgf { get; set; }
        [Column("MINERAL")]
        [StringLength(254)]
        public string Mineral { get; set; }
        [Column("MIN_Znach")]
        [StringLength(254)]
        public string MinZnach { get; set; }
        [Column("Notes_Mine")]
        [StringLength(254)]
        public string NotesMine { get; set; }
        [Column("kd_id")]
        public int? KdId { get; set; }

        public virtual Deposit1810 Kd { get; set; }
    }
}
