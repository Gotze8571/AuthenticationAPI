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
        Task<List<UserProfile>> GetAllUserInfo(string userId);
        Task<UserProfile> SingleUserInfo(string userId);
        Task<UserProfile> LoginUser(string username, string password);
        Task<bool> CreateUser(UserProfile user);
        Task<bool> DeleteUserInfo(UserProfile user);
        Task<UserProfile> LockoutUser(string username, string password);
        Task<UserProfile> UnlockUser(string username, string password);
        Task<UserProfile> UpdateUserInfo(UserProfile user);
    }
}
