using CleanArchDemo.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchDemo.Infra.Repository.Context
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Student { get; set; }
    }
}