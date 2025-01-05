using System;
using EShop.Data.Abstract;
using EShop.Data.Concrete.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EShop.Data.Concrete;

public class UnitOfWork : IUnitOfWork
{
    private readonly EShopDbContext _Dbcontext;

    private readonly IServiceProvider _serviceProvider;
    public void Dispose()
    {
        _Dbcontext.Dispose();
    }

    public IGenericRepository<TEntity>? GetRepository<TEntity>() where TEntity : class
    {
        var repository = _serviceProvider.GetRequiredService<IGenericRepository<TEntity>>();
        return repository;
    }

    public int Save()
    {
        return _Dbcontext.SaveChanges();
    }

    public async Task<int> SaveAsync()
    {
        return await _Dbcontext.SaveChangesAsync();
    }
}
