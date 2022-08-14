using GoogleScrapper.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GoogleScrapper.Infrastructure.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly DbContext _Context;

        public Repository(DbContext context)
        {
            _Context = context;
        }

        public void Add(T entity)
        {
            _Context.Set<T>().Add(entity);
        }

        public void AddRange(List<T> entity)
        {
            _Context.Set<T>().AddRange(entity);
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> predicate)
        {
            return await _Context.Set<T>().Where(predicate).FirstOrDefaultAsync();
        }

        public IQueryable<T> Query(Expression<Func<T, bool>> predicate)
        {
            return _Context.Set<T>().Where(predicate).AsQueryable();
        }

        public IQueryable<T> Query()
        {
            return _Context.Set<T>().AsQueryable();
        }

        public void Update(T entity)
        {
            _Context.Entry<T>(entity).State = EntityState.Modified;
        }

        public void UpdateRange(List<T> entities)
        {
            entities.ToList().ForEach(e =>
            {
                _Context.Entry<T>(e).State = EntityState.Modified;
            });
        }

        public void Remove(T entity)
        {
            _Context.Entry<T>(entity).State = EntityState.Deleted;
        }

        public void RemoveRange(List<T> entities)
        {
            entities.ToList().ForEach(e =>
            {
                _Context.Entry<T>(e).State = EntityState.Deleted;
            });
        }

        public async Task SaveChangesAsync()
        {
            await _Context.SaveChangesAsync(new CancellationToken());
        }
    }
}
