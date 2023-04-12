using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BTLWebVeXe.Models
{
    public partial class DatabaseQLyVeXeContext : DbContext
    {
        public DatabaseQLyVeXeContext()
        {
        }

        public DatabaseQLyVeXeContext(DbContextOptions<DatabaseQLyVeXeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<KhachHang> KhachHangs { get; set; } = null!;
        public virtual DbSet<Qtri> Qtris { get; set; } = null!;
        public virtual DbSet<ThongTinChuyen> ThongTinChuyens { get; set; } = null!;
        public virtual DbSet<ThongTinTuyen> ThongTinTuyens { get; set; } = null!;
        public virtual DbSet<ThongTinVe> ThongTinVes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-EI91MQN;Database=DatabaseQLyVeXe;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasKey(e => e.HoTen)
                    .HasName("PK__KhachHang__27AEE13D78EE9B6B");

                entity.ToTable("KhachHang");

                entity.Property(e => e.HoTen).HasMaxLength(50);

                entity.Property(e => e.DiaChi).HasMaxLength(30);
            });

            modelBuilder.Entity<Qtri>(entity =>
            {
                entity.HasKey(e => e.MaNv)
                    .HasName("PK__QTri__2725D70A4349F7D3");

                entity.ToTable("QTri");

                entity.Property(e => e.MaNv)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MaNV");

                entity.Property(e => e.MatKhau)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaiKhoan).HasMaxLength(50);
            });

            modelBuilder.Entity<ThongTinChuyen>(entity =>
            {
                entity.HasKey(e => e.MaChuyen)
                    .HasName("PK__ThongTin__AE260CDCF1F4DD6C");

                entity.ToTable("ThongTinChuyen");

                entity.Property(e => e.MaChuyen)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TrangThai).HasMaxLength(20);

                entity.Property(e => e.Tuyen).HasMaxLength(50);

                entity.HasOne(d => d.TuyenNavigation)
                    .WithMany(p => p.ThongTinChuyens)
                    .HasForeignKey(d => d.Tuyen)
                    .HasConstraintName("FK__ThongTinC__Tuyen__3D5E1FD2");
            });

            modelBuilder.Entity<ThongTinTuyen>(entity =>
            {
                entity.HasKey(e => e.Tuyen)
                    .HasName("PK__ThongTin__A189BD30B8920EFC");

                entity.ToTable("ThongTinTuyen");

                entity.Property(e => e.Tuyen).HasMaxLength(50);

                entity.Property(e => e.MaTuyen).HasMaxLength(30);
            });

            modelBuilder.Entity<ThongTinVe>(entity =>
            {
                entity.HasKey(e => e.MaVe)
                    .HasName("PK__ThongTin__2725100F9461A9D1");

                entity.ToTable("ThongTinVe");

                entity.Property(e => e.LoaiVe)
                    .HasMaxLength(20);

                entity.Property(e => e.TenKh).HasMaxLength(50);
                entity.Property(e => e.SoDt)
                    .HasMaxLength(20);
                entity.Property(e => e.ThoiGian)
                    .HasMaxLength(30);

                entity.Property(e => e.Tuyen).HasMaxLength(50);


                entity.HasOne(d => d.TuyenNavigation)
                    .WithMany(p => p.ThongTinVes)
                    .HasForeignKey(d => d.Tuyen)
                    .HasConstraintName("FK__ThongTinV__Tuyen__403A8C7D");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
