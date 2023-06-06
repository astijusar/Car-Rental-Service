using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using VehicleCatalogAPI.Models;

namespace VehicleCatalogAPI.Repository
{
    public abstract class BaseRepository<T> where T : class
    {
        protected ApplicationDbContext _context;
        protected DbSet<T> dbSet;

        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
            dbSet = context.Set<T>();
        }

        public void Add(T entity) => dbSet.Add(entity);
        public void Update(T entity) => dbSet.Update(entity);
        public void Remove(T entity) => dbSet.Remove(entity);

        public IQueryable<T> FindAll(bool trackChanges) =>
            !trackChanges
                ? dbSet.AsNoTracking()
                : dbSet;

        public IQueryable<T> FindBy(Expression<Func<T, bool>> expression, bool trackChanges) =>
            !trackChanges
                ? dbSet.Where(expression)
                    .AsNoTracking()
                : dbSet.Where(expression);
    }
}
