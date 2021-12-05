using Generic.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Domain.Repositories.Interface
{
    public interface IGetUser
    {
        Task<UserProfile> GetUserDetails(string UserID);
    }
}
