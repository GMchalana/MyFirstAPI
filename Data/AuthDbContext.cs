using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyFirstAPI.Models;

namespace MyFirstAPI.Data
{
    public class AuthDbContext : DbContext
    {
         public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options) { }

        public DbSet<User> users { get; set; }  // Table for Users
    }
}