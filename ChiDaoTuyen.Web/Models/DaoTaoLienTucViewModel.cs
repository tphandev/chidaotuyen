using System;

namespace ChiDaoTuyen.Web.Models
{
    public class DaoTaoLienTucViewModel
    {
        public int ID { set; get; }

        public string MaNhanVien { get; set; }

        public string NoiDung { get; set; }
        public int SoTiet { get; set; }

        public int IDHinhThuc { get; set; }

        public string MaKhoaPhong { get; set; }

        public KhoaPhongViewModel KhoaPhong { get; set; }

        public NhanVienViewModel NhanVien { get; set; }

        public HinhThucDaoTaoViewModel HinhThucDaoTao { get; set; }

        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayCapNhat { get; set; }
        public string NguoiCapNhat { get; set; }
        public bool xoa { get; set; }

    }
}