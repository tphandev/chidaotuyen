using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiDaoTuyen.Model.Abstract
{
   public interface IAudiable
    {
        DateTime? NgayTao { get; set; }
        string NguoiTao { get; set; }
        DateTime? NgayCapNhat { get; set; }
        string NguoiCapNhat { get; set; }
        bool xoa { get; set; }
    }
}
