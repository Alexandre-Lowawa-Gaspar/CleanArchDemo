using CleanArchDemo.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchDemo.Infra.Repository.Context
{
    public interface IApplicationDbContext
    {
        DbSet<Student> Student { get; set; }
    }
}