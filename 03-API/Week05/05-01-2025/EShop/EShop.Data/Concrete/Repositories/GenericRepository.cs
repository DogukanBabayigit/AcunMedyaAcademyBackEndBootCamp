using System;
using System.Linq.Expressions;
using EShop.Data.Abstract;
using EShop.Data.Concrete.Contexts;
using Microsoft.EntityFrameworkCore;

namespace EShop.Data.Concrete.Repositories;

public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
{
    private readonly EShopDbContext? _dbcontext;

    private readonly DbSet<TEntity> _dbSet;

    public GenericRepository(EShopDbContext dbcontext)
    {
        _dbcontext = dbcontext;
        _dbSet = dbcontext.Set<TEntity>();
    }

    public async Task<TEntity> AddAsync(TEntity entity)
    {
        await _dbSet.AddAsync(entity);
        return entity; // Ekleme işlemi yapıldıktan sonra geriye eklenen entity döner.
    }

    public Task<int> CountAsync()
    {
        throw new NotImplementedException();
    }

    public Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate)
    {
        return _dbSet.CountAsync(predicate); // CountAsync metodu, veritabanında kaç tane kayıt olduğunu döner.
    }
    public async Task<bool> ExistAsync(Expression<Func<TEntity, bool>> predicate)
    {
        return await _dbSet.AnyAsync(predicate); // AnyAsync metodu, veritabanında bir kayıt var mı yok mu diye kontrol eder. Eğer kayıt varsa true, yoksa false döner.
    }

    public Task<IEnumerable<TEntity>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate = null, Func<IQueryable<TEntity>, IQueryable<TEntity>> orderBy = null, Func<IQueryable<TEntity>, IQueryable<TEntity>>[] includes = null)
    {
        IQueryable<TEntity> query = _dbSet;
        if (predicate != null)
        {
            query = query.Where(predicate);
        }
        if (orderBy != null)
        {
            query = orderBy(query);
        }
        if (includes != null)
        {
            query = includes.Aggregate(query, (current, include) => include(current));
        }

        var result = await query.ToListAsync();
        return result;
    }

    public Task<TEntity> GetAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate = null, params Func<IQueryable<TEntity>, IQueryable<TEntity>>[] includes)
    {
        IQueryable<TEntity> query = _dbSet;

        if (predicate != null)
        {
            query = query.Where(predicate);
        }

        if (includes != null)
        {
            query = includes.Aggregate(query, (current, include) => include(current)); // Bir den fazla include işlemi yapılabilir. // Aggregate fonksiyonu ile bir dizi içerisindeki tüm elemanlar üzerinde işlem yapılabilir.
        }

        var result = await query.FirstOrDefaultAsync();
        return result; // Bu şekilde hangi türde veri döneceğini anlamış oluruz.

        //_dbSet = context.Products();
        // query = query.contextç.Products;
        // predicate = p => p.IsDeleted == true;
        // query = context.Products.Where(p => p.IsDeleted == false);
        //includes[] = [include(x => x.Category), include(x => x.Brand)]
        // query = context.Products.Where(p => p.IsDeleted == false).Include(x => x.Category).Include(x => x.Brand);
    }

    public Task<TEntity> GetByIdAsync(params int[] id)
    {
        throw new NotImplementedException();
    }

    public void Update(TEntity entity)
    {
        _dbSet.Update(entity);// Update metodu, veritabanında bir kaydı güncellemek için kullanılır.
    }

    public void Delete(TEntity entity)
    {
        _dbSet.Remove(entity); // Remove metodu, veritabanında bir kaydı silmek için kullanılır.
    }
}
