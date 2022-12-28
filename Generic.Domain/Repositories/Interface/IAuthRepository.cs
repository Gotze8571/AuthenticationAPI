using Generic.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Domain.Repositories.Interface
{
    public interface IAuthRepository
    {
        Task<List<User_Details>> GetAllUserInfo(string userId);
        Task<User_Details> SingleUserInfo(string userId);
        Task<User_Details> LoginUser(string username, string password);
        Task<User_Details> CreateUser(User_Details user);
        public Task<bool> DeleteUserInfo(User_Details user);
        Task<User_Details> LockoutUser(string username, string password);
        Task<User_Details> UnlockUser(string username, string password);
        Task<User_Details> UpdateUserInfo(User_Details user);
    }
}
