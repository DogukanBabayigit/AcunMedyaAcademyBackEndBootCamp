using System;
using System.Linq.Expressions;
using EShop.Data.Abstract;
using EShop.Data.Concrete.Contexts;

namespace EShop.Data.Concrete.Repositories;

public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
{
    private readonly EShopDbContext? _context;

    public GenericRepository(EShopDbContext? context)
    {
        _context = context;
    }

    public Task<int> CountAsync()
    {
        throw new NotImplementedException();
    }

    public Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public void Delete(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task<bool> ExistAsync(Expression<Func<TEntity, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<TEntity>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate = null, Func<IQueryable<TEntity>, IQueryable<TEntity>> orderBy = null, Func<IQueryable<TEntity>, IQueryable<TEntity>> includes = null)
    {
        throw new NotImplementedException();
    }

    public async Task<TEntity> GetAsync(int id)
    {
        return await 
    }

    public Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate, Func<IQueryable<TEntity>, IQueryable<TEntity>> includes)
    {
        throw new NotImplementedException();
    }

    public Task<TEntity> GetByIdAsync(params int[] id)
    {
        throw new NotImplementedException();
    }

    public void Update(TEntity entity)
    {
        throw new NotImplementedException();
    }
}
