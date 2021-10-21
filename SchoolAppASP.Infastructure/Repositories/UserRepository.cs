using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolAppASP.Core.Entities;
using SchoolAppASP.Infastructure.Data;

namespace SchoolAppASP.Infastructure.Repositories
{
    public class UserRepository: Repository <SchoolAppASP.Core.Entities.UsersDB>, IUserRepository
    {
        public UserRepository(UserContext userContext) : base(userContext) {}

        public async Task<IEnumerable<UsersDB>> GetUsersByLastName(string lastName)
        {
            return await _userContext.Users1.Where(m => m.LastName == lastName).ToListAsync();
        }
    }
}
