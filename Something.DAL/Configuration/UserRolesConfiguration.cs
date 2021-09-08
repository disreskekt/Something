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
    public static class UserRolesConfiguration
    {
        public static void UserRolesInit(this ModelBuilder modelBuilder)
        {
            var userRoles = new UserRole[]
            {
                new UserRole { Id = Role.General, Name = Role.General.ToString()},
                new UserRole { Id = Role.Vip, Name = Role.Vip.ToString()},
                new UserRole { Id = Role.StorageManager, Name = Role.StorageManager.ToString()},
                new UserRole { Id = Role.Admin, Name = Role.Admin.ToString()}
            };

            modelBuilder.Entity<UserRole>().HasData(userRoles);
        }
    }
}
