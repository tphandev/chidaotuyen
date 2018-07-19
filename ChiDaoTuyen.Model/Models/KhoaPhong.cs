using ChiDaoTuyen.Model.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChiDaoTuyen.Model.Models
{
    [Table("Khoa")]
    public class KhoaPhong : Auditable
    {
        [Key]
        [Column(TypeName = "varchar")]
        [MaxLength(15)]
        public string MaKhoaPhong { get; set; }

        [MaxLength(256)]
        public string TenKhoaPhong { get; set; }

        public virtual ICollection<NhanVien> NhanViens { get; set; }
        public virtual ICollection<DaoTaoLienTuc> DaoTaoLienTucs { get; set; }
    }
}