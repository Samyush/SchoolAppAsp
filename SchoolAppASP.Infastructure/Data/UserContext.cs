﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace SchoolAppASP.Infastructure.Data
{
    public class UserContext : DbContext
    {
       
        public DbSet<SchoolAppASP.Core.Entities.UsersDB> Users1 { get; set; }

        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

    }

   

}
    
