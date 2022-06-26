using Generic.Core.Models;
using Generic.Domain.Repositories.Interface;
using MicroOrm.Dapper.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Domain.Repositories.Concrete
{
    public class AuthRepository : IAuthRepository
    {
        private DapperRepository<UserProfile> _repository;

        

        public Task<bool> CreateUser(UserProfile user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Expression<Func<User_Details, bool>> predicate, IDbTransaction transaction = null)
        {
            throw new NotImplementedException();
        }

        public Task<UserProfile> DeleteUserInfo(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<UserProfile> DeleteUserInfo(UserProfile user)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User_Details>> FindAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User_Details>> FindAllAsync(Expression<Func<User_Details, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<User_Details> FindAsync(Expression<Func<User_Details, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<User_Details> FindByIdAsync(object id)
        {
            throw new NotImplementedException();
        }

        public Task<UserProfile> GetAllUserInfo()
        {
            throw new NotImplementedException();
        }

        public Task<List<UserProfile>> GetAllUserInfo(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserProfile>> GetUserInfo(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertAsync(User_Details item)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User_Details>> LockoutAsync(string username, string password)
        {
            throw new NotImplementedException();
        }

        public Task<UserProfile> LockoutUser(string username, string password)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User_Details>> LoginAsync(string username, string password)
        {
            throw new NotImplementedException();
        }

        public Task<UserProfile> LoginUser(string username, string password)
        {
            throw new NotImplementedException();
        }

        public async Task<UserProfile> SingleUserInfo(string userId)
        {
            //var result =  await _repository.
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User_Details>> UnlockAsync(string username, string password)
        {
            throw new NotImplementedException();
        }

        public Task<UserProfile> UnlockUser(string username, string password)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(User_Details item, params Expression<Func<User_Details, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public Task<UserProfile> UpdateUserInfo(UserProfile user)
        {
            throw new NotImplementedException();
        }

        Task<bool> IAuthRepository.DeleteUserInfo(UserProfile user)
        {
            throw new NotImplementedException();
        }
        //public AuthRepository(DapperRepository<User_Details> repository)
        //{
        //    _repository = repository;
        //}

    }
}
