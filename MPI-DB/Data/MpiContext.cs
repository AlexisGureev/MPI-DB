using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MPI_DB.Data
{
    public partial class MpiContext : DbContext
    {
        public MpiContext()
        {
        }

        public MpiContext(DbContextOptions<MpiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Deposit1810> Deposit1810 { get; set; }
        public virtual DbSet<DepositSize> DepositSize { get; set; }
        public virtual DbSet<DepositType> DepositType { get; set; }
        public virtual DbSet<DictAge> DictAge { get; set; }
        public virtual DbSet<Elements> Elements { get; set; }
        public virtual DbSet<GenType> GenType { get; set; }
        public virtual DbSet<GeolageTo> GeolageTo { get; set; }
        public virtual DbSet<Gts> Gts { get; set; }
        public virtual DbSet<Kadastr> Kadastr { get; set; }
        public virtual DbSet<KdGeolage> KdGeolage { get; set; }
        public virtual DbSet<KdGeolageVal> KdGeolageVal { get; set; }
        public virtual DbSet<KdListpi> KdListpi { get; set; }
        public virtual DbSet<KdListpilist> KdListpilist { get; set; }
        public virtual DbSet<KdPi> KdPi { get; set; }
        public virtual DbSet<KdPolcomp> KdPolcomp { get; set; }
        public virtual DbSet<KdText> KdText { get; set; }
        public virtual DbSet<KdToJoin> KdToJoin { get; set; }
        public virtual DbSet<KdZapaspi> KdZapaspi { get; set; }
        public virtual DbSet<Lbl> Lbl { get; set; }
        public virtual DbSet<MineralGroup> MineralGroup { get; set; }
        public virtual DbSet<Mpi> Mpi { get; set; }
        public virtual DbSet<MpiOut> MpiOut { get; set; }
        public virtual DbSet<MpiOut2> MpiOut2 { get; set; }
        public virtual DbSet<OreQuality> OreQuality { get; set; }
        public virtual DbSet<OslMaps> OslMaps { get; set; }
        public virtual DbSet<OutAr> OutAr { get; set; }
        public virtual DbSet<Pi> Pi { get; set; }
        public virtual DbSet<PlacedType> PlacedType { get; set; }
        public virtual DbSet<PrAr> PrAr { get; set; }
        public virtual DbSet<RegionsAr> RegionsAr { get; set; }
        public virtual DbSet<ReplAge> ReplAge { get; set; }
        public virtual DbSet<ShpKnoA> ShpKnoA { get; set; }
        public virtual DbSet<ShpProv> ShpProv { get; set; }
        public virtual DbSet<ShpProvO> ShpProvO { get; set; }
        public virtual DbSet<ShpZonA> ShpZonA { get; set; }
        public virtual DbSet<SkdGeolage> SkdGeolage { get; set; }
        public virtual DbSet<SkdGeolageLevel> SkdGeolageLevel { get; set; }
        public virtual DbSet<SkdPolisk> SkdPolisk { get; set; }
        public virtual DbSet<SkdRudDistrib> SkdRudDistrib { get; set; }
        public virtual DbSet<SkdRudOxid> SkdRudOxid { get; set; }
        public virtual DbSet<SkdRudQuality> SkdRudQuality { get; set; }
        public virtual DbSet<SkdRudRich> SkdRudRich { get; set; }
        public virtual DbSet<SkdRuda> SkdRuda { get; set; }
        public virtual DbSet<SmasGkm> SmasGkm { get; set; }
        public virtual DbSet<SpAr> SpAr { get; set; }
        public virtual DbSet<SysFldstxt> SysFldstxt { get; set; }
        public virtual DbSet<T2Geolunits> T2Geolunits { get; set; }
        public virtual DbSet<T3Rock> T3Rock { get; set; }
        public virtual DbSet<T4OreBody> T4OreBody { get; set; }
        public virtual DbSet<T5Mineral> T5Mineral { get; set; }
        public virtual DbSet<T6Reser> T6Reser { get; set; }
        public virtual DbSet<Test12> Test12 { get; set; }
        public virtual DbSet<ZonesA> ZonesA { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Host=pc-osl01.vsegei.ru;Port=5411;Database=mpi;Username=postgres;Password=sql#12", x => x.UseNetTopologySuite());
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresExtension("pg_trgm")
                .HasPostgresExtension("postgis")
                .HasPostgresExtension("postgis_topology");

            modelBuilder.Entity<Deposit1810>(entity =>
            {
                entity.HasIndex(e => e.Geom)
                    .HasName("sidx_deposit1810_geom")
                    .HasMethod("gist");

                entity.HasIndex(e => e.KdId)
                    .HasName("dep_rgf_key")
                    .IsUnique();

                entity.HasIndex(e => e.RgfPass)
                    .HasName("hdhdhhd")
                    .IsUnique()
                    .HasFilter("(((gp_type)::text = 'коренное'::text) AND (m__id IS NOT NULL))");

                entity.HasOne(d => d.Isnd)
                    .WithMany(p => p.Deposit1810)
                    .HasForeignKey(d => d.IsndId)
                    .HasConstraintName("deposit1810_kadastr_id_kadastr_fk");

                entity.HasOne(d => d.M)
                    .WithMany(p => p.Deposit1810)
                    .HasForeignKey(d => d.MId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("dep_mpi");
            });

            modelBuilder.Entity<DepositSize>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("deposit_size_pk");
            });

            modelBuilder.Entity<DepositType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<DictAge>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Elements>(entity =>
            {
                entity.HasKey(e => e.Gid)
                    .HasName("elements_pkey");
            });

            modelBuilder.Entity<GenType>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("gen_type_pk");
            });

            modelBuilder.Entity<GeolageTo>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Gts>(entity =>
            {
                entity.HasIndex(e => e.Ind)
                    .HasName("gst_ind_uindex")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Kadastr>(entity =>
            {
                entity.HasKey(e => e.IdKadastr)
                    .HasName("kadastr_pk");

                entity.Property(e => e.IdKadastr).ValueGeneratedNever();

                entity.Property(e => e.Nivel).IsFixedLength();
            });

            modelBuilder.Entity<KdGeolage>(entity =>
            {
                entity.HasKey(e => e.IdKdGeolage)
                    .HasName("kd_geolage_pk");

                entity.Property(e => e.IdKdGeolage).ValueGeneratedNever();

                entity.HasOne(d => d.GeolageFrom)
                    .WithMany(p => p.KdGeolageGeolageFrom)
                    .HasForeignKey(d => d.GeolageFromId)
                    .HasConstraintName("kd_geolage_skd_geolage_geolage_id_fk");

                entity.HasOne(d => d.GeolageTo)
                    .WithMany(p => p.KdGeolageGeolageTo)
                    .HasForeignKey(d => d.GeolageToId)
                    .HasConstraintName("kd_geolage_skd_geolage_geolage_id_fk_2");

                entity.HasOne(d => d.IdKadastrNavigation)
                    .WithMany(p => p.KdGeolage)
                    .HasForeignKey(d => d.IdKadastr)
                    .HasConstraintName("kd_geolage_kadastr_id_kadastr_fk");
            });

            modelBuilder.Entity<KdGeolageVal>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<KdListpi>(entity =>
            {
                entity.HasKey(e => e.IdKdListpi)
                    .HasName("kd_listpi_pkey");

                entity.Property(e => e.IdKdListpi).ValueGeneratedNever();
            });

            modelBuilder.Entity<KdListpilist>(entity =>
            {
                entity.HasKey(e => e.IdKdListpilist)
                    .HasName("kd_listpilist_pk");

                entity.Property(e => e.IdKdListpilist).ValueGeneratedNever();

                entity.HasOne(d => d.IdKdListpiNavigation)
                    .WithMany(p => p.KdListpilist)
                    .HasForeignKey(d => d.IdKdListpi)
                    .HasConstraintName("kd_listpilist_kd_listpi_id_kd_listpi_fk");

                entity.HasOne(d => d.KdPolisk)
                    .WithMany(p => p.KdListpilist)
                    .HasForeignKey(d => d.KdPoliskId)
                    .HasConstraintName("kd_listpilist_skd_polisk_kd_polisk_id_fk");
            });

            modelBuilder.Entity<KdPi>(entity =>
            {
                entity.HasKey(e => e.IdKdPi)
                    .HasName("kd_pi_pkey");

                entity.Property(e => e.IdKdPi).ValueGeneratedNever();

                entity.HasOne(d => d.IdKadastrNavigation)
                    .WithMany(p => p.KdPi)
                    .HasForeignKey(d => d.IdKadastr)
                    .HasConstraintName("kd_pi_kadastr_id_kadastr_fk");

                entity.HasOne(d => d.IdKdListpiNavigation)
                    .WithMany(p => p.KdPi)
                    .HasForeignKey(d => d.IdKdListpi)
                    .HasConstraintName("kd_pi_kd_listpi_id_kd_listpi_fk");

                entity.HasOne(d => d.KdRuda)
                    .WithMany(p => p.KdPi)
                    .HasForeignKey(d => d.KdRudaId)
                    .HasConstraintName("kd_pi_skd_ruda_kd_ruda_id_fk");

                entity.HasOne(d => d.RudDistrib)
                    .WithMany(p => p.KdPi)
                    .HasForeignKey(d => d.RudDistribId)
                    .HasConstraintName("kd_pi_skd_rud_distrib_rud_distrib_id_fk");

                entity.HasOne(d => d.RudOxid)
                    .WithMany(p => p.KdPi)
                    .HasForeignKey(d => d.RudOxidId)
                    .HasConstraintName("kd_pi_skd_rud_oxid_rud_oxid_id_fk");

                entity.HasOne(d => d.RudQuality)
                    .WithMany(p => p.KdPi)
                    .HasForeignKey(d => d.RudQualityId)
                    .HasConstraintName("kd_pi_skd_rud_quality_rud_quality_id_fk");

                entity.HasOne(d => d.RudRich)
                    .WithMany(p => p.KdPi)
                    .HasForeignKey(d => d.RudRichId)
                    .HasConstraintName("kd_pi_skd_rud_rich_rud_rich_id_fk");
            });

            modelBuilder.Entity<KdPolcomp>(entity =>
            {
                entity.HasKey(e => e.IdKdPolcomp)
                    .HasName("kd_polcomp_pkey");

                entity.Property(e => e.IdKdPolcomp).ValueGeneratedNever();

                entity.HasOne(d => d.IdKadastrNavigation)
                    .WithMany(p => p.KdPolcomp)
                    .HasForeignKey(d => d.IdKadastr)
                    .HasConstraintName("kd_polcomp_kadastr_id_kadastr_fk");

                entity.HasOne(d => d.IdKdListpiNavigation)
                    .WithMany(p => p.KdPolcomp)
                    .HasForeignKey(d => d.IdKdListpi)
                    .HasConstraintName("kd_polcomp_kd_listpi_id_kd_listpi_fk");
            });

            modelBuilder.Entity<KdText>(entity =>
            {
                entity.HasKey(e => e.IdKdText)
                    .HasName("kd_text_pk");

                entity.HasIndex(e => e.IdKadastr)
                    .HasName("kd_text_id_kadastr_uindex")
                    .IsUnique();

                entity.Property(e => e.IdKdText).ValueGeneratedNever();

                entity.HasOne(d => d.IdKadastrNavigation)
                    .WithOne(p => p.KdText)
                    .HasForeignKey<KdText>(d => d.IdKadastr)
                    .HasConstraintName("kd_text_kadastr_id_kadastr_fk");
            });

            modelBuilder.Entity<KdToJoin>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Nivel).IsFixedLength();
            });

            modelBuilder.Entity<KdZapaspi>(entity =>
            {
                entity.HasKey(e => e.IdKdZapaspi)
                    .HasName("kd_zapaspi_pkey");

                entity.Property(e => e.IdKdZapaspi).ValueGeneratedNever();
            });

            modelBuilder.Entity<Lbl>(entity =>
            {
                entity.HasKey(e => e.Col)
                    .HasName("lbl_pk");
            });

            modelBuilder.Entity<MineralGroup>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("mineral_group_pk");
            });

            modelBuilder.Entity<Mpi>(entity =>
            {
                entity.HasIndex(e => e.DId)
                    .HasName("mpi_d__id_uindex")
                    .IsUnique();

                entity.HasIndex(e => e.Geom)
                    .HasName("sidx_mpi1810_geom")
                    .HasMethod("gist");

                entity.HasIndex(e => e.IsndId)
                    .HasName("mpi_isnd_id_uindex")
                    .IsUnique();

                entity.HasIndex(e => e.RgfId)
                    .HasName("mpi1810_rgf_id_uindex")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("nextval('mpi1810_id_seq'::regclass)");

                entity.Property(e => e.Clss).HasDefaultValueSql("'d'::bpchar");

                entity.Property(e => e.Oq).HasDefaultValueSql("'N'::character varying");

                entity.HasOne(d => d.ClssNavigation)
                    .WithMany(p => p.Mpi)
                    .HasForeignKey(d => d.Clss)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mpi1810_clss_fkey");

                entity.HasOne(d => d.D)
                    .WithOne(p => p.MpiD)
                    .HasForeignKey<Mpi>(d => d.DId)
                    .HasConstraintName("mpi_d__id_ref");

                entity.HasOne(d => d.DsNavigation)
                    .WithMany(p => p.Mpi)
                    .HasForeignKey(d => d.Ds)
                    .HasConstraintName("mpi_ds_ref");

                entity.HasOne(d => d.GtNavigation)
                    .WithMany(p => p.Mpi)
                    .HasForeignKey(d => d.Gt)
                    .HasConstraintName("mpi_gt_ref");

                entity.HasOne(d => d.Isnd)
                    .WithOne(p => p.Mpi)
                    .HasForeignKey<Mpi>(d => d.IsndId)
                    .HasConstraintName("mpi_kadastr_id_kadastr_fk");

                entity.HasOne(d => d.MgNavigation)
                    .WithMany(p => p.Mpi)
                    .HasForeignKey(d => d.Mg)
                    .HasConstraintName("mpi_mg_ref");

                entity.HasOne(d => d.OqNavigation)
                    .WithMany(p => p.Mpi)
                    .HasForeignKey(d => d.Oq)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mpi_oq_ref");

                entity.HasOne(d => d.ParentNavigation)
                    .WithMany(p => p.InverseParentNavigation)
                    .HasForeignKey(d => d.Parent)
                    .HasConstraintName("mpi1810_parent_fkey");

                entity.HasOne(d => d.Rgf)
                    .WithOne(p => p.MpiRgf)
                    .HasPrincipalKey<Deposit1810>(p => p.KdId)
                    .HasForeignKey<Mpi>(d => d.RgfId)
                    .HasConstraintName("mpi_rgf_id_ref");

                entity.HasOne(d => d.TypeNavigation)
                    .WithMany(p => p.Mpi)
                    .HasForeignKey(d => d.Type)
                    .HasConstraintName("mpi1810_type_fkey");
            });

            modelBuilder.Entity<MpiOut>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<MpiOut2>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<OreQuality>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("ore_quality_pk");
            });

            modelBuilder.Entity<OslMaps>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("osl_maps_pk");
            });

            modelBuilder.Entity<OutAr>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Pi>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("pi_pkey");
            });

            modelBuilder.Entity<PlacedType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<PrAr>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<ReplAge>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<ShpKnoA>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<ShpProv>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<ShpProvO>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<ShpZonA>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<SkdGeolage>(entity =>
            {
                entity.HasKey(e => e.GeolageId)
                    .HasName("skd_geolage_pk");

                entity.Property(e => e.GeolageId).ValueGeneratedNever();

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("skd_geolage_skd_geolage_geolage_id_fk");
            });

            modelBuilder.Entity<SkdGeolageLevel>(entity =>
            {
                entity.HasKey(e => e.GeolageLevelId)
                    .HasName("skd_geolage_level_pk");

                entity.Property(e => e.GeolageLevelId).ValueGeneratedNever();
            });

            modelBuilder.Entity<SkdPolisk>(entity =>
            {
                entity.HasKey(e => e.KdPoliskId)
                    .HasName("skd_polisk_pkey");

                entity.Property(e => e.KdPoliskId).ValueGeneratedNever();
            });

            modelBuilder.Entity<SkdRudDistrib>(entity =>
            {
                entity.HasKey(e => e.RudDistribId)
                    .HasName("skd_rud_distrib_pkey");

                entity.Property(e => e.RudDistribId).ValueGeneratedNever();
            });

            modelBuilder.Entity<SkdRudOxid>(entity =>
            {
                entity.HasKey(e => e.RudOxidId)
                    .HasName("skd_rud_oxid_pk");

                entity.Property(e => e.RudOxidId).ValueGeneratedNever();
            });

            modelBuilder.Entity<SkdRudQuality>(entity =>
            {
                entity.HasKey(e => e.RudQualityId)
                    .HasName("skd_rud_quality_pkey");

                entity.Property(e => e.RudQualityId).ValueGeneratedNever();
            });

            modelBuilder.Entity<SkdRudRich>(entity =>
            {
                entity.HasKey(e => e.RudRichId)
                    .HasName("skd_rud_rich_pk");

                entity.Property(e => e.RudRichId).ValueGeneratedNever();
            });

            modelBuilder.Entity<SkdRuda>(entity =>
            {
                entity.HasKey(e => e.KdRudaId)
                    .HasName("skd_ruda_pk");

                entity.Property(e => e.KdRudaId).ValueGeneratedNever();
            });

            modelBuilder.Entity<SmasGkm>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("smas_gkm_pkey");

                entity.Property(e => e.Code).ValueGeneratedNever();
            });

            modelBuilder.Entity<SpAr>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<SysFldstxt>(entity =>
            {
                entity.HasKey(e => e.ColName)
                    .HasName("sys_fldstxt_pk");
            });

            modelBuilder.Entity<T2Geolunits>(entity =>
            {
                entity.HasKey(e => e.Nn)
                    .HasName("t2_geolunits_pk");

                entity.HasIndex(e => e.Nn)
                    .HasName("t2_geolunits_unq")
                    .IsUnique();

                entity.Property(e => e.Nn).ValueGeneratedNever();

                entity.HasOne(d => d.Kd)
                    .WithMany(p => p.T2Geolunits)
                    .HasPrincipalKey(p => p.KdId)
                    .HasForeignKey(d => d.KdId)
                    .HasConstraintName("t2_deposit1810_kd_id_fk");
            });

            modelBuilder.Entity<T3Rock>(entity =>
            {
                entity.HasKey(e => e.Nn)
                    .HasName("t3_rock_pk");

                entity.Property(e => e.Nn).ValueGeneratedNever();

                entity.HasOne(d => d.Kd)
                    .WithMany(p => p.T3Rock)
                    .HasPrincipalKey(p => p.KdId)
                    .HasForeignKey(d => d.KdId)
                    .HasConstraintName("t3_deposit1810_kd_id_fk");
            });

            modelBuilder.Entity<T4OreBody>(entity =>
            {
                entity.HasKey(e => e.Nn)
                    .HasName("t4_ore_body_pk");

                entity.Property(e => e.Nn).ValueGeneratedNever();

                entity.HasOne(d => d.Kd)
                    .WithMany(p => p.T4OreBody)
                    .HasPrincipalKey(p => p.KdId)
                    .HasForeignKey(d => d.KdId)
                    .HasConstraintName("t4_deposit1810_kd_id_fk");
            });

            modelBuilder.Entity<T5Mineral>(entity =>
            {
                entity.HasKey(e => e.Nn)
                    .HasName("t5_mineral_pk");

                entity.Property(e => e.Nn).ValueGeneratedNever();

                entity.HasOne(d => d.Kd)
                    .WithMany(p => p.T5Mineral)
                    .HasPrincipalKey(p => p.KdId)
                    .HasForeignKey(d => d.KdId)
                    .HasConstraintName("t5_mineral_deposit1810_kd_id_fk");
            });

            modelBuilder.Entity<T6Reser>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Kd)
                    .WithMany(p => p.T6Reser)
                    .HasPrincipalKey(p => p.KdId)
                    .HasForeignKey(d => d.KdId)
                    .HasConstraintName("t6_deposit1810_kd_id_fk");
            });

            modelBuilder.Entity<Test12>(entity =>
            {
                entity.HasNoKey();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
