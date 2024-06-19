﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD___Entity_Frameworks
{
    using Microsoft.EntityFrameworkCore;

    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"YourConnectionStringHere"); // Replace with your actual connection string
        }
    }

}
