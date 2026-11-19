using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace NguyenNgoKhanhDuy_DH52200571.Models
{
    public partial class BongRoContext : DbContext
    {
        public BongRoContext()
        {
        }

        public BongRoContext(DbContextOptions<BongRoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DangKy> DangKies { get; set; } = null!;
        public virtual DbSet<DiemDanh> DiemDanhs { get; set; } = null!;
        public virtual DbSet<HocVien> HocViens { get; set; } = null!;
        public virtual DbSet<HuanLuyenVien> HuanLuyenViens { get; set; } = null!;
        public virtual DbSet<LichTap> LichTaps { get; set; } = null!;
        public virtual DbSet<LopHoc> LopHocs { get; set; } = null!;
        public virtual DbSet<NhanXet> NhanXets { get; set; } = null!;
        public virtual DbSet<SanTap> SanTaps { get; set; } = null!;
        public virtual DbSet<ThanhToan> ThanhToans { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(
     DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "Server=LAPTOP-EMG56GAA\\SQLEXPRESS;Database=BongRo;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DangKy>(entity =>
            {
                entity.ToTable("DangKy");

                entity.Property(e => e.DangKyId).HasColumnName("DangKyID");

                entity.Property(e => e.HocVienId).HasColumnName("HocVienID");

                entity.Property(e => e.LopHocId).HasColumnName("LopHocID");

                entity.Property(e => e.NgayDangKy).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TrangThai).HasMaxLength(50);

                entity.HasOne(d => d.HocVien)
                    .WithMany(p => p.DangKies)
                    .HasForeignKey(d => d.HocVienId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DangKy_HocVien");

                entity.HasOne(d => d.LopHoc)
                    .WithMany(p => p.DangKies)
                    .HasForeignKey(d => d.LopHocId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DangKy_LopHoc");
            });

            modelBuilder.Entity<DiemDanh>(entity =>
            {
                entity.ToTable("DiemDanh");

                entity.Property(e => e.DiemDanhId).HasColumnName("DiemDanhID");

                entity.Property(e => e.GhiChu).HasMaxLength(255);

                entity.Property(e => e.HocVienId).HasColumnName("HocVienID");

                entity.Property(e => e.LichTapId).HasColumnName("LichTapID");

                entity.Property(e => e.TrangThai).HasMaxLength(50);

                entity.HasOne(d => d.HocVien)
                    .WithMany(p => p.DiemDanhs)
                    .HasForeignKey(d => d.HocVienId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DiemDanh_HocVien");

                entity.HasOne(d => d.LichTap)
                    .WithMany(p => p.DiemDanhs)
                    .HasForeignKey(d => d.LichTapId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DiemDanh_LichTap");
            });

            modelBuilder.Entity<HocVien>(entity =>
            {
                entity.ToTable("HocVien");

                entity.Property(e => e.HocVienId).HasColumnName("HocVienID");

                entity.Property(e => e.DiaChi).HasMaxLength(255);

                entity.Property(e => e.GioiTinh).HasMaxLength(10);

                entity.Property(e => e.HoTen).HasMaxLength(100);

                entity.Property(e => e.NgaySinh).HasColumnType("date");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.HocViens)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HocVien_Users");
            });

            modelBuilder.Entity<HuanLuyenVien>(entity =>
            {
                entity.HasKey(e => e.Hlvid)
                    .HasName("PK__HuanLuye__B5D13EC98DC7ADF6");

                entity.ToTable("HuanLuyenVien");

                entity.Property(e => e.Hlvid).HasColumnName("HLVId");

                entity.Property(e => e.ChuyenMon).HasMaxLength(100);

                entity.Property(e => e.KinhNghiem).HasMaxLength(255);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.HuanLuyenViens)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HLV_Users");
            });

            modelBuilder.Entity<LichTap>(entity =>
            {
                entity.ToTable("LichTap");

                entity.Property(e => e.LichTapId).HasColumnName("LichTapID");

                entity.Property(e => e.LopHocId).HasColumnName("LopHocID");

                entity.Property(e => e.NgayTap).HasColumnType("date");

                entity.Property(e => e.SanTapId).HasColumnName("SanTapID");

                entity.HasOne(d => d.LopHoc)
                    .WithMany(p => p.LichTaps)
                    .HasForeignKey(d => d.LopHocId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LichTap_LopHoc");

                entity.HasOne(d => d.SanTap)
                    .WithMany(p => p.LichTaps)
                    .HasForeignKey(d => d.SanTapId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LichTap_SanTap");
            });

            modelBuilder.Entity<LopHoc>(entity =>
            {
                entity.ToTable("LopHoc");

                entity.Property(e => e.LopHocId).HasColumnName("LopHocID");

                entity.Property(e => e.Hlvid).HasColumnName("HLVId");

                entity.Property(e => e.HocPhi).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MoTa).HasMaxLength(500);

                entity.Property(e => e.TenLop).HasMaxLength(100);

                entity.Property(e => e.TrangThai).HasMaxLength(50);

                entity.HasOne(d => d.Hlv)
                    .WithMany(p => p.LopHocs)
                    .HasForeignKey(d => d.Hlvid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LopHoc_HLV");
            });

            modelBuilder.Entity<NhanXet>(entity =>
            {
                entity.ToTable("NhanXet");

                entity.Property(e => e.NhanXetId).HasColumnName("NhanXetID");

                entity.Property(e => e.Hlvid).HasColumnName("HLVId");

                entity.Property(e => e.HocVienId).HasColumnName("HocVienID");

                entity.Property(e => e.NgayNhanXet).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NoiDung).HasMaxLength(1000);

                entity.HasOne(d => d.Hlv)
                    .WithMany(p => p.NhanXets)
                    .HasForeignKey(d => d.Hlvid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NhanXet_HLV");

                entity.HasOne(d => d.HocVien)
                    .WithMany(p => p.NhanXets)
                    .HasForeignKey(d => d.HocVienId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NhanXet_HocVien");
            });

            modelBuilder.Entity<SanTap>(entity =>
            {
                entity.ToTable("SanTap");

                entity.Property(e => e.SanTapId).HasColumnName("SanTapID");

                entity.Property(e => e.DiaChi).HasMaxLength(255);

                entity.Property(e => e.TenSan).HasMaxLength(100);

                entity.Property(e => e.TrangThai).HasMaxLength(50);
            });

            modelBuilder.Entity<ThanhToan>(entity =>
            {
                entity.ToTable("ThanhToan");

                entity.Property(e => e.ThanhToanId).HasColumnName("ThanhToanID");

                entity.Property(e => e.DangKyId).HasColumnName("DangKyID");

                entity.Property(e => e.NgayThanhToan).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PhuongThuc).HasMaxLength(100);

                entity.Property(e => e.SoTien).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TrangThai).HasMaxLength(50);

                entity.HasOne(d => d.DangKy)
                    .WithMany(p => p.ThanhToans)
                    .HasForeignKey(d => d.DangKyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ThanhToan_DangKy");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
