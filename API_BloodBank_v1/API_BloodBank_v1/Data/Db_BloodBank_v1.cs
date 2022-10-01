using Microsoft.EntityFrameworkCore;

namespace API_BloodBank_v1.Data
{
    public class Db_BloodBank_v1 : DbContext
    {
        public Db_BloodBank_v1(DbContextOptions options) : base(options) { }

        #region DbSet
        public DbSet<NguoiHienMau> NguoiHienMaus { get; set; }

        public DbSet<ChiTietSuDung> ChiTietSuDungs { get; set; }

        public DbSet<ChiTietSuKien> ChiTietSuKiens { get; set; }

        public DbSet<ChiTietBenhVien> ChiTietBenhViens { get; set; }

        public DbSet<ChiTietYeuCau> ChiTietYeuCaus { get; set; }

        public DbSet<BacSi> BacSis { get; set; }

        public DbSet<BenhVien> BenhViens { get; set; }

        public DbSet<DiaChi> DiaChis { get; set; }

        public DbSet<SuKienHienMau> SuKienHienMaus { get; set; }

        public DbSet<KetQuaXetNghiem> KetQuaXetNghiems { get; set; }

        public DbSet<LoaiMau> LoaiMaus { get; set; }

        public DbSet<LoaiXetNghiem> LoaiXetNghiems { get; set; }

        public DbSet<YeuCau> YeuCaus { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NguoiHienMau>(nhm =>
            {
                nhm.ToTable("NguoiHienMau");
                nhm.HasKey(n => n.UID);

                nhm.Property(n => n.Username).HasMaxLength(50);
                nhm.HasIndex(n => n.Username).IsUnique();

                nhm.Property(n => n.Password).HasMaxLength(50);

                nhm.Property(n => n.Address).HasMaxLength(150).IsUnicode();

                nhm.Property(n => n.Email).HasMaxLength(150);

                nhm.Property(n => n.Sdt).HasMaxLength(13);
                nhm.HasIndex(n => n.Sdt).IsUnique();

                nhm.Property(n => n.HinhAnh).HasMaxLength(150);
            });

            modelBuilder.Entity<LoaiXetNghiem>(lxn =>
            {
                lxn.ToTable("LoaiXetNghiem");

                lxn.HasKey(l => l.ID_LoaiXetNghiem);

                lxn.Property(l => l.TenLoai).HasMaxLength(100).IsUnicode();
                
            });

            modelBuilder.Entity<LoaiMau>(m =>
            {
                m.ToTable("LoaiMau");

                m.HasKey(lm => lm.Id_LoaiMau);

                m.Property(lm => lm.TenLoai).HasMaxLength(50).IsUnicode();

                m.Property(lm => lm.TheTich).HasDefaultValue(0);
            });

            modelBuilder.Entity<BacSi>(bs =>
            {
                bs.HasKey(b => b.Id_BacSi);

                bs.ToTable("BacSi");

                bs.Property(b => b.Username).HasMaxLength(50);
                bs.HasIndex(b => b.Username).IsUnique();

                bs.Property(b => b.Password).HasMaxLength(50);
                bs.Property(n => n.Address).HasMaxLength(150).IsUnicode();

                bs.Property(n => n.Email).HasMaxLength(150);

                bs.Property(n => n.Sdt).HasMaxLength(13);
                bs.HasIndex(n => n.Sdt).IsUnique();

                bs.Property(n => n.HinhAnh).HasMaxLength(150);

            });

            modelBuilder.Entity<BenhVien>(bv =>
            {
                bv.ToTable("BenhVien");
                bv.HasKey(b => b.Id_BenhVien);

                bv.Property(b => b.TenBenhVien).HasMaxLength(150).IsUnicode();

                bv.Property(b => b.Dc_BenhVien).HasMaxLength(150).IsUnicode();
            });

            modelBuilder.Entity<DiaChi>(dc =>
            {
                dc.ToTable("DiaChi");
                dc.HasKey(d => d.Id_DC);
                dc.Property(b => b.ChiTiet).HasMaxLength(150).IsUnicode();
            });

            modelBuilder.Entity<YeuCau>(y =>
            {
                y.ToTable("YeuCau");
                y.HasKey(yc => new { yc.Id_BacSi, yc.Id_BenhVien });
                y.Property(yc => yc.FileKetQua).HasMaxLength(100);

                y.HasOne(b => b.BacSi)
                .WithMany(yc => yc.yeuCaus)
                .HasForeignKey(b => b.Id_BacSi).OnDelete(DeleteBehavior.SetNull)
               . HasConstraintName("bacsi_yeucau");

                y.HasOne(b => b.BenhVien)
                .WithMany(b => b.yeuCaus)
                .HasForeignKey(b => b.Id_BenhVien).OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("yeuccau_benhvien");
            });

            modelBuilder.Entity<ChiTietBenhVien>(ct =>
            {
                ct.ToTable("ChiTietBenhVien");
                ct.HasKey(c =>new {c.Id_BenhVien, c.Id_BacSi});

                ct.HasOne(bs => bs.BacSi)
                .WithMany( c => c.chiTietBenhViens)
                .HasForeignKey(bs => bs.Id_BacSi).OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("bacsi_lamviec_chitietbenhvien");

                ct.HasOne(bv => bv.BenhVien)
                .WithMany(c => c.chiTietBenhViens)
                .HasForeignKey(c => c.Id_BenhVien).OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("Benhvien_co_chitietbenhvien");
            });

            modelBuilder.Entity<SuKienHienMau>(sk =>
            {
                sk.ToTable("SuKienHienMau");
                sk.HasKey(s => s.Id_SuKien);
                sk.Property(s => s.TieuDe).HasMaxLength(50).IsUnicode();
                sk.Property(s => s.MoTa).IsUnicode();

                sk.HasOne(dc => dc.DiaChi)
                .WithMany(s => s.SuKienHienMaus)
                .HasForeignKey(s => s.Id_DiaChi).OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("Diachi_cua_sukienhienmau");

                sk.HasOne(ct => ct.ChiTietBenhVien)
                .WithMany(s => s.SuKienHienMaus)
                .HasForeignKey(s => new { s.Id_BenhVien, s.Id_BacSi}).OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("BacSi_Tochuc_Sukienhienmaus");


            });

            modelBuilder.Entity<ChiTietSuKien>(ct =>
            {
                ct.ToTable("ChiTietSuKien");
                ct.HasKey(c => new { c.Id_NguoiHienMau, c.Id_SuKien });

                ct.HasOne(c => c.NguoiHienMau)
                .WithMany(c => c.ChiTietSuKiens)
                .HasForeignKey(c => c.Id_NguoiHienMau).OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("NguoiHienMau_thamgia_Sukien");

                ct.HasOne(c => c.SuKienHienMau)
                .WithMany(c => c.ChiTietSuKiens)
                .HasForeignKey(c => c.Id_SuKien).OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("SuKienHienMau_Co_ChiTietSuKien");
            });

            modelBuilder.Entity<KetQuaXetNghiem>(kq =>
            {
                kq.ToTable("KetQuaXetNghiem");
                kq.HasKey(k => new {k.Id_NguoiHienMau, k.Id_SuKien, k.Id_BacSi, k.Id_BenhVien, k.Id_LoaiMau, k.Id_LoaiXetNghiem});
                kq.Property(k => k.FileKetQua).HasMaxLength(100);

                kq.HasOne(k => k.ChiTietSuKien)
                .WithMany(k => k.KetQuaXetNghiems)
                .HasForeignKey(k => new { k.Id_NguoiHienMau, k.Id_SuKien }).OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ChiTietSuKien_KetQuaXetNghiem");

                kq.HasOne(k => k.LoaiXetNghiem)
                .WithMany(k => k.KetQuaXetNghiems)
                .HasForeignKey(k => k.Id_LoaiXetNghiem).OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("LoaiXetNghiem_KetQuaXetNGhiem");

                kq.HasOne(k => k.LoaiMau)
                .WithMany(k => k.KetQuaXetNghiems)
                .HasForeignKey(k => k.Id_LoaiMau).OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("LoaiMau_KetQuaXetNGhiem");

                kq.HasOne(k => k.ChiTietBenhVien)
                .WithMany(k => k.KetQuaXetNghiems)
                .HasForeignKey(k => new {k.Id_BenhVien, k.Id_BacSi}).OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ChiTietBenhVien_KetQuaXetNghiem");
                

            });

            modelBuilder.Entity<ChiTietSuDung>(ct =>
            {
                ct.ToTable("ChiTietSuDung");
                ct.HasKey(c => new { c.Id_BacSi_Nhap, c.Id_BenhVien_Dung, c.Id_BacSi_Dung, c.Id_LoaiMau, c.Id_LoaiXetNghiem, c.Id_BenhVien_Nhap, c.Id_SuKien, c.Id_NguoiHienMau });

                ct.HasOne(c => c.ChiTietBenhVien)
                .WithMany(c => c.ChiTietSuDungs)
                .HasForeignKey(c => new { c.Id_BenhVien_Dung, c.Id_BacSi_Dung }).OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("BacSiCuaBenhVien_SuDung");

                ct.HasOne(c => c.KetQuaXetNghiem)
                .WithMany(c => c.ChiTietSuDungs)
                .HasForeignKey(c => new { c.Id_NguoiHienMau, c.Id_SuKien, c.Id_BacSi_Nhap, c.Id_BenhVien_Nhap, c.Id_LoaiMau, c.Id_LoaiXetNghiem }).OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("KetQuaXetNghiem_DuocSuDungBoi_ChiTietSuDung");
            });

            modelBuilder.Entity<ChiTietYeuCau>(ct =>
            {
                ct.ToTable("ChiTietYeuCau");
                ct.HasKey(c => new { c.Id_LoaiMau, c.Id_BacSi, c.Id_BenhVien });

                ct.HasOne(c => c.YeuCau)
                .WithMany(c => c.ChiTietYeuCaus)
                .HasForeignKey(c => new { c.Id_BacSi, c.Id_BenhVien }).OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("YeuCau_Co_ChiTietYeuCau");

                 ct.HasOne(c => c.LoaiMau)
                .WithMany(c => c.ChiTietYeuCaus)
                .HasForeignKey(c =>  c.Id_LoaiMau).OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("LoaiMau_NamTrong_ChiTietYeuCau");

            });
        }
    }
}
