using Dji.Cloud.Infrastructure.Abstracts.Interfaces;
using Dji.Cloud.Infrastructure.MySql.DataContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Linq.Expressions;

namespace Dji.Cloud.Infrastructure.MySql.Repositories;

public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
{
    private readonly DjiDbContext _dbContext;

    public GenericRepository(DjiDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Task AddAsync(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task<TEntity> FindAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate, int page, int pageSize)
    {
        var queryable = GetQueryable();

        var result = await queryable.Where(predicate)
                                    .Skip(page * pageSize)
                                    .Take(pageSize)
                                    .ToArrayAsync();

        return result;
    }

    public async Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate)
    {
        var queryable = GetQueryable();

        var result = await queryable.Where(predicate).ToArrayAsync();

        return result;
    }

    public async Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
    {
        var queryable = GetQueryable();

        var result = await queryable.FirstOrDefaultAsync(predicate);

        return result!;
    }

    public Task<IEnumerable<TEntity>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public IQueryable<TEntity> GetQueryable()
    {
        var result = _dbContext.Set<TEntity>().AsQueryable();

        return result;
    }

    public async Task UpdateAsync(TEntity entity)
    {
        _dbContext.Set<TEntity>().Update(entity);

        await SaveChangesAsync();
    }

    public async Task<long> GetCountAsync()
    {
        var result = await _dbContext.Set<TEntity>().CountAsync();

        return result;
    }

    public Task<long> GetCountAsync(Expression<Func<TEntity, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public async Task SaveChangesAsync()
    {
        await _dbContext.SaveChangesAsync();
    }
}
