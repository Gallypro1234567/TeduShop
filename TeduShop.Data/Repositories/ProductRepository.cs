using TeduShop.Data.Infrastructure;
using TeduShop.Model.Model;

namespace TeduShop.Data.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
    }

    public class ProductRepository : Infrastructure.RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}