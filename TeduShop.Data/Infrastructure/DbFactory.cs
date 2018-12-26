namespace TeduShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private TedushopDbContext DbContext;

        public TedushopDbContext Init()
        {
            return DbContext ?? (DbContext = new TedushopDbContext());
        }

        protected override void DisposeCore()
        {
            if (DbContext != null)
                DbContext.Dispose();
        }
    }
}