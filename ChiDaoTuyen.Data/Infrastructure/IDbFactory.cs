using System;

namespace ChiDaoTuyen.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        ChiDaoTuyenDbContext Init();
    }
}