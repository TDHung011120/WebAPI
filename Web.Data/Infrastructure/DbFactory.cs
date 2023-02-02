namespace Web.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private APIDbContext dbContext;

        public APIDbContext Init()
        {
            return dbContext ?? (dbContext = new APIDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}