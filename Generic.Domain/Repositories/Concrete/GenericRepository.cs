using Generic.Domain.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MicroOrm.Dapper.Repositories;

namespace Generic.Domain.Repositories.Concrete
{
    public class GenericRepository
    {
        //protected DapperRepository<T> repository;
        //public GenericRepository(DapperRepository<T> repo)
        //{
        //    repository = repo;
        //}
        //public Task<int> BulkInsertAsync(IEnumerable<T> items, IDbTransaction transaction = null)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<bool> DeleteAsync(T item)
        //{
        //    throw new NotImplementedException();
        //}

        //public virtual async Task<bool> DeleteAsync(Expression<Func<T, bool>> predicate, IDbTransaction transaction = null)
        //{
        //    return await repository.DeleteAsync(predicate);
        //}

        //public virtual async Task<IEnumerable<T>> FindAllAsync()
        //{
        //    return await repository.FindAllAsync();
        //}

        //public virtual async Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> predicate)
        //{
        //    return await repository.FindAllAsync(predicate);
        //}

        //public virtual async Task<T> FindAsync(Expression<Func<T, bool>> predicate)
        //{
        //    return await repository.FindAsync(predicate);
        //}

        //public virtual async Task<T> FindByIdAsync(object id)
        //{
        //    return await repository.FindByIdAsync(id);
        //}

        //public Task<bool> InsertAsync(T item)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<IEnumerable<T>> LockoutAsync(string username, string password)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<IEnumerable<T>> LoginAsync(string username, string password)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<IEnumerable<T>> UnlockAsync(string username, string password)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<bool> UpdateAsync(T item, params Expression<Func<T, object>>[] includes)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
