using System.Collections.Generic;
using System.Threading.Tasks;

public interface IUserRepository : IRepository<SchoolAppASP.Core.Entities.Users>
{
    Task<IEnumerable<SchoolAppASP.Core.Entities.Users>> GetUsersByLastName(string lastName);
}