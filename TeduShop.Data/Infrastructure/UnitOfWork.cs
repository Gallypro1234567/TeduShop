namespace TeduShop.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private TedushopDbContext dbContext;

        public UnitOfWork(IDbFactory dbFactory)
        {
               this.dbFactory = dbFactory;
        }

        public TedushopDbContext DbContext
        {
            get { return dbContext ?? (dbContext = dbFactory.Init()); }
        }

        public void Commit()
        {
            DbContext.SaveChanges();
        }
    }
}