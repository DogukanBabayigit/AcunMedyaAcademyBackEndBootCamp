using System;
using System.Linq.Expressions;

namespace EShop.Data.Abstract;

public interface IGenericRepository<TEntity> where TEntity : class
{
    Task<TEntity> GetAsync(int id);
    Task<TEntity> GetByIdAsync(params int[] id);
    Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate, Func<IQueryable<TEntity>, IQueryable<TEntity>> includes);

    Task<IEnumerable<TEntity>> GetAllAsync();
    Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate = null, Func<IQueryable<TEntity>, IQueryable<TEntity>> orderBy = null, Func<IQueryable<TEntity>, IQueryable<TEntity>> includes = null);

    Task<bool> ExistAsync(Expression<Func<TEntity, bool>> predicate);
    Task<int> CountAsync();
    Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate);
    void Update(TEntity entity);
    void Delete(TEntity entity);
}
