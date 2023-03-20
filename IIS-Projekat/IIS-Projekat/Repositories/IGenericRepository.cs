using IIS_Projekat.Models;
using IIS_Projekat.Models.DTOs.Pagination;
using System.Linq.Expressions;

namespace IIS_Projekat.Repositories
{
    public interface IGenericRepository<T> where T : class, IEntity
    {
        public IQueryable<T> GetAll(params Expression<Func<T, object>>[] includes);
        public PaginationWrapper<T> Filter(PaginationQuery? paginationQueryDTO, params Expression<Func<T, object>>[] includes);
        public T? GetById(long id, params Expression<Func<T, object>>[] includes);
        public T? Create(T entity);
        public T Update(T entity);
        public void Delete(T entity);
    }
}
