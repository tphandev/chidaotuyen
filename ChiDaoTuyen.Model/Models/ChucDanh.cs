using ChiDaoTuyen.Model.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChiDaoTuyen.Model.Models
{
    [Table("ChucDanh")]
    public class ChucDanh : Auditable
    {
        [Key]
        [Column(TypeName = "varchar")]
        [MaxLength(15)]
        public string MaChucDanh { get; set; }

        [MaxLength(256)]
        public string TenChucDanh { get; set; }

        public virtual ICollection<NhanVien> NhanViens { get; set; }
    }
}