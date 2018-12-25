using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        TedushopDbContext DbContext;
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
