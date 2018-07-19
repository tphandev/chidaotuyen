using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiDaoTuyen.Model.Abstract
{
    public abstract class Auditable:IAudiable
    {
        public DateTime? NgayTao { get; set; }
        [MaxLength(256)]
        public string NguoiTao { get; set; }
        public DateTime? NgayCapNhat { get; set; }
        [MaxLength(256)]
        public string NguoiCapNhat { get; set; }
        public bool xoa { get; set; }
    }
}
