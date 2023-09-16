using MovieManagement.DataAccess.Context;
using MovieManagement.Domain.Repository;
using System.Linq.Expressions;

namespace MovieManagement.DataAccess.Implementations
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly MovieManagementDbContext _movieManagementDbContext;
        public GenericRepository(MovieManagementDbContext movieManagementDbContext)
        {
            _movieManagementDbContext = movieManagementDbContext;
        }

        public void Add(T entity)
        {
            _movieManagementDbContext.Set<T>().Add(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            _movieManagementDbContext.Set<T>().AddRange(entities);
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return _movieManagementDbContext.Set<T>().Where(predicate);
        }

        public IEnumerable<T> GetAll()
        {
            return _movieManagementDbContext.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _movieManagementDbContext.Set<T>().Find(id)!;
        }

        public void Remove(T entity)
        {
            _movieManagementDbContext.Set<T>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            _movieManagementDbContext.Set<T>().RemoveRange(entities);
        }
    }
}
