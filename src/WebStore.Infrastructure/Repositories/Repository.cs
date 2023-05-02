using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using WebStore.Core;
using WebStore.Migrations;
using WebStore.Infrastructure.Interfaces;

namespace WebStore.Infrastructure.Repositories;

public class Repository<T> : IRepository<T> where T : EntityBase
{
    private readonly WebStoreContext _dbContext;

    protected Repository(WebStoreContext dbContext)
    {
        _dbContext = dbContext;
    }

    public virtual T? GetById(Guid id)
    {
        return _dbContext.Set<T>().Find(id);
    }

    public virtual IEnumerable<T> List()
    {
        return _dbContext.Set<T>().AsEnumerable();
    }

    public virtual IEnumerable<T> List(Expression<Func<T, bool>> predicate)
    {
        return _dbContext.Set<T>()
            .Where(predicate)
            .AsEnumerable();
    }

    public bool Add(T entity)
    {
        _dbContext.Set<T>().Add(entity);
        _dbContext.SaveChanges();
        return true;
    }

    public bool Update(T entity)
    {
        if (this.GetById(entity.Id) is null) {
            return false;
        }

        _dbContext.Entry(entity).State = EntityState.Modified;
        _dbContext.SaveChanges();
        return true;
    }

    public bool Delete(Guid id)
    {
        var entity = this.GetById(id);
        if (entity is null) {
            return false;
        }

        _dbContext.Set<T>().Remove(entity);
        _dbContext.SaveChanges();
        return true;
    }
}