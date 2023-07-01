using CleanArchDemo.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchDemo.Infra.Repository.Data
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            options
            .UseMySql(configuration.GetConnectionString("CleanArchDemoConnectionString"),ServerVersion.Parse("10.4.21-MariaDB"),b=>b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)),ServiceLifetime.Transient);
            services.AddScoped<IApplicationDbContext>(options => options.GetService<ApplicationDbContext>());
          /*  services.AddScoped(sp =>
            sp.GetRequiredService<ApplicationDbContext>());

            services.AddScoped(typeof(IRepositoryBase<>),typeof(RepositoryBase<>));  
         */
        return services;
        }
    }
}
