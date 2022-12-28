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
        


        public Task<User_Details> CreateUser(User_Details user)
        {
            try
            {
                if ((user.UserID == null) || (user.FirstName == null)
                    || (user.LastName == null) || (user.UserPix == null))
                {

                }
                else
                {
                    return null;
                }
                return null;
            }
            catch (Exception ex)
            {

            }

            
        }
        public Task<UserProfile> DeleteUserInfo(UserProfile user)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User_Details>> FindAllAsync()
        {
            var userDetails = "";
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

        public Task<User_Details> GetAllUserInfo()
        {
            throw new NotImplementedException();
        }

        public Task<List<User_Details>> GetAllUserInfo(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<List<User_Details>> GetUserInfo(string userId)
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

        public Task<User_Details> LockoutUser(string username, string password)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User_Details>> LoginAsync(string username, string password)
        {
            throw new NotImplementedException();
        }

        public Task<User_Details> LoginUser(string username, string password)
        {
            throw new NotImplementedException();
        }

        public async Task<User_Details> SingleUserInfo(string userId)
        {
            //var result =  await _repository.
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User_Details>> UnlockAsync(string username, string password)
        {
            throw new NotImplementedException();
        }

        public Task<User_Details> UnlockUser(string username, string password)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(User_Details item, params Expression<Func<User_Details, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public Task<User_Details> UpdateUserInfo(User_Details user)
        {
            var changeUserProfile = true;
            if (changeUserProfile == true)
            {
               // conn = 
            }
            throw new NotImplementedException();
        }

        public Task<bool> DeleteUserInfo(User_Details user)
        {
            throw new NotImplementedException();
        }

        //Task<bool> IAuthRepository.DeleteUserInfo(User_Details user)
        //{
        //    throw new NotImplementedException();
        //}

        //Task<User_Details> IAuthRepository.UnlockUser(string username, string password)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
