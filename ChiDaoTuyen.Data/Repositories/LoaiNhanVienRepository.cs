using ChiDaoTuyen.Data.Infrastructure;
using ChiDaoTuyen.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiDaoTuyen.Data.Repositories
{
    public interface ILoaiNhanVienRepository : IRepository<LoaiNhanVien>
    {

    }
    public class LoaiNhanVienRepository : RepositoryBase<LoaiNhanVien>, ILoaiNhanVienRepository
    {
        public LoaiNhanVienRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
