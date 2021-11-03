using Microsoft.EntityFrameworkCore;
using SchoolAppASP.Core.Entities;

namespace SchoolAppASP.Infastructure.Data
{
    public class SchoolAppDbContext : DbContext
    {
       
        //public DbSet<SchoolAppASP.Core.Entities.UsersDB> Users { get; set; }
        public DbSet<UsersDB> Users { get; set; }
        public DbSet<Students> Students { get; set; }
        public DbSet<Teachers> Teachers { get; set; }

        public SchoolAppDbContext(DbContextOptions<SchoolAppDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

    }

}
    
