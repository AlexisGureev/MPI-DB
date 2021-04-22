using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MPI_DB.Data
{
    [Table("t2_geolunits")]
    public partial class T2Geolunits
    {
        [Column("OBJECTID")]
        public int? Objectid { get; set; }
        [Key]
        [Column("NN")]
        public int Nn { get; set; }
        [Column("MAS")]
        [StringLength(254)]
        public string Mas { get; set; }
        [Column("ID_RGF")]
        [StringLength(254)]
        public string IdRgf { get; set; }
        [Column("ID_KADASTR")]
        public double? IdKadastr { get; set; }
        [Column("N_RGF")]
        public double? NRgf { get; set; }
        [Column("Name_Tex")]
        [StringLength(254)]
        public string NameTex { get; set; }
        [Column("Type_Tex")]
        [StringLength(254)]
        public string TypeTex { get; set; }
        [StringLength(254)]
        public string Texture { get; set; }
        [Column("kd_id")]
        public int? KdId { get; set; }

        public virtual Deposit1810 Kd { get; set; }
    }
}
