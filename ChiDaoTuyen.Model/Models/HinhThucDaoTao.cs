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
    [Table("HinhThucDaoTao")]
    public class HinhThucDaoTao: Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public string TenHinhThuc { get; set; }
        public int SoTiet { get; set; }
        public virtual ICollection<DaoTaoLienTuc> DaoTaoLienTucs { get; set; }
    }
}
