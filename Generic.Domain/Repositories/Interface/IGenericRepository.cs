using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Domain.Repositories.Interface
{
    public interface IGenericRepository<T>
    {
        Task<IEnumerable<T>> FindAllAsync();
        Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> predicate);
        Task<T> FindByIdAsync(object id);
        Task<T> FindAsync(Expression<Func<T, bool>> predicate);
        Task<bool> InsertAsync(T item);
        Task<int> BulkInsertAsync(IEnumerable<T> items, IDbTransaction transaction = null);
        Task<bool> UpdateAsync(T item, params Expression<Func<T, object>>[] includes);
        Task<bool> DeleteAsync(T item);
        Task<bool> DeleteAsync(Expression<Func<T, bool>> predicate, IDbTransaction transaction = null);
    }
}
