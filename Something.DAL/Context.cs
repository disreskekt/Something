using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Something.Domain;

namespace Something.DAL
{
    public class Context : DbContext
    {
        //public IConfiguration _configuration { get; }
        //public Context(IConfiguration configuration)
        //{
        //    _configuration = configuration;
        //}

        public DbSet<User> Users { get; set; }

        public Context(DbContextOptions<Context> options)
            : base(options)
        { 
            Database.EnsureCreated();
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseNpgsql(_configuration.GetConnectionString("FirstDatabase"));
        //}
    }
}
