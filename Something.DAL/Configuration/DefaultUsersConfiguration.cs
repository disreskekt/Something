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
    public static class DefaultUsersConfiguration
    {
        public static void DefaultUsersInit(this ModelBuilder modelBuilder)
        {
            var defaultUsers = new User[]
            {
                new User { Id = 1, Name = Role.General.ToString(), UserRoleId = Role.General},
                new User { Id = 2, Name = Role.Vip.ToString(), UserRoleId = Role.Vip},
                new User { Id = 3, Name = Role.StorageManager.ToString(), UserRoleId = Role.StorageManager},
                new User { Id = 4, Name = Role.Admin.ToString(), UserRoleId = Role.Admin},
            };

            modelBuilder.Entity<User>().HasData(defaultUsers);
        }
    }
}
