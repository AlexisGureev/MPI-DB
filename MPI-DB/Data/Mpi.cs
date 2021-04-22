using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Json;
using System.Text.Json;
using NetTopologySuite.Geometries;

namespace MPI_DB.Data
{
    [Table("mpi")]
    public partial class Mpi
    {
        public Mpi()
        {
            Deposit1810 = new HashSet<Deposit1810>();
            InverseParentNavigation = new HashSet<Mpi>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("geom", TypeName = "geometry(Point,4326)")]
        public Point Geom { get; set; }
        [Column("dn_ru")]
        [StringLength(150)]
        public string DnRu { get; set; }
        [Column("sdn_ru")]
        [StringLength(150)]
        public string SdnRu { get; set; }
        [Column("dn_eng")]
        [StringLength(150)]
        public string DnEng { get; set; }
        [Column("sdn_eng")]
        [StringLength(150)]
        public string SdnEng { get; set; }
        [Column("mg")]
        [StringLength(10)]
        public string Mg { get; set; }
        [Column("mm")]
        [StringLength(254)]
        public string Mm { get; set; }
        [Column("am")]
        [StringLength(254)]
        public string Am { get; set; }
        [Column("gt")]
        [StringLength(100)]
        public string Gt { get; set; }
        [Column("ct")]
        [StringLength(20)]
        public string Ct { get; set; }
        [Column("ds")]
        [StringLength(10)]
        public string Ds { get; set; }
        [Required]
        [Column("oq")]
        [StringLength(1)]
        public string Oq { get; set; }
        [Column("mor")]
        [StringLength(10)]
        public string Mor { get; set; }
        [Column("age")]
        [StringLength(254)]
        public string Age { get; set; }
        [Column("age_group")]
        public int AgeGroup { get; set; }
        [Column("met")]
        [StringLength(30)]
        public string Met { get; set; }
        [Column("sta")]
        [StringLength(10)]
        public string Sta { get; set; }
        [Column("comment")]
        [StringLength(254)]
        public string Comment { get; set; }
        [Column("reg_country")]
        [StringLength(5)]
        public string RegCountry { get; set; }
        [Column("rgf_id")]
        public int? RgfId { get; set; }
        [Column("valid_user")]
        [StringLength(254)]
        public string ValidUser { get; set; }
        [Column("admin")]
        [StringLength(20)]
        public string Admin { get; set; }
        [Column("comments")]
        [StringLength(254)]
        public string Comments { get; set; }
        [Column("age_tect")]
        [StringLength(50)]
        public string AgeTect { get; set; }
        [Column("d__id")]
        public int? DId { get; set; }
        [Column("parent")]
        public int? Parent { get; set; }
        [Column("type")]
        public char? Type { get; set; }
        [Column("clss")]
        public char Clss { get; set; }
        [Column("src_mark")]
        [StringLength(200)]
        public string SrcMark { get; set; }
        [Column("geom_ncea", TypeName = "geometry(Point,100003)")]
        public Point GeomNcea { get; set; }
        [Column("age_smb")]
        [StringLength(50)]
        public string AgeSmb { get; set; }
        [Column("isnd_id")]
        public int? IsndId { get; set; }
        [Column("gt_kva")]
        [StringLength(50)]
        public string GtKva { get; set; }
        [Column("mg_kva")]
        [StringLength(50)]
        public string MgKva { get; set; }
        [Column("age_y")]
        [StringLength(50)]
        public string AgeY { get; set; }
        [Column("age_o")]
        [StringLength(50)]
        public string AgeO { get; set; }
        [Column("age_txt")]
        public string AgeTxt { get; set; }
        [Column("age_ma")]
        [StringLength(100)]
        public string AgeMa { get; set; }
        [Column("rgf_passport")]
        [StringLength(50)]
        public string RgfPassport { get; set; }
        [Column("gts_o_id")]
        public int? GtsOId { get; set; }
        [Column("gts_y_id")]
        public int? GtsYId { get; set; }
        [Column("age_rock")]
        [StringLength(250)]
        public string AgeRock { get; set; }
        [Column("mm_arr", TypeName = "character varying(70)[]")]
        public string[] MmArr { get; set; }
        [Column("am_arr", TypeName = "character varying(70)[]")]
        public string[] AmArr { get; set; }
        [Column("tags", TypeName = "jsonb")]
        public string Tags { get; set; }


        [Column("show_on", TypeName = "jsonb")]
        public string ShowOnText { get; set; }

        [Column("show_on", TypeName = "jsonb")]
        public JsonDocument ShowOn { get; set; }

        [ForeignKey(nameof(Clss))]
        [InverseProperty(nameof(DepositType.Mpi))]
        public virtual DepositType ClssNavigation { get; set; }
        [ForeignKey(nameof(DId))]
        [InverseProperty(nameof(Data.Deposit1810.MpiD))]
        public virtual Deposit1810 D { get; set; }
        [ForeignKey(nameof(Ds))]
        [InverseProperty(nameof(DepositSize.Mpi))]
        public virtual DepositSize DsNavigation { get; set; }
        [ForeignKey(nameof(Gt))]
        [InverseProperty(nameof(GenType.Mpi))]
        public virtual GenType GtNavigation { get; set; }
        [ForeignKey(nameof(IsndId))]
        [InverseProperty(nameof(Kadastr.Mpi))]
        public virtual Kadastr Isnd { get; set; }
        [ForeignKey(nameof(Mg))]
        [InverseProperty(nameof(MineralGroup.Mpi))]
        public virtual MineralGroup MgNavigation { get; set; }
        [ForeignKey(nameof(Oq))]
        [InverseProperty(nameof(OreQuality.Mpi))]
        public virtual OreQuality OqNavigation { get; set; }
        [ForeignKey(nameof(Parent))]
        [InverseProperty(nameof(Mpi.InverseParentNavigation))]
        public virtual Mpi ParentNavigation { get; set; }
        public virtual Deposit1810 Rgf { get; set; }
        [ForeignKey(nameof(Type))]
        [InverseProperty(nameof(PlacedType.Mpi))]
        public virtual PlacedType TypeNavigation { get; set; }
        [InverseProperty("M")]
        public virtual ICollection<Deposit1810> Deposit1810 { get; set; }
        [InverseProperty(nameof(Mpi.ParentNavigation))]
        public virtual ICollection<Mpi> InverseParentNavigation { get; set; }
    }
}
