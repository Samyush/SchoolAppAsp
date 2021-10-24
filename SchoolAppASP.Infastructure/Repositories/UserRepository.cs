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
            return await _userContext.Users.Where(m => m.LastName == lastName).ToListAsync();
        }

        //trying upon Login of the applicaiton
        public async Task<IEnumerable<UsersDB>> Login(string email, string phoneNum)
        {
            return await _userContext.Users.Where(m => m.Email == email && m.PhoneNumber == phoneNum).ToListAsync();
        }
    }
}
