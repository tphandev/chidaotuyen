using ChiDaoTuyen.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiDaoTuyen.Model.Models
{
    [Table("DaoTaoLienTuc")]
    public class DaoTaoLienTuc:Auditable
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID { set; get; }

        [Column(TypeName = "nvarchar")]
        [MaxLength(128)]
        public string MaNhanVien { get; set; }

        public string NoiDung { get; set; }
        public int SoTiet { get; set; }

        public int IDHinhThuc { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(15)]
        public string MaKhoaPhong { get; set; }

        [ForeignKey("MaKhoaPhong")]
        public KhoaPhong KhoaPhong { get; set; }

        [ForeignKey("MaNhanVien")]
        public NhanVien NhanVien { get; set; }

        [ForeignKey("IDHinhThuc")]
        public HinhThucDaoTao HinhThucDaoTao { get; set; }




    }
}
