using System.Linq.Expressions;
using WebStore.Core;

namespace WebStore.Infrastructure.Interfaces;

public interface IRepository<T> where T : EntityBase
{
    T? GetById(Guid id);
    IEnumerable<T> List();
    IEnumerable<T> List(Expression<Func<T, bool>> predicate);
    bool Add(T entity);
    bool Delete(Guid id);
    bool Update(T entity);
}
