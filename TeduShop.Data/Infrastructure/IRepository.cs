using System;
using System.Linq;
  using System.Linq.Expressions;

namespace TeduShop.Data.Infrastructure
{
    public interface IRepository<T> where T : class
    {
        //danh dau 1 entity moi
        void Add(T entity);

        // danh dau 1  entity sua doi
        void Update(T entity);

        // danh dau 1 entity xoa
        void Delete(T entity);

        // Delete multi records
        void DeleteMulti(Expression<Func<T, bool>> where);

        // get an entity by int id
        T GettingleById(int id);

        T GetSingByCondition(Expression<Func<T, bool>> expression, String[] includes = null);

        IQueryable<T> GetAll(string[] includes = null);

        IQueryable<T> GetMulti(Expression<Func<T, bool>> predicate, string[] includes = null);

        IQueryable<T> GetMultiPaging(Expression<Func<T, bool>> filter, out int total, int index = 0, int size = 50, string[] includes = null);

        int Count(Expression<Func<T, bool>> where);

        int CheckContains(Expression<Func<T, bool>> predicate);
    }
}