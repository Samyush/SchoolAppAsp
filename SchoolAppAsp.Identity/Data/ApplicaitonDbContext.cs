using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SchoolAppAsp.Identity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolAppAsp.Identity.Data
{
    public class ApplicaitonDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicaitonDbContext(DbContextOptions<ApplicaitonDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
