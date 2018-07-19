using ChiDaoTuyen.Model.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChiDaoTuyen.Model.Models
{
    [Table("ChucVu")]
    public class ChucVu : Auditable
    {
        [Key]
        [Column(TypeName = "varchar")]
        [MaxLength(15)]
        public string MaChucVu { get; set; }

        [MaxLength(256)]
        public string TenChucVu { get; set; }

        public virtual ICollection<NhanVien> NhanViens { get; set; }
    }
}