using Generic.Core.Models;
using Generic.Domain.Repositories.Interface;
using MicroOrm.Dapper.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Domain.Repositories.Concrete
{
    public class AuthRepository
    {
        private DapperRepository<User_Details> _repository;
        //public AuthRepository(DapperRepository<User_Details> repository)
        //{
        //    _repository = repository;
        //}
        
    }
}
