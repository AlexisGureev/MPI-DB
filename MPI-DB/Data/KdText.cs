using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MPI_DB.Data
{
    [Table("kd_text", Schema = "kd")]
    public partial class KdText
    {
        [Key]
        [Column("id_kd_text")]
        public int IdKdText { get; set; }
        [Column("id_kadastr")]
        public int? IdKadastr { get; set; }
        [Column("change_date", TypeName = "timestamp(3) without time zone")]
        public DateTime? ChangeDate { get; set; }
        [Column("insert_date")]
        public string InsertDate { get; set; }
        [Column("owner")]
        [StringLength(32)]
        public string Owner { get; set; }
        [Column("t_struct_ctrl")]
        public string TStructCtrl { get; set; }
        [Column("t_abs_age")]
        public string TAbsAge { get; set; }
        [Column("t_strata_izmen")]
        public string TStrataIzmen { get; set; }
        [Column("t_rud_tectonic")]
        public string TRudTectonic { get; set; }
        [Column("t_surf_izmen")]
        public string TSurfIzmen { get; set; }
        [Column("t_oth_solid")]
        public string TOthSolid { get; set; }
        [Column("t_minerals")]
        public string TMinerals { get; set; }
        [Column("t_chemic")]
        public string TChemic { get; set; }
        [Column("t_sources")]
        public string TSources { get; set; }
        [Column("t_geomorphology")]
        public string TGeomorphology { get; set; }
        [Column("t_peat_balsa")]
        public string TPeatBalsa { get; set; }
        [Column("t_granulometry")]
        public string TGranulometry { get; set; }
        [Column("len_m", TypeName = "numeric(16,2)")]
        public decimal? LenM { get; set; }
        [Column("width_m", TypeName = "numeric(16,2)")]
        public decimal? WidthM { get; set; }
        [Column("area", TypeName = "numeric(16,2)")]
        public decimal? Area { get; set; }
        [Column("t_izuch")]
        public string TIzuch { get; set; }
        [Column("t_sostav")]
        public string TSostav { get; set; }
        [Column("t_granul")]
        public string TGranul { get; set; }
        [Column("t_other")]
        public string TOther { get; set; }
        [Column("cost_grr", TypeName = "numeric(19,4)")]
        public decimal? CostGrr { get; set; }
        [Column("cost_oil_iz", TypeName = "numeric(19,4)")]
        public decimal? CostOilIz { get; set; }
        [Column("cost_oil_com", TypeName = "numeric(19,4)")]
        public decimal? CostOilCom { get; set; }
        [Column("cost_gas", TypeName = "numeric(19,4)")]
        public decimal? CostGas { get; set; }
        [Column("cost_fuel_com", TypeName = "numeric(19,4)")]
        public decimal? CostFuelCom { get; set; }
        [Column("cost_fuel_iz", TypeName = "numeric(19,4)")]
        public decimal? CostFuelIz { get; set; }
        [Column("ww_purpose_id")]
        public short? WwPurposeId { get; set; }
        [Column("well_no")]
        [StringLength(20)]
        public string WellNo { get; set; }
        [Column("t_str")]
        public string TStr { get; set; }
        [Column("t_plast")]
        public string TPlast { get; set; }
        [Column("t_zapas_uch")]
        public string TZapasUch { get; set; }
        [Column("t_area")]
        public string TArea { get; set; }
        [Column("t_discovery")]
        public string TDiscovery { get; set; }
        [Column("t_gs_gf")]
        public string TGsGf { get; set; }
        [Column("t_prospect")]
        public string TProspect { get; set; }
        [Column("t_econom_grr")]
        public string TEconomGrr { get; set; }
        [Column("t_explor_met")]
        public string TExplorMet { get; set; }
        [Column("t_other_ctrl")]
        public string TOtherCtrl { get; set; }
        [Column("t_geomorf_ctrl")]
        public string TGeomorfCtrl { get; set; }
        [Column("t_genesis")]
        public string TGenesis { get; set; }
        [Column("t_strata")]
        public string TStrata { get; set; }
        [Column("t_zones")]
        public string TZones { get; set; }
        [Column("t_str_pi")]
        public string TStrPi { get; set; }
        [Column("t_mineral_char")]
        public string TMineralChar { get; set; }
        [Column("t_pi")]
        public string TPi { get; set; }
        [Column("t_opi")]
        public string TOpi { get; set; }
        [Column("t_technolog_pi")]
        public string TTechnologPi { get; set; }
        [Column("t_zapas")]
        public string TZapas { get; set; }
        [Column("t_conditions")]
        public string TConditions { get; set; }
        [Column("t_mining_cond")]
        public string TMiningCond { get; set; }
        [Column("t_hydro_cond")]
        public string THydroCond { get; set; }
        [Column("t_watersupply")]
        public string TWatersupply { get; set; }
        [Column("t_econom_char")]
        public string TEconomChar { get; set; }
        [Column("t_user_pi")]
        public string TUserPi { get; set; }
        [Column("t_ohrana")]
        public string TOhrana { get; set; }
        [Column("t_recommend")]
        public string TRecommend { get; set; }
        [Column("t_closing")]
        public string TClosing { get; set; }
        [Column("source_id")]
        public int? SourceId { get; set; }
        [Column("e_plastcount_all")]
        public short? EPlastcountAll { get; set; }
        [Column("e_plastcount_cond")]
        public short? EPlastcountCond { get; set; }
        [Column("e_plastcount_notcond")]
        public short? EPlastcountNotcond { get; set; }
        [Column("e_plastcount_razrab")]
        public short? EPlastcountRazrab { get; set; }
        [Column("e_plastcount_namech")]
        public short? EPlastcountNamech { get; set; }
        [Column("e_plastcount_rezerv")]
        public short? EPlastcountRezerv { get; set; }
        [Column("e_plicat")]
        public string EPlicat { get; set; }
        [Column("e_disjunction")]
        public string EDisjunction { get; set; }
        [Column("e_levels")]
        public string ELevels { get; set; }
        [Column("j_otloj_depthfrom", TypeName = "numeric(8,2)")]
        public decimal? JOtlojDepthfrom { get; set; }
        [Column("j_otloj_depthto", TypeName = "numeric(8,2)")]
        public decimal? JOtlojDepthto { get; set; }
        [Column("j_otloj_depthav", TypeName = "numeric(8,2)")]
        public decimal? JOtlojDepthav { get; set; }
        [Column("t_water_gorizont")]
        public string TWaterGorizont { get; set; }
        [Column("t_mining_cond_j")]
        public string TMiningCondJ { get; set; }
        [Column("t_str_tectonics")]
        public string TStrTectonics { get; set; }
        [Column("bur", TypeName = "numeric(12,2)")]
        public decimal? Bur { get; set; }
        [Column("j_rapa_area", TypeName = "numeric(8,2)")]
        public decimal? JRapaArea { get; set; }
        [Column("j_rapa_volume", TypeName = "numeric(13,2)")]
        public decimal? JRapaVolume { get; set; }
        [Column("j_rapa_depth", TypeName = "numeric(8,2)")]
        public decimal? JRapaDepth { get; set; }
        [Column("j_rapa_level", TypeName = "numeric(8,2)")]
        public decimal? JRapaLevel { get; set; }
        [Column("j_rapa_density", TypeName = "numeric(8,2)")]
        public decimal? JRapaDensity { get; set; }
        [Column("j_otloj_length", TypeName = "numeric(8,2)")]
        public decimal? JOtlojLength { get; set; }
        [Column("j_otloj_width", TypeName = "numeric(8,2)")]
        public decimal? JOtlojWidth { get; set; }
        [Column("j_otloj_area", TypeName = "numeric(8,2)")]
        public decimal? JOtlojArea { get; set; }
        [Column("t_ressoil")]
        public string TRessoil { get; set; }
        [Column("t_mining")]
        public string TMining { get; set; }
        [Column("year_cost_grr")]
        public short? YearCostGrr { get; set; }
        [Column("year_cost_fuel")]
        public short? YearCostFuel { get; set; }
        [Column("owner_insert")]
        [StringLength(32)]
        public string OwnerInsert { get; set; }

        [ForeignKey(nameof(IdKadastr))]
        [InverseProperty(nameof(Kadastr.KdText))]
        public virtual Kadastr IdKadastrNavigation { get; set; }
    }
}
