using IIS_Projekat.Models;
using IIS_Projekat.Models.DTOs.Pagination;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;

namespace IIS_Projekat.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class, IEntity
    {
        private readonly DbContext _dbContext;

        public GenericRepository(DbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public T? Create(T entity)
        {
            DateTime now = DateTime.UtcNow;
            entity.CreatedDate = now;
            entity.ModifiedDate = now;
            _dbContext.Set<T>().Add(entity);
            return entity;
        }

        public void Delete(T entity)
        {
            entity.ModifiedDate = DateTime.UtcNow;
            entity.IsDeleted = true;
            _dbContext.Set<T>().Update(entity);
        }

        public IQueryable<T> GetAll(params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> entities = _dbContext.Set<T>();
            if (includes != null)
            {
                foreach (var include in includes)
                {
                    entities = entities.Include(include);
                }
            }
            return entities;
        }

        public PaginationWrapper<T> Filter(PaginationQuery? paginationQuery, params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> entities = _dbContext.Set<T>();
            if (includes != null)
            {
                foreach (var include in includes)
                {
                    entities = entities.Include(include);
                }
            }
            if (paginationQuery == null)
            {
                var list = entities.ToList();
                return new PaginationWrapper<T>(list, list.Count);
            }
            if (!paginationQuery.Filters.IsNullOrEmpty())
            {
                foreach (var filter in paginationQuery.Filters)
                {
                    entities = entities.Where(filter.ToString());
                }
            }
            if (!paginationQuery.Order.IsNullOrEmpty())
            {
                List<string> orderList = paginationQuery.Order.Select(o => o.OrderField + " " + o.Ordering).ToList();
                string orderQuery = String.Join(",", orderList);
                entities = entities.OrderBy(orderQuery);

            }
            var totalCount = entities.Count();
            if (paginationQuery.Page > 0 && paginationQuery.PageSize > 0)
            {
                entities = entities.Skip((paginationQuery.Page - 1) * paginationQuery.PageSize).Take(paginationQuery.PageSize);
            }
            return new PaginationWrapper<T>(entities.ToList(), totalCount);
        }

        public T? GetById(long id, params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> entities = _dbContext.Set<T>();
            if (includes != null)
            {
                foreach (var include in includes)
                {
                    entities = entities.Include(include);
                }
            }
            return entities
                .FirstOrDefault(e => e.Id == id);
        }

        public T Update(T entity)
        {
            entity.ModifiedDate = DateTime.UtcNow;
            _dbContext.Set<T>().Update(entity);
            return entity;
        }
    }
}
