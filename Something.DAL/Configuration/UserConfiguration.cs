using Microsoft.EntityFrameworkCore;
using Something.Domain;
using Something.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Something.DAL.Configuration
{
    public static class UserConfiguration
    {
        public static void UsersInit(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(GetDefaultUsers());
        }

        private static ICollection<User> GetDefaultUsers()
        {
            return new User[]
            {
                new User { Id = 1, Name = Role.General.ToString(), UserRoleId = Role.General},
                new User { Id = 2, Name = Role.Vip.ToString(), UserRoleId = Role.Vip},
                new User { Id = 3, Name = Role.StorageManager.ToString(), UserRoleId = Role.StorageManager},
                new User { Id = 4, Name = Role.Admin.ToString(), UserRoleId = Role.Admin},
            };
        }
    }
}
