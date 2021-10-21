using System;
using Microsoft.EntityFrameworkCore;

namespace SchoolAppASP.Infastructure.Data
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options) { }
        public DbSet<SchoolAppASP.Core.Entities.UsersDB> Users1 { get; set; }
    }

}
    
