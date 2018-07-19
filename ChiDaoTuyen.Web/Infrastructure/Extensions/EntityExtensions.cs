using ChiDaoTuyen.Model.Models;
using ChiDaoTuyen.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChiDaoTuyen.Web.Infrastructure.Extensions
{
    public static class EntityExtensions
    {
        public static void UpdateDaoTaoLienTuc(this DaoTaoLienTuc daoTaoLienTuc, DaoTaoLienTucViewModel daoTaoLienTucVm)
        {
            daoTaoLienTuc.ID = daoTaoLienTucVm.ID;
            daoTaoLienTuc.IDHinhThuc = daoTaoLienTucVm.IDHinhThuc;
            daoTaoLienTuc.MaKhoaPhong = daoTaoLienTucVm.MaKhoaPhong;
            daoTaoLienTuc.MaNhanVien = daoTaoLienTucVm.MaNhanVien;
            daoTaoLienTuc.NoiDung = daoTaoLienTucVm.NoiDung;
            daoTaoLienTuc.SoTiet = daoTaoLienTucVm.SoTiet;
            daoTaoLienTuc.NgayCapNhat = daoTaoLienTucVm.NgayCapNhat;
            daoTaoLienTuc.NguoiCapNhat = daoTaoLienTucVm.NguoiCapNhat;
            daoTaoLienTuc.NgayTao = daoTaoLienTucVm.NgayTao;
            daoTaoLienTuc.NguoiTao = daoTaoLienTucVm.NguoiTao;
            daoTaoLienTuc.xoa = daoTaoLienTucVm.xoa;


        }
    }
}