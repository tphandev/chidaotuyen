using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChiDaoTuyen.Web.Models
{
    public class NhanVienViewModel
    {
       
        public string MaNhanVien { get; set; }

      
        public string HoTen { set; get; }

        public int GioiTinh { set; get; }

        public DateTime NgaySinh { set; get; }

        public string MaKhoaPhong { get; set; }

    
        public KhoaPhongViewModel KhoaPhong { get; set; }

        
        public string MaChucVu { get; set; }

        
        public ChucVuViewModel ChucVu { get; set; }

       
        public string MaChucDanh { get; set; }

       
        public ChucDanhViewModel ChucDanh { get; set; }

        
        public string MaLoai { get; set; }

       
        public LoaiNhanVienViewModel LoaiNhanVien { get; set; }

    
        public string GhiChu { set; get; }

        public virtual ICollection<DaoTaoLienTucViewModel> DaoTaoLienTucs { get; set; }


        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayCapNhat { get; set; }
        public string NguoiCapNhat { get; set; }
        public bool xoa { get; set; }
    }
}