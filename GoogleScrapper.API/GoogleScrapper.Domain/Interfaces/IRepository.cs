using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GoogleScrapper.Domain.Interfaces
{
    public interface IRepository<T>
    {
        void Add(T entity);
        void AddRange(List<T> entity);
        Task<T> GetAsync(Expression<Func<T, bool>> predicate);
        IQueryable<T> Query(Expression<Func<T, bool>> predicate);

        IQueryable<T> Query();

        void Update(T entity);

        void UpdateRange(List<T> entities);

        void Remove(T entity);

        void RemoveRange(List<T> entities);

        Task SaveChangesAsync();
    }
}
