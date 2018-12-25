using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory dbfactory;
        private TedushopDbContext dbContext;
        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbfactory = dbfactory;
        }
        public TedushopDbContext DbContext
        {
            get { return dbContext ?? (dbContext = dbfactory.Init()); }
        }
        public void Commit()
        {
            DbContext.SaveChanges();
        }
    }
}
