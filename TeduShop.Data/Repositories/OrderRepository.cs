using TeduShop.Data.Infrastructure;
using TeduShop.Model.Model;

namespace TeduShop.Data.Repositories
{
    public interface IOrderRepository
    {
    }

    public class OrderlRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderlRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}