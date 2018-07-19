using ChiDaoTuyen.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChiDaoTuyen.Model.Models
{
    [Table("NhanVien")]
    public class NhanVien : Auditable
    {
        [Key]
        [Column(TypeName = "nvarchar")]
        [MaxLength(128)]
        public string MaNhanVien { get; set; }

        [MaxLength(256)]
        public string HoTen { set; get; }

        public int GioiTinh { set; get; }

        public DateTime NgaySinh { set; get; }

        [Column(TypeName = "varchar")]
        [MaxLength(15)]
        public string MaKhoaPhong { get; set; }

        [ForeignKey("MaKhoaPhong")]
        public KhoaPhong KhoaPhong { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(15)]
        public string MaChucVu { get; set; }

        [ForeignKey("MaChucVu")]
        public ChucVu ChucVu { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(15)]
        public string MaChucDanh { get; set; }

        [ForeignKey("MaChucDanh")]
        public ChucDanh ChucDanh { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(15)]
        public string MaLoai { get; set; }

        [ForeignKey("MaLoai")]
        public LoaiNhanVien LoaiNhanVien { get; set; }

        [MaxLength(500)]
        public string GhiChu { set; get; }

        public virtual ICollection<DaoTaoLienTuc> DaoTaoLienTucs { get; set; }      
    }
}