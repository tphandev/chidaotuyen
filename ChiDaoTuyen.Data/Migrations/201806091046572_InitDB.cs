namespace ChiDaoTuyen.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChucDanh",
                c => new
                    {
                        MaChucDanh = c.String(nullable: false, maxLength: 15, unicode: false),
                        TenChucDanh = c.String(maxLength: 256),
                        NgayTao = c.DateTime(),
                        NguoiTao = c.String(maxLength: 256),
                        NgayCapNhat = c.DateTime(),
                        NguoiCapNhat = c.String(maxLength: 256),
                        xoa = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MaChucDanh);
            
            CreateTable(
                "dbo.NhanVien",
                c => new
                    {
                        MaNhanVien = c.String(nullable: false, maxLength: 128),
                        HoTen = c.String(maxLength: 256),
                        GioiTinh = c.Int(nullable: false),
                        NgaySinh = c.DateTime(nullable: false),
                        MaKhoaPhong = c.String(maxLength: 15, unicode: false),
                        MaChucVu = c.String(maxLength: 15, unicode: false),
                        MaChucDanh = c.String(maxLength: 15, unicode: false),
                        MaLoai = c.String(maxLength: 15, unicode: false),
                        GhiChu = c.String(maxLength: 500),
                        NgayTao = c.DateTime(),
                        NguoiTao = c.String(maxLength: 256),
                        NgayCapNhat = c.DateTime(),
                        NguoiCapNhat = c.String(maxLength: 256),
                        xoa = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MaNhanVien)
                .ForeignKey("dbo.ChucDanh", t => t.MaChucDanh)
                .ForeignKey("dbo.ChucVu", t => t.MaChucVu)
                .ForeignKey("dbo.Khoa", t => t.MaKhoaPhong)
                .ForeignKey("dbo.LoaiNhanVien", t => t.MaLoai)
                .Index(t => t.MaKhoaPhong)
                .Index(t => t.MaChucVu)
                .Index(t => t.MaChucDanh)
                .Index(t => t.MaLoai);
            
            CreateTable(
                "dbo.ChucVu",
                c => new
                    {
                        MaChucVu = c.String(nullable: false, maxLength: 15, unicode: false),
                        TenChucVu = c.String(maxLength: 256),
                        NgayTao = c.DateTime(),
                        NguoiTao = c.String(maxLength: 256),
                        NgayCapNhat = c.DateTime(),
                        NguoiCapNhat = c.String(maxLength: 256),
                        xoa = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MaChucVu);
            
            CreateTable(
                "dbo.DaoTaoLienTuc",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MaNhanVien = c.String(maxLength: 128),
                        NoiDung = c.String(),
                        SoTiet = c.Int(nullable: false),
                        IDHinhThuc = c.Int(nullable: false),
                        MaKhoaPhong = c.String(maxLength: 15, unicode: false),
                        NgayTao = c.DateTime(),
                        NguoiTao = c.String(maxLength: 256),
                        NgayCapNhat = c.DateTime(),
                        NguoiCapNhat = c.String(maxLength: 256),
                        xoa = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.HinhThucDaoTao", t => t.IDHinhThuc, cascadeDelete: true)
                .ForeignKey("dbo.Khoa", t => t.MaKhoaPhong)
                .ForeignKey("dbo.NhanVien", t => t.MaNhanVien)
                .Index(t => t.MaNhanVien)
                .Index(t => t.IDHinhThuc)
                .Index(t => t.MaKhoaPhong);
            
            CreateTable(
                "dbo.HinhThucDaoTao",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TenHinhThuc = c.String(),
                        SoTiet = c.Int(nullable: false),
                        NgayTao = c.DateTime(),
                        NguoiTao = c.String(maxLength: 256),
                        NgayCapNhat = c.DateTime(),
                        NguoiCapNhat = c.String(maxLength: 256),
                        xoa = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Khoa",
                c => new
                    {
                        MaKhoaPhong = c.String(nullable: false, maxLength: 15, unicode: false),
                        TenKhoaPhong = c.String(maxLength: 256),
                        NgayTao = c.DateTime(),
                        NguoiTao = c.String(maxLength: 256),
                        NgayCapNhat = c.DateTime(),
                        NguoiCapNhat = c.String(maxLength: 256),
                        xoa = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MaKhoaPhong);
            
            CreateTable(
                "dbo.LoaiNhanVien",
                c => new
                    {
                        MaLoai = c.String(nullable: false, maxLength: 15, unicode: false),
                        TenLoai = c.String(maxLength: 256),
                        NgayTao = c.DateTime(),
                        NguoiTao = c.String(maxLength: 256),
                        NgayCapNhat = c.DateTime(),
                        NguoiCapNhat = c.String(maxLength: 256),
                        xoa = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MaLoai);
            
            CreateTable(
                "dbo.Errors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Message = c.String(),
                        StackTrace = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.IdentityRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IdentityUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                        IdentityRole_Id = c.String(maxLength: 128),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.IdentityRoles", t => t.IdentityRole_Id)
                .ForeignKey("dbo.ApplicationUsers", t => t.ApplicationUser_Id)
                .Index(t => t.IdentityRole_Id)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.ApplicationUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        FullName = c.String(maxLength: 256),
                        DateOfBirth = c.DateTime(nullable: false),
                        Email = c.String(),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IdentityUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ApplicationUsers", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.IdentityUserLogins",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        LoginProvider = c.String(),
                        ProviderKey = c.String(),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.ApplicationUsers", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.IdentityUserRoles", "ApplicationUser_Id", "dbo.ApplicationUsers");
            DropForeignKey("dbo.IdentityUserLogins", "ApplicationUser_Id", "dbo.ApplicationUsers");
            DropForeignKey("dbo.IdentityUserClaims", "ApplicationUser_Id", "dbo.ApplicationUsers");
            DropForeignKey("dbo.IdentityUserRoles", "IdentityRole_Id", "dbo.IdentityRoles");
            DropForeignKey("dbo.NhanVien", "MaLoai", "dbo.LoaiNhanVien");
            DropForeignKey("dbo.DaoTaoLienTuc", "MaNhanVien", "dbo.NhanVien");
            DropForeignKey("dbo.NhanVien", "MaKhoaPhong", "dbo.Khoa");
            DropForeignKey("dbo.DaoTaoLienTuc", "MaKhoaPhong", "dbo.Khoa");
            DropForeignKey("dbo.DaoTaoLienTuc", "IDHinhThuc", "dbo.HinhThucDaoTao");
            DropForeignKey("dbo.NhanVien", "MaChucVu", "dbo.ChucVu");
            DropForeignKey("dbo.NhanVien", "MaChucDanh", "dbo.ChucDanh");
            DropIndex("dbo.IdentityUserLogins", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.IdentityUserClaims", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.IdentityUserRoles", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.IdentityUserRoles", new[] { "IdentityRole_Id" });
            DropIndex("dbo.DaoTaoLienTuc", new[] { "MaKhoaPhong" });
            DropIndex("dbo.DaoTaoLienTuc", new[] { "IDHinhThuc" });
            DropIndex("dbo.DaoTaoLienTuc", new[] { "MaNhanVien" });
            DropIndex("dbo.NhanVien", new[] { "MaLoai" });
            DropIndex("dbo.NhanVien", new[] { "MaChucDanh" });
            DropIndex("dbo.NhanVien", new[] { "MaChucVu" });
            DropIndex("dbo.NhanVien", new[] { "MaKhoaPhong" });
            DropTable("dbo.IdentityUserLogins");
            DropTable("dbo.IdentityUserClaims");
            DropTable("dbo.ApplicationUsers");
            DropTable("dbo.IdentityUserRoles");
            DropTable("dbo.IdentityRoles");
            DropTable("dbo.Errors");
            DropTable("dbo.LoaiNhanVien");
            DropTable("dbo.Khoa");
            DropTable("dbo.HinhThucDaoTao");
            DropTable("dbo.DaoTaoLienTuc");
            DropTable("dbo.ChucVu");
            DropTable("dbo.NhanVien");
            DropTable("dbo.ChucDanh");
        }
    }
}
