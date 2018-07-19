namespace ChiDaoTuyen.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private ChiDaoTuyenDbContext dbContext;

        public ChiDaoTuyenDbContext Init()
        {
            return dbContext ?? (dbContext = new ChiDaoTuyenDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}