using System.Collections.Generic;
using System.Threading.Tasks;

//SchoolAppASP.Core.Entities.UsersDB -> the UserDB class should be namesspaced as SchoolAppASP.Core.Entities only

public interface IUserRepository : IRepository<SchoolAppASP.Core.Entities.UsersDB>
{
    Task<IEnumerable<SchoolAppASP.Core.Entities.UsersDB>> GetUsersByLastName(string lastName);
}