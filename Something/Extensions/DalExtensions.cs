using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Something.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Something.API.Extensions
{
    public static class DalExtensions
    {
        public static IServiceCollection AddDal(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<Context>(options =>
                options.UseNpgsql(configuration.GetConnectionString("FirstDatabase")));

            return services;
        }
    }
}
