using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChiDaoTuyen.Web.Models
{
    public class LoaiNhanVienViewModel
    {

        public string MaLoai { get; set; }


        public string TenLoai { get; set; }

        public virtual ICollection<NhanVienViewModel> NhanViens { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayCapNhat { get; set; }
        public string NguoiCapNhat { get; set; }
        public bool xoa { get; set; }
    }
}