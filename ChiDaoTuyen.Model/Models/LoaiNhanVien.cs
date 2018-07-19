using ChiDaoTuyen.Model.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChiDaoTuyen.Model.Models
{
    [Table("LoaiNhanVien")]
    public class LoaiNhanVien : Auditable
    {
        [Key]
        [Column(TypeName = "varchar")]
        [MaxLength(15)]
        public string MaLoai { get; set; }

        [MaxLength(256)]
        public string TenLoai { get; set; }

        public virtual ICollection<NhanVien> NhanViens { get; set; }
    }
}