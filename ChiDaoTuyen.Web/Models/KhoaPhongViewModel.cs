using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChiDaoTuyen.Web.Models
{
    public class KhoaPhongViewModel
    {
        public string MaKhoaPhong { get; set; }

        public string TenKhoaPhong { get; set; }

        public virtual IEnumerable<DaoTaoLienTucViewModel> DaoTaoLienTucs { get; set; }

        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayCapNhat { get; set; }
        public string NguoiCapNhat { get; set; }
        public bool xoa { get; set; }
    }
}