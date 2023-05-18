using System.Linq.Expressions;

namespace Dji.Cloud.Infrastructure.Abstracts.Interfaces;

public interface IGenericRepository<TEntity> where TEntity : class
{
    Task<TEntity> FindAsync(int id);
    Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate, int page, int pageSize);
    Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate);
    Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);
    Task<IEnumerable<TEntity>> GetAllAsync();
    Task AddAsync(TEntity entity);
    Task DeleteAsync(TEntity entity);
    Task UpdateAsync(TEntity entity);
    Task<long> GetCountAsync();
    Task<long> GetCountAsync(Expression<Func<TEntity, bool>> predicate);
    IQueryable<TEntity> GetQueryable();
    Task SaveChangesAsync();
}
