namespace ChiDaoTuyen.Data.Migrations
{
    using Model.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Model.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Model.Models;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<ChiDaoTuyen.Data.ChiDaoTuyenDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ChiDaoTuyen.Data.ChiDaoTuyenDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            CreateUser(context);
            CreateKhoaPhong(context);
        }
        private void CreateKhoaPhong(ChiDaoTuyenDbContext context)
        {
            if (context.KhoaPhongs.Count() == 0)
            {
                List<KhoaPhong> listKhoaPhong = new List<KhoaPhong>() {
                new KhoaPhong() { MaKhoaPhong = "SN001", TenKhoaPhong="KHOA CHẨN ĐOÁN HÌNH ẢNH",xoa=false},
                new KhoaPhong() { MaKhoaPhong = "SN002", TenKhoaPhong = "KHOA DƯỢC- VẬT TƯ Y TẾ", xoa = false },
                new KhoaPhong() { MaKhoaPhong = "SN003", TenKhoaPhong = "KHOA HSTC & CĐ NHI", xoa = false },
                new KhoaPhong() { MaKhoaPhong = "SN004", TenKhoaPhong = "KHOA KHÁM- CẤP CỨU TỔNG HỢP", xoa = false },
                new KhoaPhong() { MaKhoaPhong = "SN005", TenKhoaPhong = "KHOA KIỂM SOÁT NHIỄM KHUẨN", xoa = false },
                new KhoaPhong() { MaKhoaPhong = "SN006", TenKhoaPhong = "KHOA NGOẠI NHI - LIÊN CHUYÊN KHOA", xoa = false },
                new KhoaPhong() { MaKhoaPhong = "SN007", TenKhoaPhong = "KHOA NHI", xoa = false },
                new KhoaPhong() { MaKhoaPhong = "SN008", TenKhoaPhong = "KHOA PHẪU THUẬT GÂY MÊ HỒI SỨC", xoa = false },
                new KhoaPhong() { MaKhoaPhong = "SN009", TenKhoaPhong = "KHOA PHỤ- HẬU PHẪU- HẬU SẢN", xoa = false },
                new KhoaPhong() { MaKhoaPhong = "SN010", TenKhoaPhong = "KHOA SANH", xoa = false },
                new KhoaPhong() { MaKhoaPhong = "SN011", TenKhoaPhong = "KHOA SƠ SINH", xoa = false },
                new KhoaPhong() { MaKhoaPhong = "SN012", TenKhoaPhong = "KHOA XÉT NGHIỆM", xoa = false },
                new KhoaPhong() { MaKhoaPhong = "SN013", TenKhoaPhong = "PHÒNG KẾ HOẠCH TỔNG HỢP", xoa = false },
                new KhoaPhong() { MaKhoaPhong = "SN014", TenKhoaPhong = "KPHÒNG TÀI CHÍNH KẾ TOÁN", xoa = false },
                new KhoaPhong() { MaKhoaPhong = "SN015", TenKhoaPhong = "PHÒNG TỔ CHỨC- HÀNH CHÍNH QUẢN TRỊ", xoa = false },
                new KhoaPhong() { MaKhoaPhong = "SN016", TenKhoaPhong = "PHÒNG ĐIỀU DƯỠNG", xoa = false },

            };
                context.KhoaPhongs.AddRange(listKhoaPhong);
                context.SaveChanges();
            }
        }
        private void CreateUser(ChiDaoTuyenDbContext context)
        {
            if (context.Users.Count() == 0)
            {
                var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ChiDaoTuyenDbContext()));

                var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new ChiDaoTuyenDbContext()));

                var user = new ApplicationUser()
                {
                    UserName = "tphan",
                    Email = "tphan.dev@gmail.com",
                    EmailConfirmed = true,
                    FullName = "Trần Phan",
                    DateOfBirth = new DateTime(1992, 1, 23)
                };

                manager.Create(user, "12345678@X");

                if (!roleManager.Roles.Any())
                {
                    roleManager.Create(new IdentityRole { Name = "Admin" });
                    roleManager.Create(new IdentityRole { Name = "User" });
                }

                var adminUser = manager.FindByEmail("tphan.dev@gmail.com");

                manager.AddToRoles(adminUser.Id, new string[] { "Admin", "User" });
            }
        }
    }
}
