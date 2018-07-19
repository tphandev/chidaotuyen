using ChiDaoTuyen.Data.Infrastructure;
using ChiDaoTuyen.Model.Models;

namespace ChiDaoTuyen.Data.Repositories
{
    public interface IDaoTaoLienTucRepository : IRepository<DaoTaoLienTuc>
    {
    }

    public class DaoTaoLienTucRepository : RepositoryBase<DaoTaoLienTuc>, IDaoTaoLienTucRepository
    {
        public DaoTaoLienTucRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}