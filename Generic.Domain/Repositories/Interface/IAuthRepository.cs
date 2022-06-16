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
        Task<List<UserProfile>> GetUserInfo(string userId);
        Task<UserProfile> SingleUserInfo(string userId);
        Task<UserProfile> DeleteUserInfo(string userId);
        Task<UserProfile> GetAllUserInfo();
    }
}
