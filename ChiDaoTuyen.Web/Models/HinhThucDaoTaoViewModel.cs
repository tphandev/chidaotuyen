using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChiDaoTuyen.Web.Models
{
    public class HinhThucDaoTaoViewModel
    {
        public int ID { get; set; }

        public string TenHinhThuc { get; set; }
        public int SoTiet { get; set; }
        public virtual ICollection<DaoTaoLienTucViewModel> DaoTaoLienTucs { get; set; }

        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayCapNhat { get; set; }
        public string NguoiCapNhat { get; set; }
        public bool xoa { get; set; }
    }
}