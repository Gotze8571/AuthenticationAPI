using Generic.Core.Models;
using Generic.Domain.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Domain.Repositories.Concrete
{
    public class GetUserProfile : IGetUser
    {
        public Task<UserProfile> GetUserDetails(string UserID)
        {
            var result = "";
             return null;
        }
    }
}
