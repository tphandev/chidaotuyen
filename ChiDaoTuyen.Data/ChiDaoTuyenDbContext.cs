using ChiDaoTuyen.Model.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace ChiDaoTuyen.Data
{
    public class ChiDaoTuyenDbContext : IdentityDbContext<ApplicationUser>
    {
        public ChiDaoTuyenDbContext() : base("ChiDaoTuyenConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
        public DbSet<DaoTaoLienTuc> DaoTaoLienTucs { get; set; }
        public DbSet<LoaiNhanVien> LoaiNhanViens { get; set; }
        public DbSet<ChucDanh> ChucDanhs { get; set; }
        public DbSet<ChucVu> ChucVus { get; set; }
        public DbSet<KhoaPhong> KhoaPhongs { get; set; }
        public DbSet<HinhThucDaoTao> HinhThucDaoTaos { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<Error> Errors { get; set; }

        public static ChiDaoTuyenDbContext Create()
        {
            return new ChiDaoTuyenDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUserRole>().HasKey(i => new { i.UserId, i.RoleId });
            modelBuilder.Entity<IdentityUserLogin>().HasKey(i => i.UserId);
          
        }
    }
}
