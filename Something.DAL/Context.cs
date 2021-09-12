using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Something.DAL.Configuration;
using Something.Domain;
using Something.Domain.Models;

namespace Something.DAL
{
    public class Context : DbContext
    {
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<User> Users { get; set; }

        public Context(DbContextOptions<Context> options)
            : base(options)
        { 
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.UserRolesInit();
            builder.UsersInit();
        }
    }
}
