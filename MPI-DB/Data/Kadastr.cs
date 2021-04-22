using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NetTopologySuite.Geometries;

namespace MPI_DB.Data
{
    [Table("kadastr", Schema = "kd")]
    public partial class Kadastr
    {
        public Kadastr()
        {
            Deposit1810 = new HashSet<Deposit1810>();
            KdGeolage = new HashSet<KdGeolage>();
            KdPi = new HashSet<KdPi>();
            KdPolcomp = new HashSet<KdPolcomp>();
        }

        [Key]
        [Column("id_kadastr")]
        public int IdKadastr { get; set; }
        [Column("mas_gkm_id")]
        public short? MasGkmId { get; set; }
        [Column("n_tgf", TypeName = "numeric(10,0)")]
        public decimal? NTgf { get; set; }
        [Column("n_rgf", TypeName = "numeric(12,0)")]
        public decimal? NRgf { get; set; }
        [Column("vid_ofn_id")]
        public short? VidOfnId { get; set; }
        [Column("cipher_doc")]
        [StringLength(20)]
        public string CipherDoc { get; set; }
        [Column("god_doc")]
        public short? GodDoc { get; set; }
        [Column("name_mest")]
        [StringLength(255)]
        public string NameMest { get; set; }
        [Column("synon_mest")]
        [StringLength(255)]
        public string SynonMest { get; set; }
        [Column("sub_rf_id")]
        public int? SubRfId { get; set; }
        [Column("lat_gr")]
        public short? LatGr { get; set; }
        [Column("lat_min")]
        public short? LatMin { get; set; }
        [Column("lat_sec", TypeName = "numeric(4,2)")]
        public decimal? LatSec { get; set; }
        [Column("long_gr")]
        public short? LongGr { get; set; }
        [Column("long_min")]
        public short? LongMin { get; set; }
        [Column("long_sec", TypeName = "numeric(4,2)")]
        public decimal? LongSec { get; set; }
        [Column("height_from", TypeName = "numeric(12,2)")]
        public decimal? HeightFrom { get; set; }
        [Column("height_to", TypeName = "numeric(12,2)")]
        public decimal? HeightTo { get; set; }
        [Column("cost_dist", TypeName = "numeric(5,2)")]
        public decimal? CostDist { get; set; }
        [Column("god_open")]
        public short? GodOpen { get; set; }
        [Column("ekonom_osv_id")]
        public short? EkonomOsvId { get; set; }
        [Column("min1_id")]
        public int? Min1Id { get; set; }
        [Column("min2_id")]
        public int? Min2Id { get; set; }
        [Column("min3_id")]
        public int? Min3Id { get; set; }
        [Column("min4_id")]
        public int? Min4Id { get; set; }
        [Column("sostav_fio")]
        [StringLength(100)]
        public string SostavFio { get; set; }
        [Column("sostav_pos")]
        [StringLength(255)]
        public string SostavPos { get; set; }
        [Column("sostav_date")]
        public string SostavDate { get; set; }
        [Column("prov_fio")]
        [StringLength(100)]
        public string ProvFio { get; set; }
        [Column("prov_pos")]
        [StringLength(255)]
        public string ProvPos { get; set; }
        [Column("prov_date")]
        public string ProvDate { get; set; }
        [Column("utv_fio")]
        [StringLength(100)]
        public string UtvFio { get; set; }
        [Column("utv_pos")]
        [StringLength(255)]
        public string UtvPos { get; set; }
        [Column("utv_date")]
        public string UtvDate { get; set; }
        [Column("sostav_org")]
        [StringLength(255)]
        public string SostavOrg { get; set; }
        [Column("nivel")]
        [StringLength(5)]
        public string Nivel { get; set; }
        [Column("change_date", TypeName = "timestamp(3) without time zone")]
        public DateTime? ChangeDate { get; set; }
        [Column("insert_date")]
        public string InsertDate { get; set; }
        [Column("owner")]
        [StringLength(32)]
        public string Owner { get; set; }
        [Column("aqua_id")]
        public short? AquaId { get; set; }
        [Column("source_id")]
        public int? SourceId { get; set; }
        [Column("predp_open")]
        [StringLength(255)]
        public string PredpOpen { get; set; }
        [Column("ministry_open")]
        [StringLength(255)]
        public string MinistryOpen { get; set; }
        [Column("geolfondhist_id")]
        public short? GeolfondhistId { get; set; }
        [Column("econom_region_id")]
        public short? EconomRegionId { get; set; }
        [Column("edited_ingis")]
        public bool? EditedIngis { get; set; }
        [Column("secret_id")]
        public short? SecretId { get; set; }
        [Column("owner_insert")]
        [StringLength(32)]
        public string OwnerInsert { get; set; }
        [Column("num_graph")]
        public int? NumGraph { get; set; }
        [Column("god_actual")]
        public short? GodActual { get; set; }
        [Column("f_replace_needed")]
        public bool? FReplaceNeeded { get; set; }
        [Column("massgkm_nrgf_calc123")]
        [StringLength(20)]
        public string MassgkmNrgfCalc123 { get; set; }
        [Column("massgkm_nrgf")]
        [StringLength(20)]
        public string MassgkmNrgf { get; set; }
        [Column("massgkm_ntgf_calc123")]
        [StringLength(20)]
        public string MassgkmNtgfCalc123 { get; set; }
        [Column("massgkm_ntgf")]
        [StringLength(20)]
        public string MassgkmNtgf { get; set; }
        [Column("gkm_state_calc123")]
        [StringLength(11)]
        public string GkmStateCalc123 { get; set; }
        [Column("gkm_state")]
        [StringLength(11)]
        public string GkmState { get; set; }
        [Column("lat_calc123")]
        public float? LatCalc123 { get; set; }
        [Column("lat")]
        public float? Lat { get; set; }
        [Column("long_calc123")]
        public float? LongCalc123 { get; set; }
        [Column("long")]
        public float? Long { get; set; }
        [Column("f_unfz_calc123")]
        public bool? FUnfzCalc123 { get; set; }
        [Column("f_unfz")]
        public bool? FUnfz { get; set; }
        [Column("geom", TypeName = "geometry(Point,4326)")]
        public Point Geom { get; set; }
        [Column("mm_kd")]
        public string MmKd { get; set; }
        [Column("am_kd")]
        public string AmKd { get; set; }

        [InverseProperty("IdKadastrNavigation")]
        public virtual KdText KdText { get; set; }
        [InverseProperty("Isnd")]
        public virtual Mpi Mpi { get; set; }
        [InverseProperty("Isnd")]
        public virtual ICollection<Deposit1810> Deposit1810 { get; set; }
        [InverseProperty("IdKadastrNavigation")]
        public virtual ICollection<KdGeolage> KdGeolage { get; set; }
        [InverseProperty("IdKadastrNavigation")]
        public virtual ICollection<KdPi> KdPi { get; set; }
        [InverseProperty("IdKadastrNavigation")]
        public virtual ICollection<KdPolcomp> KdPolcomp { get; set; }
    }
}
