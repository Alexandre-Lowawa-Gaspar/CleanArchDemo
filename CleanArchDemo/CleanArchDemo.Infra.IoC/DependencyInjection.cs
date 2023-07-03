using CleanArchDemo.Infra.Repository.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchDemo.Infra.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            options
            .UseMySql(configuration.GetConnectionString("CleanArchDemoConnectionString"), ServerVersion.Parse("10.4.21-MariaDB"), b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)), ServiceLifetime.Transient);
            services.AddScoped<IApplicationDbContext>(op => op.GetService<ApplicationDbContext>());

            return services;
        }
    }
}